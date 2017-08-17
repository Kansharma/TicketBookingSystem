using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apttus.Assignment.PersonLibrary.GenderEnum;
using static Apttus.Assignment.PersonLibrary.RoleEnum;

namespace Apttus.Assignment.PersonLibrary
{
   public interface IPerson
    {
        Gender Gender { get; set; }
        string Name { get; set; }
        int Age { get; set; }
   
        }
    }


