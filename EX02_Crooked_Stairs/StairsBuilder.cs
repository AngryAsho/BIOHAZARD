using System;


namespace EX02_Crooked_Stairs
{
    class StairsBuilder
    {
        static void Main()
        {
            decimal BH1 = decimal.Parse(Console.ReadLine());
            decimal BH2 = decimal.Parse(Console.ReadLine());
            decimal BH3 = decimal.Parse(Console.ReadLine());
            decimal L = decimal.Parse(Console.ReadLine());

            decimal bricksPerLine = 3;
            decimal nextHight = 0;

            Console.WriteLine(BH1);
            Console.WriteLine(BH2 + " " + BH3);

            for (decimal i = 0; i < L - 2; i++)
            {
                for (decimal j = 0; j < bricksPerLine; j++)
                {
                    nextHight = (BH1 + BH2 + BH3);
                    Console.Write(nextHight);
                    BH1 = BH2;
                    BH2 = BH3;
                    BH3 = nextHight;
                    if (j < bricksPerLine - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                bricksPerLine++;         
            }
        }
    }
}
