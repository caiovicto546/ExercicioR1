using System;
using System.Collections.Generic;
using System.Text;
using ExercicioR1.Entities.Enums;

namespace ExercicioR1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Cont = new List<HourContract>();

        public Worker(string nome, WorkerLevel nivel, double baseDeSalario, Department departamento)
        {
            this.Name = nome;
            this.Level = nivel;
            this.BaseSalary = baseDeSalario;
            this.Department = departamento;
        }

        public void AddContract(HourContract contract)
        {
            Cont.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Cont.Remove(contract);
        }            
    }
}
