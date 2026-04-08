namespace Exercicios.ConsoleApp
{
    class CalculoAluno
    {
        public double n1;
        public double n2;
        public double n3;
        public double mediaHaromnica;

        public void MediaHarmonica()
        {
            Console.Write("Digite a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double mediaHarmonica = 3 / ((1 / n1) + (1 / n2) + (1 / n3));

                Console.WriteLine($"Média harmônica: {mediaHarmonica:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculoAluno alunoNota = new CalculoAluno();

            Console.WriteLine("----------------------------");
            Console.WriteLine("Média harmonica Alunos");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            alunoNota.MediaHarmonica();
        }
    }
}