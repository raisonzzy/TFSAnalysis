using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TFSAnalysis.Models;
using Microsoft.Data.Entity.Internal;

namespace TFSAnalysis.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 代码提交情况
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 测试情况
        /// </summary>
        /// <returns></returns>
        public IActionResult TestBuild()
        {
            return View();
        }
        /// <summary>
        /// 概览
        /// </summary>
        /// <returns></returns>
        public IActionResult OverView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetAllChangeset()
        {
            var personChangeList = from per in ApplicationDbContext.AppDBContext.DimPerson
                         join changeset in ApplicationDbContext.AppDBContext.DimChangeset
                            on per.PersonSK equals changeset.CheckedInBySK
                         where per.Domain.Equals("WIN-LNKA6BIMQCJ")&& !(new string[] { "LiaoSuYin", "Administrator","管理员" }).Contains(per.Name)
                                   select new ChangesetInfo
                         {
                             PersonSK=per.PersonSK,
                             UserName = per.Name,
                             ChangeCount = changeset.ChangesetSK,
                             LastUpdatedDateTime=changeset.LastUpdatedDateTime.AddHours(8).AddMinutes(-4),
                             ChangesetTitle=changeset.ChangesetTitle
                         };
            List<ChangesetInfo> perList = personChangeList.ToList();
            List<ChangesetInfo> perListLastest = personChangeList.Where(p => p.LastUpdatedDateTime.Month == DateTime.Now.Month).ToList();

            var result = from per in perList
                         group per by per.UserName into pregroup
                         select new ChangesetInfo
                         {
                             UserName = pregroup.Key,
                             ChangeCount = pregroup.Count()
                         };
            var resultLastest = from per in perListLastest
                                group per by per.UserName into pregroup
                                select new ChangesetInfo
                                {
                                    UserName = pregroup.Key,
                                    ChangeCount = pregroup.Count()
                                };
            string vdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return Json(new { result, resultLastest, perListLastest, vdate });
        }

        public ActionResult GetUnitTestOverview()
        {
            List<UnitTestOverViewInfo> overViewList = (from res in ApplicationDbContext.AppDBContext.User_BuildOverView
                                                       orderby res.BuildDefinitionName
                                                       select new UnitTestOverViewInfo
                                                       {
                                                           //ProjectNodeGUID = res.ProjectNodeGUID,
                                                           //ProjectNodeName = res.ProjectNodeName,
                                                           BuildDefinitionName = res.BuildDefinitionName,
                                                           BuildStartTime = res.BuildStartTime,
                                                           BuildBK = res.BuildBK,
                                                           BuildName = res.BuildName,
                                                           BuildSK = res.BuildSK,
                                                           Vdatetime = res.DateTime.Value,
                                                           BuildStatusName = res.BuildStatusName,
                                                           BuildPlatformName = res.BuildPlatformName,
                                                           BuildPlatformSK = res.BuildPlatformSK,
                                                           BuildFlavorName = res.BuildFlavorName,
                                                           BuildFlavorSK = res.BuildFlavorSK,
                                                           BuildQualityName = res.BuildQualityName,
                                                           BlocksCovered = (res.BlocksCovered == null ? 0 : res.BlocksCovered.Value),
                                                           BlocksNotCovered= (res.BlocksNotCovered == null ? 0 : res.BlocksNotCovered.Value),
                                                           FailedCount = (res.FailedCount == null ? 0 : res.FailedCount.Value),
                                                           PassedCount = (res.PassedCount == null ? 0 : res.PassedCount.Value),
                                                           TotalChurn= (res.TotalChurn == null ? 0 : res.TotalChurn.Value),
                                                           CodeCoverage= (res.CodeCoverage == null ? 0 : res.CodeCoverage.Value)
                                                       }).ToList();
            
            
            return Json(overViewList);
        }

        public ActionResult GetBuildEveryDay()
        {
            List<User_BuildEveryDay> buildDetail = ApplicationDbContext.AppDBContext.User_BuildEveryDay.ToList();
            List<BuildEveryDayInfo> builddefinition = (from def in ApplicationDbContext.AppDBContext.User_BuildDefinition
                                                       orderby def.DefinitionName
                                                       select new BuildEveryDayInfo
                                                       {
                                                           DefinitionId=def.DefinitionId,
                                                           DefinitionName=def.DefinitionName
                                                       }).ToList();
            //日期序列
            string th = string.Empty;
            DateTime dtcurent = DateTime.MinValue;
            List<User_BuildEveryDay> buildTempList = null;
            User_BuildEveryDay buildTemp = null;
            for (int i = 25; i >= 0; i--)
            {
                dtcurent = DateTime.Today.AddDays(0 - i);
                th += "<th>" + dtcurent.ToString("MM.dd") + "</th>";
                buildTempList = buildDetail.Where(p => p.DateTime == dtcurent).ToList();
                builddefinition.ForEach(p =>
                {
                    buildTemp = buildTempList.Where(d => d.BuildDefinitionName == p.DefinitionName).FirstOrDefault();
                    if (buildTemp == null)
                    {
                        p.TableContext += "<td style='background-color:cornsilk;'></td>";
                    }
                    else
                    {
                        switch (buildTemp.BuildStatus)
                        {
                            case 8: {
                                    p.TableContext += "<td style='background-color:#c90012;'></td>";
                                    break;
                                }
                            case 2:
                                {
                                    if (buildTemp.PassedCount == null && buildTemp.FailedCount == null)
                                    {
                                        p.TableContext += "<td style='background-color:#ffec35;'></td>";
                                    }
                                    else if (buildTemp.CodeCoverage == null || buildTemp.CodeCoverage.Value < (decimal)0.5)
                                    {
                                        p.TableContext += "<td style='background-color:#d3fa83;'></td>";
                                    }
                                    else
                                    {
                                        p.TableContext += "<td style='background-color:#7bb876;'></td>";
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (buildTemp.FailedCount != null && buildTemp.FailedCount.Value>0)
                                    {
                                        p.TableContext += "<td style='background-color:#f9934a;'></td>";
                                    }
                                    break;
                                }
                        }

                    }
                });
            }


            return Json(new { builddefinition,th });
        }
        public IActionResult Error()
        {
            return View();
        }


    }
    public class UserComparer : IEqualityComparer<UnitTestOverViewInfo>
    {
        public bool Equals(UnitTestOverViewInfo t1, UnitTestOverViewInfo t2)
        {
            return (t1.BuildBK == t2.BuildBK);
        }

        public int GetHashCode(UnitTestOverViewInfo obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
