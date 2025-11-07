using Command_pattern;

Product product = new("Laptop", 1000);
ModifyPrice modifyPrice = new();

ExecuteCommand(modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));
ExecuteCommand(modifyPrice, new ProductCommand(product, PriceAction.Decrease, 50));
ExecuteCommand(modifyPrice, new ProductCommand(product, PriceAction.Increase, 200));

Console.WriteLine(product);


static void ExecuteCommand(ModifyPrice modifyPrice, ProductCommand productCommand)
{
    modifyPrice.SetCommand(productCommand);
    modifyPrice.Invoke();
}