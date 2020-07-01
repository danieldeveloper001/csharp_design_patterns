using System;

namespace Project
{
    class Program
    {

        public static void Main(string[] args)
        {
            var computer = new ComputerBuilder()
                .BuildProcessor()
                    .WithName("O7")
                    .WithClock(2.7m)
                    .WithCache(4m)
                    .Add()
                .BuildMemory()
                    .WithCapacity(8, MemoryUnit.GB)
                    .WithType(MemoryType.PCR4)
                    .Add()
                .BuildMemory()
                    .WithCapacity(8, MemoryUnit.GB)
                    .WithType(MemoryType.PCR4)
                    .Add()
                .BuildStorage()
                    .WithCapacity(256, StorageUnit.GB)
                    .WithType(StorageType.SolidDrive)
                    .Add()
                .BuildStorage()
                    .WithCapacity(1, StorageUnit.TB)
                    .WithType(StorageType.HardDrive)
                    .Add()
                .Build();

            Display(computer);
        }

        static void Display(Computer computer)
        {

            Console.WriteLine($"\n> {computer.GetType().Name}");

            Console.WriteLine($"  - Processor");
            Console.WriteLine($"    - {computer.Processor.Name}");

            Console.WriteLine($"  - Memory");
            foreach(var item in computer.Memory)
                Console.WriteLine($"    - {item.Capacity}{item.Unit} {item.Type}");

            Console.WriteLine($"  - Storage");
            foreach(var item in computer.Storage)
                Console.WriteLine($"    - {item.Capacity}{item.Unit} {item.Type}");
        }
    }
}
