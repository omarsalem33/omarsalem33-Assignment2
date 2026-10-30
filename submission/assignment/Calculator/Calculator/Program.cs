public class HelloWorld
{
    public static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Operator (+,/,*,-)");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            Console.WriteLine("Do you want to make another operation? Press 1 for Yes, 2 for No:");
            int valid = Convert.ToInt32(Console.ReadLine());
            flag = (valid == 1); 
        }
    }
}