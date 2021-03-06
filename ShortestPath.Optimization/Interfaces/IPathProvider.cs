﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath.Optimization.Interfaces
{
    public interface IPathProvider
    {
        Entities.Path FindPath(Entities.Grid grid, Entities.GridLocation startPoint, Entities.GridLocation endPoint);
    }
}
