using composition.Entities.Enums;
using System.Collections.Generic;

namespace composition.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }// usando composição
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double basesalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }



        
    }
}