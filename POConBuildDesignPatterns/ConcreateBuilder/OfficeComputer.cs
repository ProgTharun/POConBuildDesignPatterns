using POConBuildDesignPatterns.Model;
using POConBuildDesignPatterns.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuildDesignPatterns.ConcreateBuilder
{
    internal class OfficeComputer : IComputerBuilder
    {
      private  Computer _computer=new Computer();
        public void BuildCPU()
        {
            _computer.CPU = "Intel Core i7";
        }

        public void BuildGPU()
        {
            _computer.GPU = "RDA 2GB";


        }


        public void BuildRAM()
        {
            _computer.RAM = "8GB";
        }

        public void BuildStorage()
        {
            _computer.Storage = "256GB";
        }

        public Computer GetComputer()
        {
           return _computer;
        }
    }
}
