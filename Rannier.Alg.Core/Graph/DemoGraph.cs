using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rannier.Alg.Core.Graph
{
    public class DemoGraph
    {
        //图中所能包含的点上限
        private const int Number = 10;
        //顶点数组
        private Vertex[] vertiexes;
        //邻接矩阵
        private int[,] adjmatrix;
        //统计当前图中有几个点
        int numVerts = 0;
        //初始化图
        public DemoGraph()
        {
            //初始化邻接矩阵和顶点数组
            adjmatrix = new int[Number, Number];
            vertiexes = new Vertex[Number];
            //将代表邻接矩阵的表全初始化为0
            for (int i = 0; i < Number; i++)
            {
                for (int j = 0; j < Number; j++)
                {
                    if (i == j)
                    {
                        adjmatrix[i, j] = 0;
                    }
                    else
                    {
                        adjmatrix[i, j] = int.MaxValue;
                    }

                }
            }
        }

        //向图中添加节点
        public void AddVertex(int v)
        {
            vertiexes[numVerts] = new Vertex(v);
            numVerts++;
        }
        //向图中添加有向边
        public void AddEdge(int vertex1, int vertex2, int distance)
        {
            adjmatrix[vertex1, vertex2] = distance;
            //adjmatrix[vertex2, vertex1] = 1;
        }
        //显示点
        public void DisplayVert(int vertexPosition)
        {
            Console.WriteLine(vertiexes[vertexPosition] + " ");
        }

        public int FindTheNoNext()
        {
            int ret = -1;

            for (int i = 0; i < numVerts; i++)
            {
                int j;
                for (j = 0; j < numVerts; j++)
                {
                    //如果找到有边
                    if (adjmatrix[i, j] != 0)
                    {
                        //直接退出
                        break;
                    }
                }

                //退出是因为中途退出还是遍历完了退出， 如果是中途退出说明有边， 那么继续
                if (j == numVerts)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }

        private void DeleteVertex(int position)
        {
            for (int i = 0; i < numVerts; i++)
            {
                adjmatrix[i, position] = 0;
            }
        }

        public void TopologySort()
        {
            Stack<Vertex> stack = new Stack<Vertex>();
            int count = numVerts;
            while (count > 0)
            {
                int index = FindTheNoNext();
                if (index == -1)
                {
                    Console.WriteLine("有环路，不能拓");
                    return;
                }
                stack.Push(vertiexes[index]);
                DeleteVertex(index);
                count--;
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().Data);
            }
        }

        public void CreateDemoGraph()
        {
            AddVertex(0);
            AddVertex(1);
            AddVertex(2);
            AddVertex(3);
            AddVertex(4);
            AddVertex(5);

            AddEdge(0, 2, 10);
            AddEdge(0, 4, 30);
            AddEdge(1, 2, 5);
            AddEdge(2, 3, 50);
            AddEdge(3, 5, 10);
            AddEdge(4, 5, 60);
            AddEdge(4, 3, 20);
        }


        // Dijkstra,其实是BFS的一种实现，使用了贪心的策略
        public int[] Dijkstra(int vertexStart)
        {
            var priorityQueue = new PriorityQueue<int, int>();

            //初始化Distance Array, start 到每个顶点的距离
            var distances = new int[numVerts];

            for (int i = 0; i < numVerts; i++)
            {
                distances[i] = adjmatrix[vertexStart, i];
            }

            int count = 0;
            while (count < numVerts)
            {
                int temp = 0; //当前distances 数组中， 最小值的下标
                int min = int.MaxValue;

                for (int i = 0; i < this.numVerts; i++) //找到没有访问过的最小值，把最小值的下标和最小值记录下来(这里可以用优先队列进行优化)
                {
                    if (!vertiexes[i].Visited && distances[i] < min)
                    {
                        min = distances[i];
                        temp = i;
                    }
                }

                vertiexes[temp].Visited = true;
                count++;

                for (int i = 0; i < numVerts; i++) // 遍历所有顶点, 如果（离temp 的距离+ temp 离起点的位置），小于当前节点距起点的位置, 说明存在更短的距离，刷新这个距离
                {
                    if (!vertiexes[i].Visited &&
                        adjmatrix[temp, i] != int.MaxValue &&
                        (distances[temp] + adjmatrix[temp, i]) < distances[i])
                    {
                        distances[i] = distances[temp] + adjmatrix[temp, i];
                    }
                }
            }


            return distances;
        }
    }
}
