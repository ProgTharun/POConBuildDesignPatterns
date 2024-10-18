using POConBuildDesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuildDesignPatterns.Types
{
    internal interface IComputerBuilder
    {
       void BuildCPU();
        void BuildGPU();
        void BuildRAM();
        void BuildStorage();
        Computer GetComputer(); 
    }
}
