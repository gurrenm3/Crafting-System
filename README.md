# Crafting-System
A library that lets you make extremely intricate crafting systems for video games. This is a work in progress and **will** have many iterations before it is complete. Do not attempt to use in it's current state.

## What is the purpose of this?
I really enjoy RPG games that let you craft things. For example you could take some steel, wood, and leather, and combine them to make a steel sword. Many games have a mechanic like this. While it's a nice mechanic, they all are limited in that you need to hard code recipies and CANNOT use alloys. I want a crafting system that will work for any number of alloy combinations automatically

### Here's the concept:
As mentioned above, normally games handle crafting with hard coded recipes like this:
```
• 2x Steel bar
• 1x Wood
• 3x Leather piece
```
Each of the items above are hard coded items. They can have little to no variation.

Here's how *this crafting system* works:
1. Rather than hard coded "material based recipes", this system is based off of real life and would take parts.
```
• 1x long blade
• 1x handle
```

2. These parts can be made out of *any* acceptable material. To make a blade that would fit a sword, you'd need:
```
• 2x Metal bars 
```

3. Instead of being bound to Steel for our metal, this recipe accepts *any* metal, including alloys.
That is the difference between this system and traditional crafting systems. This is designed to automatically 
support any combination of materials, as it would work in real life. That means your recipe could be:
```
• 2x Steel
or
• 1x Iron, 1x Bronze
or
• 1x Copper, 0.5x aluminum, 1x Magnesium, 0.5x Tungston
etc
```

4. Make no mistake, these are not hard coded values. It is dynamic to the point the player can choose how much of each material they want to put in. That is the real value of this crafting system. It is so fine tuned and dynamic that anything can be crafted out of any number of replaceable/combinable parts. The system is being designed to work for all forms of crafting, including the following:
```
• items
• weapons/armor
• food
• potions
• etc
```
