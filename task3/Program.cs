while (true)
{
    System.Console.Write("The first number is: ");
    double n1 = Convert.ToDouble(Console.ReadLine());

    System.Console.Write("The operation is: ");
    string? operation = Console.ReadLine();

    System.Console.Write("The second number is: ");
    double n2 = Convert.ToDouble(Console.ReadLine());

    var calc = new Calculator(n1, n2);

    switch(operation)
    {
        case "+":
            System.Console.WriteLine(calc.Sum());
            break;
        case "-":
            System.Console.WriteLine(calc.Subtract());
            break;
        case "*":
            System.Console.WriteLine(calc.Multiplication());
            break;
        case "/":
            System.Console.WriteLine(calc.Division());
            break;
        default:
            System.Console.WriteLine("Ваш оператор не распазнован!");
            break;
    }
    calc = null;
}




public class Calculator
{
    public double num1 { get; set; }
    public double num2 { get; set; }
    public Calculator(double num1, double num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public string Sum()
    {
        return $"{num1} + {num2} = {num1+num2}";
    }
    public string Subtract()
    {
        return $"{num1} - {num2} = {num1-num2}";
    }
    public string Multiplication()
    {
        return $"{num1} * {num2} = {num1*num2}";
    }
    public string Division()
    {
        return $"{num1} / {num2} = {num1/num2}";
    }
}