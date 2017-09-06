namespace Pizzeria.Domain.Ingredients
{
    public class Corn : Ingredient
    {
        public Corn()
        {
            Name = "Maiz";
            ImagePath = @"Resources\Corn.bmp";
            Type = IngredientType.Vegetal;
        }
    }
}
