namespace Command_pattern
{
    public class ProductCommand : ICommand // Concrete Command
    {
        private readonly Product _product;
        private readonly PriceAction _action;
        private readonly int _amount;

        public ProductCommand(Product product, PriceAction action, int amount)
        {
            _product = product;
            _action = action;
            _amount = amount;
        }

        public void Execute()
        {
            if (_action == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
            }
            else if (_action == PriceAction.Decrease)
            {
                _product.DecreasePrice(_amount);
            }
            else
            {
                Console.WriteLine("Unknown action.");
            }
        }
    }
}
