namespace ATV8_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //EXEMPLO DE MATRIZ DADO EM AULA 

            int[,] tab = new int[11, 11];

            for (int i = 0; i <= 10; i++) //percorre linhas
            {
                for (int j = 0; j <= 10; j++) //percorre coluna
                {
                    tab[i, j] = i * j;
                }
            }
            for (int i = 0; i <= 10; i++) //percorre linhas
            {
                for (int j = 0; j <= 10; j++) //percorre coluna
                {
                    Console.Write(" {0:00}  ", tab[i, j]);
                }
                Console.WriteLine();
            }
            */

            // jogo da memória

            int[,] jogo = new int[4, 4];
            int[,] tela = new int[4, 4];

            //para criar números aleatórios 
            Random gerador = new Random();

            for (int i = 1; i < 8; i++) //atribui os pares de números ás posições
            {
                //Escolhe a posição do primeiro numero do par
                int lin, col;
                do
                {
                    lin = gerador.Next(0, 4);
                    col = gerador.Next(0, 4);

                } while (jogo[lin, col] != 0);
                jogo[lin, col] = i;

                //Escolhe a posição do primeiro numero do par
                do
                {
                    lin = gerador.Next(0, 4);
                    col = gerador.Next(0, 4);

                } while (jogo[lin, col] != 0);
                jogo[lin, col] = i;
            }

            int acertos = 0;
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" {0}  ", tela[i, j]);
                    }
                    Console.WriteLine();
                }
                //pedir as posiç~es do primeiro número 
                Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                int lin1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                int col1 = int.Parse(Console.ReadLine());

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == lin1 - 1 && j == col1 - 1)
                            Console.Write("{0} ", jogo[i, j]);
                        else
                            Console.Write("{0} ", tela[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //pedir as posições do segundo número 
                Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                int lin2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                int col2 = int.Parse(Console.ReadLine());

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == lin2 - 1 && j == col2 - 1)
                            Console.Write("{0} ", jogo[i, j]);
                        else
                            Console.Write("{0} ", tela[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //em caso de acerto a matriz tela permanece como está
                //em caso de erro, precisamos voltar as posições para zero 
                if (jogo[lin1, col1] != jogo[lin2, col2])
                {
                    tela[lin1, col1] = 0;
                    tela[lin2, col2] = 0;

                }
                else
                {
                    acertos++;
                }






            } while (acertos < 8);
            
        }
           
    }
}
