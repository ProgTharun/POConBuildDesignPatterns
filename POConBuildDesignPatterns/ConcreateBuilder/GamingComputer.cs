using POConBuildDesignPatterns.Director;
using POConBuildDesignPatterns.Model;
using POConBuildDesignPatterns.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuildDesignPatterns.ConcreateBuilder
{
    internal class GamingComputer : IComputerBuilder
    {
        Computer gaming=new Computer();
   
        public void BuildCPU()
        {
            gaming.CPU = "Ryzen 7 ";
            
        }

        public void BuildGPU()
        {
            gaming.GPU = "nVIDIA GEFORCE RTX 4080";
        }

        public void BuildRAM()
        {
            gaming.RAM = "16 GB";
        }

        public void BuildStorage()
        {
          gaming.Storage = "512 GB";
        }

       public Computer GetComputer()
        {
            return gaming;
        }
    }
}
