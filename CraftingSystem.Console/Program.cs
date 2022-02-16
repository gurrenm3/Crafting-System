// See https://aka.ms/new-console-template for more information
using CraftingSystem.Lib;

Console.WriteLine("Hello, World!");

Weapon sword = new Weapon();

var handle = new CraftingIngredient();
var handleDamage = handle.AddBehavior<StatModifier>();
handleDamage.type = StatType.Damage;
handleDamage.SetAmount(3.5);

var blade = new CraftingIngredient();
var bladeDamage = blade.AddBehavior<StatModifier>();
bladeDamage.type = StatType.Damage;
bladeDamage.SetAmount(10);

sword.AddBehavior(handle);
sword.AddBehavior(blade);


var totalDamage = sword.GetStatValue(StatType.Damage);

Console.WriteLine($"Total Damage:  {totalDamage}");