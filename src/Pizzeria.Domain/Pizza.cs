using System;

namespace Pizzeria.Domain
{
    public class Pizza : ICloneable
    {
        private string _name;
        private string _imagePath;
        private IngredientList _ingredientList;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string ImagePath
        {
            get => AppDomain.CurrentDomain.BaseDirectory + _imagePath;
            set => _imagePath = value;
        }

        public IngredientList Ingredients
        {
            get => _ingredientList;
            set => _ingredientList = value;
        }

        /// <summary>
        /// Pattern PROTOTYPE
        /// </summary>
        public object Clone()
        {
            return new Pizza { Name = _name, ImagePath = _imagePath, Ingredients = _ingredientList.Clone() as IngredientList };
        }
    }
}
