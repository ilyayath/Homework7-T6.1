namespace FactoryMethod
{
    public abstract class Beverage
    {
        public abstract void Serve();
    }

    public class Coffee : Beverage
    {
        public override void Serve()
        {
            Console.WriteLine("Serving a cup of coffee");
        }
    }

    public class Tea : Beverage
    {
        public override void Serve()
        {
            Console.WriteLine("Serving a cup of tea");
        }
    }

    public abstract class BeverageFactory
    {
        public abstract Beverage CreateBeverage();
    }

    public class CoffeeFactory : BeverageFactory
    {
        public override Beverage CreateBeverage()
        {
            return new Coffee();
        }
    }

    public class TeaFactory : BeverageFactory
    {
        public override Beverage CreateBeverage()
        {
            return new Tea();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory coffeeFactory = new CoffeeFactory();
            Beverage coffee = coffeeFactory.CreateBeverage();
            coffee.Serve();

            BeverageFactory teaFactory = new TeaFactory();
            Beverage tea = teaFactory.CreateBeverage();
            tea.Serve();

            Console.ReadKey();
        }
    }
}
