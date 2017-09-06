using System;

namespace Pizzeria.Domain
{
    public class Pizza : ICloneable
    {
        private string _name;
        private string _imagePath;
        private IngredientList _ingredientList;

        public Pizza(string name, string imagePath, IngredientList ingredientList)
        {
            _name = name;
            _imagePath = imagePath;
            _ingredientList = ingredientList;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ImagePath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + _imagePath; }
            set { _imagePath = value; }
        }

        public IngredientList IngredientList
        {
            get { return _ingredientList; }
            set { _ingredientList = value; }
        }

        /// <summary>
        /// Pattern PROTOTYPE
        /// </summary>
        public object Clone()
        {
            return new Pizza(_name, _imagePath, _ingredientList.Clone() as IngredientList);
        }
    }
}
