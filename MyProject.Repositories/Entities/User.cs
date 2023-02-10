using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eHMO { klalit=0,macabi=1,leumit=2,meuchedet=3}
    public enum eKind { male=0, female=1 }
    public class User
    {
        [Key, Required]
        public int UserId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eKind  Kind { get; set; }
        public eHMO HMO { get; set; }

    }
}
