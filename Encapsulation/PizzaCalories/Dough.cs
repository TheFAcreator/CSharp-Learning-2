namespace PizzaCalories
{
    public class Dough
    {
		private const int _caloriesPerGram = 2;
		
        private string flourType;
		public string FlourType
		{
			get { return flourType; }
			private set 
			{
				string valueLower = value.ToLower();
                if (valueLower != "white" && valueLower != "wholegrain")
				{
					throw new Exception("Invalid type of dough.");
				}

				flourType = value;
            }
		}

		private string bakingTechnique;
		public string BakingTechnique
		{
			get { return bakingTechnique; }
			private set
			{
				string valueLower = value.ToLower();
                if (valueLower != "crispy" && valueLower != "chewy" && valueLower != "homemade")
				{
					throw new Exception("Invalid type of dough.");
                }

				bakingTechnique = value;
            }
        }

		private int grams;
		public int Grams
		{
			get { return grams; }
			private set
			{
				if(value < 1 || value > 200)
				{
					throw new Exception("Dough weight should be in the range [1..200].");
                }

				grams = value;
            }
        }
		
		public double CaloriesPerGram
		{
			get
			{
				return _caloriesPerGram * GetTypeModifier(FlourType) * GetBakingTechniqueModifier(BakingTechnique);
            }
		}

		private static double GetTypeModifier(string type)
		{
			switch (type.ToLower())
			{
				case "white":
					return 1.5;
				case "wholegrain":
					return 1.0;
            }
			return 0;
        }

		private static double GetBakingTechniqueModifier(string technique)
		{
			switch(technique.ToLower())
			{
				case "crispy":
					return 0.9;
				case "chewy":
					return 1.1;
				case "homemade":
					return 1.0;
            }
			return 0;
        }

        public Dough(string type, string bakingTechnique, int grams)
		{
			FlourType = type;
			BakingTechnique = bakingTechnique;
			Grams = grams;
        }
    }
}