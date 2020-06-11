using ExampleBackOfficeService.Entities;
using ExampleBackOfficeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleBackOfficeService.Core
{
    public interface IEngineCalculator
    {
        EngineResult Calculate(string id, EngineInfo engineInfo);
    }
}
