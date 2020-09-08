using System;
namespace InterfaceExercise
{
    public class SUV : ICompany , IVehicle
    {
        public SUV()
        {
            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */



        }

        public int HowManyPassagers { get; set; } = 8;
        public string IsItAllTerrian { get; set; } = "Yep in gear";

        public string Make { get; set; } = "Lexus";
        public string Model { get; set; } = "XL90";
        public int Year { get; set; } = 2020;
        public string TypeOfGas { get; set; } = "Hybrid";


        public string CompanyName { get; set; } = "Lexus";
        public string CompanySlogan { get; set; } = "Nice if you can afford it";
    }
}
