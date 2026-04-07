namespace Ecercicios.ConsoleApp
{
    class Calculadora
    {
        public double altura;
        public double raio;
        public double Valorvolume;
        public void Volume()
        {
            Console.Write("Qual a altura da lata?: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual o raio da lata?: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Valorvolume = Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calculo = new Calculadora();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Calculo do volume de uma lata de óleo");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            Calculo.Volume();

            Console.WriteLine($"O volume da lata de óleo é {Calculo.Valorvolume:F1}");
        }
    }
}