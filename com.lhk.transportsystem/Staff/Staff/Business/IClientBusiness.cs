﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Staff.Business
{
    public interface IClientBusiness
    {
        string SyncData(string errorMessage);
    }
}
