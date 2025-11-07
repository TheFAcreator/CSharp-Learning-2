using Prototype;

SandwichMenu sandwichMenu = new();

sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "Cheddar", "Lettuce, Tomato");
sandwichMenu["Club"] = new Sandwich("White", "Turkey", "Swiss", "Lettuce, Tomato, Bacon");
sandwichMenu["Veggie"] = new Sandwich("Whole Grain", "None", "Provolone", "Lettuce, Tomato, Cucumber, Avocado");

SandwichPrototype bltClone = sandwichMenu["BLT"].Clone();
SandwichPrototype clubClone = sandwichMenu["Club"].Clone();
SandwichPrototype veggieClone = sandwichMenu["Veggie"].Clone();