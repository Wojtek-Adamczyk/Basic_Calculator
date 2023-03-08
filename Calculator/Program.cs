namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                double result = 0;

                Console.Write("Enter first number (int/double): ");
                double nr1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator: ");
                string op = Console.ReadLine();

                Console.Write("Enter second number (int/double): ");
                double nr2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = nr1 + nr2;
                        break;

                    case "-":
                        result = nr1 - nr2;
                        break;

                    case "*":
                        result = nr1 * nr2;
                        break;

                    case ":":
                        result = nr1 / nr2;
                        break;

                    case "/":
                        result = nr1 / nr2;
                        break;

                    case "^":
                        {
                            if (nr2 < 0)
                            {
                                double resultPow = -1;
                                for (int i = 0; i < nr2; i++)
                                {
                                    resultPow *= nr1;
                                }
                                result = resultPow;
                            }
                            else
                            {
                                double resultPow = 1;
                                for (int i = 0; i < nr2; i++)
                                {
                                    resultPow *= nr1;
                                }
                                result = resultPow;
                            }
                        }
                        break;

                    case "sqrt":
                        {
                            Console.WriteLine($"Which number would you like to square root to the 2nd? {nr1} or {nr2}");

                            double sqrtNr = Convert.ToDouble(Console.ReadLine());
                            double root = 1;
                            int i = 1;

                            if (sqrtNr == nr1)
                            {
                                while (i <= nr2 + 1)
                                {
                                    i = i + 1;
                                    root = (nr1 / root + root) / 2;
                                }
                                result = root;
                            }
                            else if (sqrtNr == nr2)
                            {         
                                while (i <= nr2 + 1)
                                {
                                    i = i + 1;
                                    root = (nr2 / root + root) / 2;
                                }
                                result = root;
                            }
                            else Console.WriteLine("Unknown number");                           

                            break;
                        }

                    default:
                        Console.WriteLine("Unknown operator, equation nulled.");
                        break;
                }
          
                Console.WriteLine($"= " + result);
            }
            catch (FormatException ex) {Console.WriteLine(ex.Message);}
            catch (DivideByZeroException ex) {Console.WriteLine(ex.Message);}
        }
    }
}