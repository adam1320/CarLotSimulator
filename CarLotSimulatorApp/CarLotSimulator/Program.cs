using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();

            var car1 = new Car();
            car1.Year = 2013;
            car1.Make = "Dodge";
            car1.Model = "Challenger";
            car1.EngineNoise = "Rumble, rumble";
            car1.HonkNoise = "Beep, beep";
            car1.IsDriveable = true;
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            lot.CarList.Add(car1);

            var car2 = new Car(2014, "Ram", "2500", "Clatter", "TrainHorn", true);
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            lot.CarList.Add(car2);


            var car3 = new Car() { Year = 2019, Make = "KIA", Model = "Sorento", EngineNoise = "Purr", HonkNoise = "Beep", IsDriveable = true };
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            lot.CarList.Add(car3);

            foreach (var car in lot.CarList)
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}, {car.EngineNoise}, {car.HonkNoise}");



            //TODO
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //See above for completion of Bonus 1!
            //---------------------------------------







            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
