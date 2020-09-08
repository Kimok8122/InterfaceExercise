using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {


            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
        }

        public int HowManyPassagers { get; set; } = 6;
        public string IsItAllTerrian { get; set; } = "Yes";

        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Ram";
        public int Year { get; set; } = 2007;
        public string TypeOfGas { get; set; } = "Desil";


        public string CompanyName { get; set; } = "FORD";
        public string CompanySlogan { get; set; } = "Just Do It"; 
    }
}
