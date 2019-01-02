using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioR1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime data, double valorPorHora, int hora)
        {
            this.Date = data;
            this.ValuePerHour = valorPorHora;
            this.Hours = hora;
        }


    }
}
