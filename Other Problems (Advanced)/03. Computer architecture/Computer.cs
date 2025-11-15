using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; } = new List<CPU>();

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
        }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU cpu = Multiprocessor.FirstOrDefault(c => c.Brand == brand);

            if (cpu != null)
            {
                Multiprocessor.Remove(cpu);
                return true;
            }

            return false;
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(c => c.Frequency).First();
        }

        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(c => c.Brand == brand);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var cpu in Multiprocessor)
            {
                report.AppendLine(cpu.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
