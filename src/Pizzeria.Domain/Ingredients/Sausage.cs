namespace Pizzeria.Domain.Ingredients
{
    public class Sausage : Ingredient
    {
        public override string Name => "Salchicha";

        public override string ImagePath => @"\Resources\Sausage.jpg";

        public override IngredientType Type => IngredientType.Meat;
    }
}
