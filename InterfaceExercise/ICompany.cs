﻿using System;
namespace InterfaceExercise
{
    public interface ICompany
    {


        //In ICompany

        /*Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         */


        public string CompanyName { get; set; }
        public string CompanySlogan { get; set; }

    }
}
