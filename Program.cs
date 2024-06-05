using System.Text;

namespace Assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerBed = { 1, 0, 0, 0, 1 };
            int n = 2;
            Console.WriteLine(canPlantFlowers(flowerBed, n));
        }

        static bool canPlantFlowers(int[] flowers, int n)
        {
            int counter = 0;

            bool leftPlotEmpty = false;
            bool rightPlotEmpty = false;

            
            for (int i = 0; i < flowers.Length; i++)
            {
                if (i == 0 || flowers[i - 1] == 0)
                {
                    leftPlotEmpty = true;
                }
                else
                {
                    leftPlotEmpty = false;
                }

                if (i == flowers.Length - 1 || flowers[i + 1] == 0)
                {
                    rightPlotEmpty = true;
                }
                else
                {
                    rightPlotEmpty= false;
                }

                if (leftPlotEmpty && rightPlotEmpty && flowers[i] != 1)
                {
                    flowers[i] = 1;

                    counter++;


                    if (counter == n)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
