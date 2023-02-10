using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eHMODTO { klalit = 0, macabi=1, leumit=2, meuchedet=3 }
    public enum eKindDTO { male=0, female=1 }
    public class UserDTO
    {
        public int UserId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eKindDTO Kind { get; set; }
        public eHMODTO HMO { get; set; }
    }
}