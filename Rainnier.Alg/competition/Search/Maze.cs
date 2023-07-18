using Rainnier.Alg.tree.model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.Search
{
    struct Node
    {
        public int x;
        public int y;
        public string path;
    }
    // 迷宫 例3.15
    public class Maze
    {
        char[,] map;

        char[] k = new char[] { 'D', 'L', 'R', 'U' };

        int[,] direction = new int[4, 2] { { 1, 0 }, { 0, -1 }, { 0, 1}, { -1, 0 } };

        bool[,] visited = new bool[4,6];

        char[,] pre = new char[5,7];

        public void CreateTestDemo()
        {
            map = new char[4, 6]
            {
                { '0','1','0','0','0','0'},
                { '0','0','0','1','0','0'},
                { '0','0','1','0','0','1'},
                { '1','1','0','0','0','0'},
            };


            
        }


        public string BFS()
        {
            Node start = new Node() { x = 0, y = 0 };

            var queue = new Queue<Node>();
            queue.Enqueue(start);

            while(queue.Count > 0)
            {
                var front = queue.Dequeue();

                if(front.x==3 && front.y == 5)
                {
                    return front.path;
                }

                if (!visited[front.x, front.y]) 
                {
                    visited[front.x, front.y] = true;

                    for (int i = 0; i < 4; i++)
                    {
                        Node next = new Node();
                        next.x = front.x + direction[i,0];
                        next.y = front.y + direction[i, 1];

                        if (next.x>=0 && next.y>=0 && next.x<4 && next.y < 6 && map[next.x,next.y]!='1' )
                        {
                            next.path = front.path + k[i];
                            queue.Enqueue(next);
                        }
                    }
                }

                
            }

            return null;
        }

        public string BFS_NoStorePathInStuct()
        {
            Node start = new Node() { x = 0, y = 0 };

            var queue = new Queue<Node>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var front = queue.Dequeue();

                if (front.x == 3 && front.y == 5)
                {
                    return PrintPath(3, 5, "");
                }

                //if (!visited[front.x, front.y])
                //{
                    //visited[front.x, front.y] = true;

                    for (int i = 0; i < 4; i++)
                    {
                        Node next = new Node();
                        next.x = front.x + direction[i, 0];
                        next.y = front.y + direction[i, 1];

                        if (next.x >= 0 && next.y >= 0 && next.x < 4 && next.y < 6 && map[next.x, next.y] != '1' && !visited[next.x,next.y])
                        {
                            visited[next.x, next.y] = true;
                            //next.path = front.path + k[i];
                            pre[next.x, next.y] = k[i];
                            queue.Enqueue(next);
                        }
                    }
                //}


            }

            return null;
        }

        public string PrintPath(int x, int y, string t)
        {
             if (x==0 && y == 0)
            {
                return t;
            }

            if (pre[x, y] == 'D') return PrintPath(x - 1, y, pre[x, y] + t);
            if (pre[x, y] == 'L') return PrintPath(x, y + 1, pre[x, y] + t);
            if (pre[x, y] == 'R') return PrintPath(x, y - 1, pre[x, y] + t);
            if (pre[x, y] == 'U') return PrintPath(x + 1, y, pre[x, y] + t);

            return t;
        }
    }
}
