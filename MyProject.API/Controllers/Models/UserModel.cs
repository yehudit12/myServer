using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers.Models
{
    public enum eHMOModel { klalit=0, macabi=1, leumit=2, meuchedet=3 }
    public enum eKindModel { male=0, female=1 }
    public class UserModel
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eKindModel Kind { get; set; }
        public eHMOModel HMO { get; set; }
    }
}
