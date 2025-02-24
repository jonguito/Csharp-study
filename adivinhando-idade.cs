class Program
{
    static void Main()
    {
        // Pergunta a idade do usuário.
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        // Verifica a faixa etária.
        if (idade >= 0 && idade <= 12)
        {
        // saída caso usuário tenha idade maior ou igual a o e idade menor ou igual a 12.
            Console.WriteLine("Você é uma criança.");
        }
        
        else if (idade >= 13 && idade <= 17)
        {
          // saída caso usuário tenha idade maior ou igual a 13 e idade menor ou igual a 17.
            Console.WriteLine("Você é um adolescente.");
        }
       
        else if (idade >= 18 && idade <= 64)
        {
          // saída caso usuário tenha idade maior ou igual a 18 e idade menor ou igual a 64.
            Console.WriteLine("Você é um adulto.");
        }
        
        else if (idade >= 65)
        {
          // saída caso usuário tenha idade maior ou igual a 65 anos.
            Console.WriteLine("Você é um idoso.");
        }
      
        else
        {
          // saída caso usuário digite uma idade inválida.
            Console.WriteLine("Idade inválida.");
        }
    }
}
