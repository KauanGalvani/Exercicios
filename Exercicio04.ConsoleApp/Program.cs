namespace Exercicios.ConsoleApp
{
    class Calculo
    {
        public double litros;
        public double kmInicial;
        public double kmFinal;
        public double consumo;
        public double distancia;
        public void ConsumoKmPorL()
        {
            Console.Write("Digite quantos litros de gasolina seu carro possui no começo da viajem: ");
            litros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite a kilometragem inicial da viajem: ");
            kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite a kilometragem final da viajem: ");
            kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            distancia = kmFinal - kmInicial;

            consumo = litros / distancia;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calcular = new Calculo();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Consumo de combustivel");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            calcular.ConsumoKmPorL();

            Console.WriteLine($"Seu consumo de combustivel foi de {calcular.consumo}L você iniciou o percurso com {calcular.kmInicial}Km e terminou com {calcular.kmFinal}Km e a distancia total percorrida durante a viagem foi de {calcular.distancia}Km");
        }
    }
}