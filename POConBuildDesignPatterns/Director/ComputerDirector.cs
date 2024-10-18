using POConBuildDesignPatterns.ConcreateBuilder;
using POConBuildDesignPatterns.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuildDesignPatterns.Director
{
    internal class ComputerDirector
    {
        public IComputerBuilder computerBuilder {  get; set; }  

        public ComputerDirector(IComputerBuilder computerbuilder)
        {
            computerBuilder = computerbuilder;
        }

        public void ConstructGamingComputer()
        {
            computerBuilder.BuildCPU();
            computerBuilder.BuildGPU();
            computerBuilder.BuildRAM();
            computerBuilder.BuildStorage();
        }
        public void ConstructOfficeComputer()
        {
            computerBuilder.BuildCPU();
            computerBuilder.BuildGPU();
            computerBuilder.BuildRAM();
            computerBuilder.BuildStorage();
           
        }
    }
}
