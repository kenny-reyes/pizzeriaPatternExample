namespace Pizzeria.Domain
{
    public abstract class Ingredient
    {
        private string _name;
        private string _imagePath;
        private IngredientType _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public IngredientType Type { get => _type; set => _type = value; }
    }
}
