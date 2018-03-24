using System.Collections.Generic;

namespace Design_Patterns
{
    public class BuilderPattern
    {
        public static void TestBuilderPattern()
        {
            MealDirector director = new MealDirector();

            string order = "pizza";
            MealBuilder mealBuilder = null;
            if (order == "pizza")
            {
                mealBuilder = new PizzaBuilder();
            }
            else if (order == "burger")
            {
                mealBuilder = new BurgerBuilder();
            }

            Meal meal = director.MealBuilder(mealBuilder);
        }
    }

    public class MealDirector
    {
        public Meal MealBuilder(MealBuilder builder)
        {
            builder.PrepareMeal();
            return builder.GetMeal();
        }
    }

    public class Meal
    {
        public List<string> ItemList { get; set; }
        public void AddItem(string item)
        {
            this.ItemList.Add(item);
        }
    }

    public abstract class MealBuilder
    {
        protected Meal _meal;
        public abstract void PrepareMeal();
        public abstract Meal GetMeal();
    }

    public class PizzaBuilder : MealBuilder
    {
        public PizzaBuilder()
        {
            this._meal = new Meal();
        }
        public override void PrepareMeal()
        {
            _meal.AddItem("Pizza");
            _meal.AddItem("Coke");
        }

        public override Meal GetMeal()
        {
            return _meal;
        }
    }

    public class BurgerBuilder : MealBuilder
    {
        public BurgerBuilder()
        {
            this._meal = new Meal();
        }
        public override void PrepareMeal()
        {
            _meal.AddItem("Burger");
            _meal.AddItem("Coke");
        }

        public override Meal GetMeal()
        {
            return _meal;
        }
    }
}
