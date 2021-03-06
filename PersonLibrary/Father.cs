﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apttus.Assignment.PersonLibrary.GenderEnum;
using static Apttus.Assignment.PersonLibrary.RoleEnum;

namespace Apttus.Assignment.PersonLibrary
{
    public class Father: Man,IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public Role GetRole()
        {
            return Role.Parent;
        }
    }
}
