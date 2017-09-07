using System;
using System.Collections.ObjectModel;
using Pizzeria.Domain.Base;

namespace Pizzeria.Domain
{
    public class IngredientList : ObservableCollection<Ingredient>, ICloneable
    {
        /// <summary>
        /// PROTOTYPE pattern
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            IngredientList newList = new IngredientList();
            foreach (var item in Items)
            {
                newList.Add(item);
            }
            return newList;
        }
    }
}
