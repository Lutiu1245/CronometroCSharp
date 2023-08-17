namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("S - Segundos -> 10s = 10 segundos");
            Console.WriteLine("M - Minutos -> 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int contador = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = 1;
            
            Console.WriteLine(data);
            Console.WriteLine(type);
            Console.WriteLine(contador);

            if (type == 0)
                System.Environment.Exit(0);
            if (type == 's')
                multiplicador = 1;
            if (type == 'm')
                multiplicador = 60;
            Start(contador * multiplicador);
        }
        static void Start(int contador)
        {
            int contadorAtual = 0;
            while (contadorAtual != contador)
            {
                Console.Clear();
                contadorAtual++;
                Console.WriteLine(contadorAtual);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fim!");
            Menu();
        }
    }
}