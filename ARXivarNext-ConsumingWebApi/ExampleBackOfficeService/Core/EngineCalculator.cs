using ExampleBackOfficeService.Entities;
using ExampleBackOfficeService.Models;
using System;
using System.Collections.Generic;


namespace ExampleBackOfficeService.Core
{
    public class EngineCalculator : IEngineCalculator
    {
        public EngineResult Calculate(string id, EngineInfo engineInfo)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new System.ArgumentNullException("id");
            if (engineInfo == null)
                throw new System.ArgumentNullException("engineInfo");

            var result = new EngineResult
            {
                ValueA = "A",
                ValueB = "B"
            };

            return result;
        }
    }
}