﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, false)
        {
        }

    }
}
