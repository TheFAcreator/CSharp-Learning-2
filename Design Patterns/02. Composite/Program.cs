using Composite;

CompositeGift compositeGift = new("Box", 0);
SingleGift singleGift1 = new("Toy", 10);
SingleGift singleGift2 = new("Book", 20);

compositeGift.AddGift(singleGift1);
compositeGift.AddGift(singleGift2);

Console.WriteLine($"Total price of composite gift: {compositeGift.CalculatePrice()}");