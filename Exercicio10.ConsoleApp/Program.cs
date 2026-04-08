namespace Exercicios.ConsoleApp
{

    class NotasEscola
    {
        public double nota1;
        public double nota2;
        public double peso1;
        public double peso2;

        public double Media;
        public void MediaPonderada()
        {
            Console.Write("Digite a nota da primeira prova: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite o peso da primeira prova: ");
            peso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite a nota da segunda prova: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digete o peso da segunda prova:");
            peso2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada do aluno é {Media:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NotasEscola NotaProvas = new NotasEscola();

            Console.WriteLine("------------------------------");
            Console.WriteLine("Média ponderada do aluno");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            NotaProvas.MediaPonderada();
        }
    }
}