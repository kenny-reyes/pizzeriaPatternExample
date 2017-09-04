using System;
using System.Collections.Generic;

namespace Pizzeria.Domain
{
    public class Pizza : ICloneable
    {
        private string _name;
        private string _imagePath;
        private List<Ingredient> _ingredientList;

        public Pizza(string name, string imagePath, List<Ingredient> ingredientList)
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
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public List<Ingredient> IngredientList
        {
            get { return _ingredientList; }
            set { _ingredientList = value; }
        }

        /// <summary>
        /// Pattern PROTOTYPE
        /// </summary>
        public object Clone()
        {
            return new Pizza(_name, _imagePath, _ingredientList);
        }
    }
}
