using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apttus.Assignment.PersonLibrary.RoleEnum;

namespace Apttus.Assignment.PersonLibrary
{
  public class Husband : Man,IPerson
    {
		public string Role { get; set; }
        public string GetRole()
        {
            return "Husband";
        }
       

    }

}

