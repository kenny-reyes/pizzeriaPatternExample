namespace Pizzeria.Domain
{
    public class Order
    {
        private string _name;
        private string _phone;
        private Pizza _pizza;

        public string Name { get => _name; set => _name = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public Pizza Pizza { get => _pizza; set => _pizza = value; }
    }
}
