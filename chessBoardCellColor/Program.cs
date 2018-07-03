using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessBoardCellColor
{
    class Program
    {
        public static bool chessBoardCellColor(string cell1, string cell2)
        {
            List<string> black = new List<string>();
            List<string> white = new List<string>();

            for (int i = 65; i <= 72; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        black.Add(((char)i + j.ToString()).ToString());
                    }
                    else if (i % 2 == 0 && j % 2 == 0)
                    {
                        black.Add(((char)i + j.ToString()).ToString());
                    }
                    else
                    {
                        white.Add(((char)i + j.ToString()).ToString());
                    }
                }
            }

            bool result = black.Contains(cell1) ? black.Contains(cell2) : white.Contains(cell1) ? white.Contains(cell2) : false;

            return result;
        }

        static void Main(string[] args)
        {
            string c1 = "A1";
            string c2 = "A2";
            Console.WriteLine(chessBoardCellColor(c1, c2));
            Console.ReadKey();
        }
    }
}
