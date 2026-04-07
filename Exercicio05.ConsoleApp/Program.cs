namespace Exercicios.ConsoleApp
{
    class Program
    {
        class Calculadora
        {
            public double volume;
            public double raio;

            public void VolumeEsfera()
            {
                Console.Write("Digite o valor do raio da esfera: ");
                raio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
                Console.WriteLine("");

                Console.WriteLine($"O volume da esfera é de {volume:F2}");
            }
        }
        static void Main(string[] args)
        {
            Calculadora calcular = new Calculadora();

            Console.WriteLine("---------------------------");
            Console.WriteLine("Volume de uma esfera");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            calcular.VolumeEsfera();
        }
    }
}