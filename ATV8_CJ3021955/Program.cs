   for (int i = 0;i < 4 ;i++) 
   {
        for (int j = 0;j < 4; j++)
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
    if ()

}
