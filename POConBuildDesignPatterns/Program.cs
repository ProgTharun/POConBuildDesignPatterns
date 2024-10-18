using POConBuildDesignPatterns.ConcreateBuilder;
using POConBuildDesignPatterns.Director;
using POConBuildDesignPatterns.Model;
using POConBuildDesignPatterns.Types;

namespace POConBuildDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            IComputerBuilder builder = new GamingComputer();
            ComputerDirector computerBuilder = new ComputerDirector(builder);
            computerBuilder.ConstructGamingComputer();
            Console.WriteLine(computerBuilder.GetHashCode());

            Console.WriteLine("====GamingComputer====");
            Computer computers = builder.GetComputer();
            Console.WriteLine(computers);
            Console.WriteLine();

            IComputerBuilder computer = new OfficeComputer();
            ComputerDirector director = new ComputerDirector(computer);
            director.ConstructOfficeComputer();
            Console.WriteLine(director.GetHashCode());

            Console.WriteLine("====Office Computer===");
            Computer computer1=computer.GetComputer();
            Console.WriteLine(computer1);
        }
    }
}
