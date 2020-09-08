using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */

        public int HowManyPassagers { get; set; } = 4;
        public string IsItAllTerrian { get; set; } = "No";

        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";
        public int Year { get; set; } = 2017;
        public string TypeOfGas { get; set; } = "Unleaded";


        public string CompanyName { get; set; } = "HONDA";

        public string CompanySlogan { get; set; } = "BUY BUY SALE";

                     



    }




}
