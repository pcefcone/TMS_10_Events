using TMS_10_Events;

internal class Program
{
    private static void Main(string[] args)
    {
        Operations operations = new Operations();
        operations.Addition += OperationAddition;
        operations.Division += OperationDivision;
        operations.Multiplication += OperationMultiplication;
        operations.Subtraction += OperationSubstraction;
        operations.Modulus += OperationModulus;
        operations.Error += OperationError;
        double variable1;
        double variable2;
        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Put first number: ");
            bool trueVariable1 = double.TryParse(Console.ReadLine(), out variable1);

            Console.WriteLine("Put second number: ");
            bool trueVariable2 = double.TryParse(Console.ReadLine(), out variable2);

            if (trueVariable1 && trueVariable1)
            {
                Console.WriteLine("Choose operation:" +
                    "+ -> to addition," +
                    "- -> to division," +
                    "* -> to multiplication," +
                    "/ -> to substraction," +
                    "% -> to modulus," +
                    "! -> to exit program" +
                    "another symbol, letter or number -> to error=)");
                string operation = Console.ReadLine();

                operations.Calculation(variable1, operation, variable2);
                
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();
            Console.Clear();
        }

    }
    private static void OperationAddition(object obj)
    {
        var operations = (Operations)obj;
        operations.Add();
        Console.WriteLine($"Addition result is: {operations.result}");
    }
    public static void OperationSubstraction(object obj)
    {
        var operations = (Operations)obj;
        operations.Sub();
        Console.WriteLine($"Substraction result is: {operations.result}");
    }
    public static void OperationDivision(object obj)
    {
        var operations = (Operations)obj;
        operations.Div();
        Console.WriteLine($"Division result is: {operations.result}");
    }
    public static void OperationMultiplication(object obj)
    {
        var operations = (Operations)obj;
        operations.Mult();
        Console.WriteLine($"Multiplication result is: {operations.result}");
    }
    public static void OperationModulus(object obj)
    {
        var operations = (Operations)obj;
        operations.Mod();
        Console.WriteLine($"Modulus result is: {operations.result}");
    }
    public static void OperationError()
    {      
        Console.WriteLine("Error!");
    }
}