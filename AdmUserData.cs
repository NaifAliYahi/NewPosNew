using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewPos
{
   public class AdmUserData
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string OrganizationId { get; set; }
        public string FiscalYear { get; set; } 

    }
}
