using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers.Models
{
    public class ChildrenModel
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Parent")]
        public int IdParent { get; set; }
    }
}
