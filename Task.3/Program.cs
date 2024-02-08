


using Task._3;

while (true)
{
    System.Console.WriteLine("-----Canculate-----");
    System.Console.WriteLine("Enter number");
    System.Console.Write("First num : ");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Second num : ");
    int b = Convert.ToInt32(Console.ReadLine());
    while (true)
    {
        System.Console.WriteLine("----Sum, Subtract, Multiply, Divide, exit----");
        System.Console.Write("Enter math action : ");
        string action = Console.ReadLine();
        action = action.ToLower();
        if (action == "sum")
        {
            System.Console.WriteLine(Algebra.Add(a, b));
        }
        if (action == "subtract")
        {
            System.Console.WriteLine(Algebra.Subtract(a, b));
        }
        if (action == "multiply")
        {
            System.Console.WriteLine(Algebra.Multiply(a, b));
        }
        if (action == "divide")
        {
            System.Console.WriteLine(Algebra.Divide(a, b));
        }
        if (action== "exit") break;
    }




}