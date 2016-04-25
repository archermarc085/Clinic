﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Interfaces
{
    interface IServiceType
    {
        string Name { get; }
        string Code { get; }
        decimal Cost { get; set; }
    }
}
