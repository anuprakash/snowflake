﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snowflake.API.Interface
{
    public interface IIdentifier
    {
        string IdentifyGame(string fileName, string platformId);

        string IdentifyGame(FileStream file, string platformId);
    }
}
