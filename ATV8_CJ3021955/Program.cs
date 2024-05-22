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

            //para criar números aleatórios 
            Random gerador = new Random();

           for(int i = 0; i < 8; i++) //atribui os pares de números ás posições
           {
                //Escolhe a posição do primeiro numero do par
                int lin, col;
                do
                {
                    lin = gerador.Next(0, 4);
                    col = gerador.Next(0, 4);

                } while (jogo[lin, col] != 0);
                jogo[lin, col] = i + 1;

                //Escolhe a posição do primeiro numero do par
                do
                {
                    lin = gerador.Next(0, 4);
                    col = gerador.Next(0, 4);

                } while (jogo[lin, col] != 0);
                jogo[lin, col] = i + 1;
            }

           for (int i = 0;i < 4 ;i++) 
           {
                for (int j = 0;j < 4; j++)
                {
                    Console.Write(" {0}  ", jogo[i, j]);
                }
                Console.WriteLine();
            }
            

        }
    }
}
