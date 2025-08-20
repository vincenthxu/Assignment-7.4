using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._4
{
    public class ParkingSystem(int big, int medium, int small)
    {
        private int bigSpots = big;
        private int mediumSpots = medium;
        private int smallSpots = small;

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    return bigSpots-- > 0;
                case 2:
                    return mediumSpots-- > 0;
                case 3:
                    return smallSpots-- > 0;
                default:
                    return false;
            }
        }
    }
}
