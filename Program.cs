namespace JoKenPo
{
    class Jogo
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int jogadaPC = random.Next(1, 3);


            Console.WriteLine("O computador escolheu a jogada dele, qual será a sua?\n1 - Pedra\n2 - Papel\n3 - Tesoura");
            string? jogadaPlayerString = Console.ReadLine();

            int.TryParse(jogadaPlayerString, out int jogadaPlayer);

            Console.WriteLine($"PC escolheu {jogadaPC}\n");


            if (jogadaPlayer == jogadaPC)
            {
                Console.WriteLine("Empate!");
                return;
            }

            if (jogadaPC == 1)
            {
                if (jogadaPlayer == 2)
                {
                    Console.WriteLine("Você venceu!");
                }

                else if(jogadaPlayer == 3)
                {
                    Console.WriteLine("O computador venceu!");
                }
            }
            else if(jogadaPC == 2)
            {
                if (jogadaPlayer == 3)
                {
                    Console.WriteLine("Você venceu!");
                }
                
                else if (jogadaPlayer == 1)
                {
                    Console.WriteLine("O computador venceu!");
                }
            }
            else if(jogadaPC == 3)
            {
                if (jogadaPlayer == 1)
                {
                    Console.WriteLine("Você venceu!");
                }

                else if (jogadaPlayer == 2)
                {
                    Console.WriteLine("O computador venceu!");
                }
            }

        }
    }
}