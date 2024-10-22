using TratamentoErros.Entities;
using TratamentoErros.Entities.Exceptions;

namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Qual sua conta?:");
                int conta = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual seu nome?");
                string holder = Console.ReadLine();
                Console.WriteLine("Qual seu saldo inicial?");
                double saldo = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual seu limite de saque?");
                double limiteSaque = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Account account = new Account(conta, holder, saldo, limiteSaque);

                Console.WriteLine("Quanto deseja sacar?");
                double valorSaque = double.Parse(Console.ReadLine());


                account.Withdraw(valorSaque);

                Console.WriteLine(account);

            } catch ( DomainException e) {
                Console.WriteLine(e.Message);
            }

        }
        
    }
}