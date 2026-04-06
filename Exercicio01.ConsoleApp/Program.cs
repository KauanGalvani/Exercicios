namespace Ecercicio01.ConsoleApp
{
    class Calculadora
    {
        public decimal comprimento;
        public decimal largura;
        public decimal altura;
        public decimal v;

        public void Volume()
        {
            Console.Write("Qual o comprimento da caixa?:");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Qual o valor da largura da caixa?:");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Qual o valor da altura?:");
            altura = Convert.ToDecimal(Console.ReadLine());

            v = comprimento * largura * altura;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Calculadora calcular = new Calculadora();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Vamos calcular o volume de uma caixa retangular");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            calcular.Volume();

            Console.WriteLine($"o volume da caixa é {calcular.v}");
        }
    }
}