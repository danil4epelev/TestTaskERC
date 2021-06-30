using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskERC
{
    public class User
    {
        public User(int id, double hotWater, double coldWater, double electricityDay, double electricityNight)
        {
            Id = id;
            HotWater = hotWater;
            ColdWater = coldWater;
            ElectricityDay = electricityDay;
            ElectricityNight = electricityNight;
        }
        public  int Id { get; set; }

        public double HotWater { get; set; }

        public double ColdWater { get; set; }

        public double ElectricityDay { get; set; }

        public double ElectricityNight { get; set; }
    }
}
