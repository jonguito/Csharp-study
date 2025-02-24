namespace calculadora
{

    public class Program
    {

        public static void Main()
        {
            
            

            Console.WriteLine("CALCULADORA SIMPLES");
            Console.WriteLine("digite o primeiro número: ");
            int number1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            int module  = number1 % number2;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " + subtraction);
            Console.WriteLine("O valor da multiplicação é: " + multiplication);
            Console.WriteLine("O valor da divisão é: " + division);
            Console.WriteLine("O valor do resto da divisão é: " + module);



        }

    }
 }
