namespace Design_Patterns
{
    class StrategyPattern
    {
        
        public static void TestStrategyPattern()
        {
            MathOperation mathOperation = new MathOperation(new AddOperationStrategy());
            mathOperation.SetNumber(1,2);
            mathOperation.GetResult();
        }
    }

    public class MathOperation
    {
        IOperationStrategy operationStrategy;
        int num1, num2;
        public MathOperation(IOperationStrategy strategy)
        {
            this.operationStrategy = strategy;
        }

        public void SetNumber(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int GetResult()
        {
            return operationStrategy.Operation(num1, num2);
        }
    }

    public interface IOperationStrategy
    {
        int Operation(int num1, int num2);
    }

    public class AddOperationStrategy : IOperationStrategy
    {
        public int Operation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class SubstractOperationStrategy : IOperationStrategy
    {
        public int Operation(int num1, int num2)
        {
            return num1 - num2;
        }
    }

}
