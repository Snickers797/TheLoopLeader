﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopLeader.Domain.Abstract
{
    public interface IContent
    {
        void UpdateSection(string contentID, string NewSectionInfo);
    }
}
