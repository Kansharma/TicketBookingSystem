using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apttus.Assignment.PersonLibrary.GenderEnum;

namespace Apttus.Assignment.PersonLibrary
{
  public class Children : IPerson
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}
