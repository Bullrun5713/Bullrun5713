﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Identity.Client;
using NutritionReverseLookupAppDemo.Models;

namespace NutritionReverseLookupAppDemo.Service
{
    public class NutritionConsoleService : ConsoleService



    {

        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Search by Nutrition Info"); // bring up submenu 
            Console.WriteLine("2: Select Search by Restaurant"); // bring up submenu
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }


        public void NutritionInfoSubMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Nutrition Search Paramaters:");
            Console.WriteLine("1: Add Calories to search");
            Console.WriteLine("2: Add Sugar to search");
            Console.WriteLine("3: Add Carbohydrates to search");
            Console.WriteLine("4: Add Total Fat to search");
            Console.WriteLine("5: Add Saturated Fat to search");
            Console.WriteLine("6: Add Protien to search");
            Console.WriteLine("7: Add Sodium to search");
            Console.WriteLine("8: Add Gluten Free to search");
            Console.WriteLine("9: run nutrition search");
            Console.WriteLine("10: reset nutrition search");
            Console.WriteLine("0: Back to main menu");
        }

        public void RestaurantSubMenu()
        {

            //user enters researant to search

        }


        public int PromptForInteger(string message, int minimum, int maximum, int? defaultValue = null)
        {
            string defaultPrompt = defaultValue.HasValue ? $"[{defaultValue}]: " : ": ";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{message}{defaultPrompt}");
                Console.ResetColor();
                string input = Console.ReadLine();

                // Did the user take the default value?
                if (input.Trim().Length == 0 && defaultValue.HasValue)
                {
                    return defaultValue.Value;
                }



                if (int.TryParse(input, out int selection) && selection >= minimum && selection <= maximum)
                {
                    return selection;
                }

              

                PrintError($"Number is out of range, please try again.");
            }



        }

        public void PrintMenuItemsToConsole(MenuItems menuItems)
        {

            const int Width = -10;
            for (int i = 0; i < menuItems.PopulatedMenuItems.Count; i++)
            {

                Console.WriteLine($"{menuItems.PopulatedMenuItems[i].RestaurantName,Width} {menuItems.PopulatedMenuItems[i].ItemName,Width * 2} {menuItems.PopulatedMenuItems[i].ItemNutritionInfo.Calories,Width} {menuItems.PopulatedMenuItems[i].ItemNutritionInfo.Sugar, Width} \n");

            }



        }

        public void BackToMainMenu()
        {



        }

        public void ExitProgram()
        {


        }

    }
}
