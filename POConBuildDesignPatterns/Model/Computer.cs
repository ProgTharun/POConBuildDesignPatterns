using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POConBuildDesignPatterns.Model
{
    internal class Computer
    {
        public string CPU {  get; set; }
        public string GPU{ get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }


        public override string ToString()
        {
            return $"CPU:{CPU}\n"+
                $"GPU:{GPU}\n" +
                $"RAM:{RAM}\n " +
                $"Storage:{Storage}";
        }
    }
}
