﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSynopsis
{
    abstract class Person : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
