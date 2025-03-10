




namespace par_ou_inpar
 {
        public class Program
        {
            public static void Main() 
            {
                Console.WriteLine("----Verificador de números pares ou ímpares.----");
                Console.WriteLine("digite um número: ");

                int number = Convert.ToInt32(Console.ReadLine());
                int result = number % 2;

                if (result == 0)
                { Console.WriteLine("o número digitado é PAR.");
                }

                else
                {
                    Console.WriteLine("o número digitado é INPAR.");
                }
               

            }

        }
         
 }
        
    


        

        
        
        
        
        

 
