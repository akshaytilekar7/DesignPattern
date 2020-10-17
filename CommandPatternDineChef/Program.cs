using CommandPatternDineChef.Models;
using CommandPatternDineChef.Receivers;
using System;
using System.Collections.Generic;

namespace CommandPatternDineChef
{
    class Program
    {
        static void Main(string[] args)
        {
            DineChefRestaurant dineChef = new DineChefRestaurant();

            var menuItem = new MenuItem()
            {
                TableNumber = 1,
                Item = "Super Mega Burger",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese," }, new Tag() { TagName = " Tomato" } }
            };
            dineChef.ExecuteCommand(Helper.GetCmd(Cmd.NewOrder), menuItem);
            dineChef.ShowCurrentOrder();

            menuItem = new MenuItem()
            {
                TableNumber = 1,
                Item = "Cheese Sandwich",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Spicy Mayo," } }
            };
            dineChef.ExecuteCommand(Helper.GetCmd(Cmd.ModifyOrder), menuItem);
            dineChef.ShowCurrentOrder();

            menuItem = new MenuItem()
            {
                TableNumber = 1,
                Item = "Cheese Sandwich"
            };
            dineChef.ExecuteCommand(Helper.GetCmd(Cmd.RemoveOrder), menuItem);
            dineChef.ShowCurrentOrder();

            menuItem = new MenuItem()
            {
                TableNumber = 1,
                Item = "Super Mega Burger",
                Quantity = 1,
                Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese" } }
            };
            dineChef.ExecuteCommand(Helper.GetCmd(Cmd.ModifyOrder), menuItem);
            dineChef.ShowCurrentOrder();

            Console.ReadKey();
        }
    }
}

/*
very good way to decrease the coupling between sender and receive
helpful for wizards, progress bars, GUI buttons, menu actions, and other transactional behaviors, undo redo
*/
