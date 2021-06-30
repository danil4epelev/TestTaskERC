using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskERC.Models
{
    public class BackgroundInformation
    {
        public BackgroundInformation(string service, double rate, double standart, string measurement)
        {
            Service = service;

            Rate = rate;

            Standart = standart;

            Measurement = measurement;
        }
        public string Service { get; set; }

        public double Rate { get; set; }

        public double Standart { get; set; }

        public string Measurement { get; set; }
    }
}
