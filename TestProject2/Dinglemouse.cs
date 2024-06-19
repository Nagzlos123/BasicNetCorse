using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class Dinglemouse
    {
        public struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }
        }
      
        public static bool AllAlone(char[][] house)
        {
            Point potus = default;

            for (int i = 0; i < house.GetLength(0); i++)
            {
                for (int j = 0; j < house[i].Length; j++)
                {
                    if (house[i][j] == 'X')
                    {
                        potus = new Point(i, j);
                    }
                }
            }

            var scannedPionts = new List<Point>();
            var isNotAlone = Scan(potus, house, scannedPionts);
            return !isNotAlone;
        }

        public static bool Scan(Point point, char[][] house,List<Point> scannedPionts)
        {
            if(scannedPionts.Contains(point))
            {
                return false;
            }
            scannedPionts.Add(point);

            if (house[point.X][point.Y] == 'o')
            {
                return true;
            }

            if (house[point.X][point.Y] == '#')
            {
                return false;
            }

            var pointUp = new Point(point.X, point.Y - 1);
            var pointDown = new Point(point.X, point.Y + 1);
            var pointToLeft = new Point(point.X - 1, point.Y);
            var pointToRight = new Point(point.X + 1, point.Y);

           

            return Scan(pointUp, house, scannedPionts) ||
                 Scan(pointDown, house, scannedPionts) ||
                Scan(pointToLeft, house, scannedPionts) ||
                Scan(pointToRight, house,scannedPionts);
        }
    }
}
