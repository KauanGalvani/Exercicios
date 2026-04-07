namespace Exercicios.ConsoleApp
{
    class Calculo
    {
        public double litros;
        public double km;
        public double consumo;
        public void ConsumoKmPorL()
        {
            Console.Write("Digite quantos litros de gasolina seu carro possui no começo da viajem: ");
            litros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite a kilometragem final da viajem: ");
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            consumo = litros / km;
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

            Console.WriteLine($"Sua viagem foi de {calcular.km}Km e seu consumo de combustivel foi de {calcular.consumo}L");
        }
    }
}