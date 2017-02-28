using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> area = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombAndRange = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bomb = bombAndRange[0];
            List<int> bombIndex = new List<int>();
            int range = bombAndRange[1];

            for (int i = 0; i < area.Count; i++)
            {
                if (area[i] == bomb)
                {
                    bombIndex.Add(i);
                }
            }

            if (bombIndex.Count > 1)
            {
                for (int r = bombIndex.Count - 1; r > 0; r--)
                {
                    int lastBombIndex = bombIndex[r];
                    int curentBombIndex = bombIndex[r - 1];
                    if (lastBombIndex - curentBombIndex <= range)
                    {
                        bombIndex.Remove(bombIndex[r]);
                    }
                    lastBombIndex = curentBombIndex;
                }
            }
            for (int bombs = 0; bombs < bombIndex.Count; bombs++)
            {
                for (int bombRangeLeft = bombIndex[bombs] - range; bombRangeLeft <= bombIndex[bombs]; bombRangeLeft++)
                {
                    if (bombRangeLeft >= 0)
                    {
 
                        area[bombRangeLeft] = 0;
                    }

                }
            }

            for (int bombs = 0; bombs < bombIndex.Count; bombs++)
            {
                for (int bombRangeRight = bombIndex[bombs];
                    bombRangeRight <= bombIndex[bombs] + range; bombRangeRight++)
                {
                    if (bombRangeRight < area.Count)
                    {
                        area[bombRangeRight] = 0;
                    }
 
                }
            }

           // for (int i = 0; i < bombIndex.Count; i++)
            //{
                //area[bombIndex[i]] = 0;
            //}

            int result = 0;
            for (int i = 0; i < area.Count; i++)
            {
                result += area[i];
            }

            Console.WriteLine(result);

        }
    }
}
