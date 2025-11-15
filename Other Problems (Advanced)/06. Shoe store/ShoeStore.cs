using System.Collections.Generic;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; }

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public int Count => Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if(Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }

            return "No more space in the storage room.";
        }

        public int RemoveShoes(string material)
        {
            return Shoes.RemoveAll(s => s.Material == material);
        }

        public List<Shoe> GetShoesByType(string type)
        {
            return Shoes.FindAll(s => s.Type == type.ToLower());
        }

        public Shoe GetShoeBySize(double size)
        {
            return Shoes.Find(s => s.Size == size);
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();

            var filteredShoes = Shoes.FindAll(s => s.Size == size && s.Type == type);

            if(filteredShoes.Count == 0)
            {
                sb.AppendLine("No matches found!");
            }
            else
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");

                foreach (var shoe in filteredShoes)
                {
                    sb.AppendLine(shoe.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
