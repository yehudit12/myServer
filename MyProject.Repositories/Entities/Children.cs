using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
   public class Children
    {
        [Key, Required]
        public int ChildId { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Parent")]
        public int IdParent { get; set; }
        public User Parent { get; set; }

    }
}
