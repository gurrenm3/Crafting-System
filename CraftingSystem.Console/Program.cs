// See https://aka.ms/new-console-template for more information

using CraftingSystem.Lib.Materials;

Console.WriteLine("Welcome to the crafting system");

// code here:
var copper = new Metal();
var tin = new Metal();
var bronze = Alloy.CreateFrom(copper, tin);
var bronzeBar = new MetalIngot(bronze);

Console.WriteLine("Done running");
