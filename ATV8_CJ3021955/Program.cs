namespace ATV8_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)

         //EXEMPLO DE MATRIZ DADO EM AULA 
        {
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
                    Console.Write(tab[i, j] );
                }
            }
        }
    }
}
