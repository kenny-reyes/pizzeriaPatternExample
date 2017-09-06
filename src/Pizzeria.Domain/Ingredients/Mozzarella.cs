namespace Pizzeria.Domain.Ingredients
{
    public class Mozzarella : Ingredient
    {
        public override string Name => "Mozzarella";

        public override string ImagePath => @"\Resources\Mozzarella.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
