using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.graph.model
{
    public class DemoGraph
    {
        //图中所能包含的点上限
        private const int Number = 10;
        //顶点数组
        private Vertex[] vertiexes;
        //邻接矩阵
        public int[,] adjmatrix;
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
                    adjmatrix[i, j] = 0;
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
        public void AddEdge(int vertex1, int vertex2)
        {
            adjmatrix[vertex1, vertex2] = 1;
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

            for(int i=0;i< numVerts; i++)
            {
                int j;
                for (j = 0; j < numVerts; j++)
                {
                    if (adjmatrix[i, j] != 0)
                    {
                        break;
                    }
                }

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
            for(int i = 0; i < numVerts; i++)
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
    }
}
