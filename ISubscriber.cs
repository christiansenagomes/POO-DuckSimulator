﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public interface ISubscriber
    {
        void Update(bool danger);
    }
}
