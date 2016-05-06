using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSAnalysis.Models
{
    [Table("User_BuildDefinition")]
    public class User_BuildDefinition
    {
        [Key]
        public int DefinitionId { get; set; }
        public string DefinitionName { get; set; }
    }
}
