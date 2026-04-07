namespace Ecercicios.ConsoleApp
{
    class Calculadora
    {
        public double altura;
        public double raio;
        public double Valorvolume;
        public void Volume()
        {
            Console.Write("Qual a altura do cilindro?: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual o raio do cilindro?: ");
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
            Console.WriteLine("calculo do volume de um cilindro");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            Calculo.Volume();

            Console.WriteLine($"o valume do cilindro é {Calculo.Valorvolume:F1}");
        }
    }
}