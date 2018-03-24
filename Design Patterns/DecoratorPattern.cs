using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class DecoratorPattern
    {
        public static void TestDecoratorPattern()
        {
            ICar car = new SportsCar(new BasicCar());
            car.Assemble();
        }
    }

    interface ICar
    {
        void Assemble();
    }

    class BasicCar : ICar
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling basic car");
        }
    }

    class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual void Assemble()
        {
            this.car.Assemble();
        }
    }

    class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car)
        {

        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding sports car features");
        }
    }
}
