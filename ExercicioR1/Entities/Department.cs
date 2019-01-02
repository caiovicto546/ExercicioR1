using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioR1.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string nome)
        {
            this.Name = nome;
        }
    }
}
