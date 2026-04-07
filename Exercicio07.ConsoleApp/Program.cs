namespace Exercicios.ConsoleApp
{
    class SalarioVendas
    {
        public double salarioBase;
        public double totalVendas;
        public double percentual;
        public double comissao;
        public double salarioTotal;
        public void SalariosEcomissao()

        {
            Console.Write("Digite o salário base: ");
            salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas: ");
            totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de comissão: ");
            percentual = Convert.ToDouble(Console.ReadLine());

            comissao = totalVendas * (percentual / 100);

            salarioTotal = salarioBase + comissao;

            Console.WriteLine($"Comissão: {comissao}");
            Console.WriteLine($"Salário total: {salarioTotal}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalarioVendas funcionarios = new SalarioVendas();

            Console.WriteLine("--------------------------------------"); 
            Console.WriteLine("Salario e comissão funcionarios"); 
            Console.WriteLine("--------------------------------------"); 
            Console.WriteLine(""); 

            funcionarios.SalariosEcomissao();
        }
    }
}