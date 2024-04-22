using System;

class Program
{
    static void Main(string[] args)
    {
        string nomeUsuario;
        int idadeUsuario;
        double alturaUsuario, pesoUsuario, imcUsuario;

        do
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo(a) ao programa de cálculo do IMC, por favor digite seu nome : ");
            nomeUsuario = Console.ReadLine()!;
            Console.WriteLine($"Muito bem {nomeUsuario}, agora precisamos de algumas informações : ");

            Console.WriteLine("Digite sua idade:");
            idadeUsuario = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine("Certo, agora, digite sua altura em metros( Use vírgula para dividir as casas.(EX : 1,80)): ");
            alturaUsuario = Convert.ToDouble(Console.ReadLine()!);

            Console.WriteLine("E para finalizar, digite o peso em kg:");
            pesoUsuario = Convert.ToDouble(Console.ReadLine()!);

            imcUsuario = pesoUsuario / (alturaUsuario * alturaUsuario);

            string categoriaIMC, faixaEtaria;

            if (imcUsuario < 18.5)
            {
                categoriaIMC = "Você está abaixo do peso ideal.";
            }
            else if (imcUsuario < 25)
            {
                categoriaIMC = "Peso ideal para você .";
            }
            else if (imcUsuario < 30)
            {
                categoriaIMC = "Um pouco acima do ideal .";
            }
            else
            {
                categoriaIMC = "Nivel de obesidade atingido .";
            }

            if (idadeUsuario < 12)
            {
                faixaEtaria = "Criança";
            }
            else if (idadeUsuario < 20)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idadeUsuario < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Relatório para {nomeUsuario}:");
            Console.WriteLine($"Idade: {idadeUsuario} anos");
            Console.WriteLine($"IMC: {imcUsuario:F2} ({categoriaIMC})");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

            Console.WriteLine(" ");
            Console.WriteLine("Deseja gerar um novo teste ? (s/n)");
        } while (Console.ReadLine()!.ToLower() == "s");
    }
}