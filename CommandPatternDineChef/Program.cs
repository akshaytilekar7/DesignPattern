using CommandPatternDineChef.Invokers;
using CommandPatternDineChef.Models;
using System;
using System.Collections.Generic;

namespace CommandPatternDineChef
{
    class Program
    {
        static void Main(string[] args)
        {
            DineChef dineChef = new DineChef();
            /* Insert Order */
            var x = new MenuItem()
            {
                TableNumber = 1,
                Item = "Super Mega Burger",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese," }, new Tag() { TagName = " Tomato" } }
            };
            dineChef.ExecuteCommand(1, x);
            dineChef.ShowCurrentOrder();

            x = new MenuItem()
            {
                TableNumber = 1,
                Item = "Cheese Sandwich",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Spicy Mayo," } }
            };
            dineChef.ExecuteCommand(1, x);
            dineChef.ShowCurrentOrder();

            x = new MenuItem()
            {
                TableNumber = 1,
                Item = "Cheese Sandwich"
            };
            dineChef.ExecuteCommand(3, x);
            dineChef.ShowCurrentOrder();

            x = new MenuItem()
            {
                TableNumber = 1,
                Item = "Super Mega Burger",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese" } }
            };
            dineChef.ExecuteCommand(2, x);
            dineChef.ShowCurrentOrder();

            Console.ReadKey();
        }
    }
}

/*
very good way to decrease the coupling between sender and receive
helpful for wizards, progress bars, GUI buttons, menu actions, and other transactional behaviors, undo redo
*/
