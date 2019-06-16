using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDV
{
    public static class Program
    {

        public static int _refreshTime = 5;

        public static bool IsOdd(this int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
           
            var routerA = new Router("A");
            var routerB = new Router("B");
            var routerC = new Router("C");
            var routerD = new Router("D");
            var routerE = new Router("E");
            var routerF = new Router("F");

            Graph.AddRouter(routerA);
            Graph.AddRouter(routerB);
            Graph.AddRouter(routerC);
            Graph.AddRouter(routerD);
            Graph.AddRouter(routerE);
            Graph.AddRouter(routerF);

            var task = Task.Run(() => Graph.SendTables());

            routerA.AddNeighbor(routerB, 3);
            routerB.AddNeighbor(routerC, 7);
            routerC.AddNeighbor(routerD, 8);
            routerD.AddNeighbor(routerE, 8);
            routerE.AddNeighbor(routerF, 8);

            Application.Run(new Meniu());
            Console.ReadLine();
        }

    }
}
