using System.Collections.Generic;
using System.Linq;

namespace _01.Parking_Lot
{
    using System;

    public class ParkingLot
    {
        public static void Main()
        {
            var currentCar = Console.ReadLine();
            
            var parkingLotCars = new HashSet<string>();

            while (currentCar != "END")
            {
                var car = currentCar.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = car[0];
                var plate = car[1];

                if (command == "IN")
                {
                    parkingLotCars.Add(plate);
                }
                else
                {
                    parkingLotCars.Remove(plate);
                }

                currentCar = Console.ReadLine();
            }

            if (parkingLotCars.Count != 0)
            {
                Console.WriteLine(string.Join("\n", parkingLotCars.OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}