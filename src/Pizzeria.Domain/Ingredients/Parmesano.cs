namespace Pizzeria.Domain.Ingredients
{
    public class Parmesano : Ingredient
    {
        public override string Name => "Paresano";

        public override string ImagePath => @"\Resources\Parmesano.jpg";

        public override IngredientType Type => IngredientType.Dairy;
    }
}
