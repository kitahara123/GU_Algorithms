using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Paderov Evgeny
/// </summary>
namespace GU_Algorithms
{

    class Program
    {
        // 7 урок
        static void Main(string[] args)
        {
            int[,] graph = new int[7,7];


            graph[0, 1] = 5;
            graph[0, 6] = 9;

            graph[1, 0] = 5;
            graph[1, 2] = 8;
            graph[1, 6] = 2;

            graph[2, 1] = 8;
            graph[2, 5] = 4;

            graph[3, 5] = 3;

            graph[4, 5] = 1;

            graph[5, 2] = 4;
            graph[5, 3] = 3;
            graph[5, 4] = 1;
            graph[5, 6] = 3;

            graph[6, 0] = 9;
            graph[6, 1] = 2;
            graph[6, 5] = 6;

            Console.ReadKey();
        }


        int Dijkstra(int from, int to, int[,] graph)
        {
            int[] checkd = new int[7];
            int[] route = new int[7] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };
            Queue<int> queue = new Queue<int>();

            route[from] = 0;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                var p = graph[i, from];
                if (p > 0)
                {
                    queue.Enqueue(i);
                    checkd[i] = 1;
                    route[i] = p;
                }
            }
            
            

        }
    }
}

