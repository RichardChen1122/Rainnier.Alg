using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.advanced
{
    //跳跃表

    /*
     跳跃表是一种分层结构的有序链表，其查找和插入的平均时间复杂都是O(logN)。相比数组插入的时间复杂度O(N)和平衡二叉树
     插入过程中为满足平衡而实施复杂旋转操作，跳跃表有很大优势；同时跳跃表在并行计算中也非常有用，因为跳跃表插入是局部的操作，
     可以进行并行操作。

     参考 https://www.cnblogs.com/kexinxin/p/11699230.html
    https://www.jianshu.com/p/9d8296562806
    https://github.com/wangzheng0822/algo/blob/master/java/17_skiplist/SkipList.java

    有意思的点在于插入元素的时候 “抛硬币” 的设计
     */
    internal class SkipList
    {
        static readonly int MAX_LEVEL = 10;
        static readonly float SKIPLIST_P = 0.5f;

        private int levelCount = 1;

        private Node head;
        internal class Node
        {
            private int data = -1;
            private Node[] forwards = new Node[MAX_LEVEL];
            private int maxLevel = 0;

            public int Data
            {
                get => data;
                set => data = value;
            }

            public int MaxLevel
            {
                get => maxLevel;
                set => maxLevel = value;
            }

            // 其实就是Nexts
            public Node[] Forwards
            {
                get => forwards; 
                set => forwards = value;
            }

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("{ data: ");
                builder.Append(data);
                builder.Append("; levels: ");
                builder.Append(maxLevel);
                builder.Append(" }");

                return builder.ToString();
            }
        }

        public Node Find(int number)
        {
            var current = head;
            
            for (int i = levelCount - 1; i >= 0; i--)
            {
                while (current.Forwards[i] != null && current.Forwards[i].Data < number)
                {
                    current = current.Forwards[i];
                }
            }


            if (current.Forwards[0] != null && current.Forwards[0].Data == number)
            {
                return current.Forwards[0];
            }
            else
            {
                return null;
            }
        }


        public void Insert(int number)
        {
            int level = RandomLevel();
            Node newNode = new Node()
            {
                Data = number,
                MaxLevel = level,
            };
            
            Node[] update = new Node[level];
            for (int i = 0; i < level; i++)
            {
                update[i] = head;
            }

            // record every level largest value which smaller than insert value in update[]
            Node p = head;
            for (int i = level - 1; i >= 0; i--)
            {
                while (p.Forwards[i] != null && p.Forwards[i].Data < number)
                {
                    p = p.Forwards[i];
                }
                update[i] = p;// use update save node in search path
            }

            // in search path node next node become new node forwords(next)
            for (int i = 0; i < level; ++i)
            {
                newNode.Forwards[i] = update[i].Forwards[i];
                update[i].Forwards[i] = newNode;
            }

            // update node hight
            if (levelCount < level) levelCount = level;
        }

        public void delete(int value)
        {
            Node[] update = new Node[levelCount];
            Node p = head;
            for (int i = levelCount - 1; i >= 0; --i)
            {
                while (p.Forwards[i] != null && p.Forwards[i].Data < value)
                {
                    p = p.Forwards[i];
                }
                update[i] = p;
            }

            if (p.Forwards[0] != null && p.Forwards[0].Data == value)
            {
                for (int i = levelCount - 1; i >= 0; --i)
                {
                    if (update[i].Forwards[i] != null && update[i].Forwards[i].Data == value)
                    {
                        update[i].Forwards[i] = update[i].Forwards[i].Forwards[i];
                    }
                }
            }

            while (levelCount > 1 && head.Forwards[levelCount] == null)
            {
                levelCount--;
            }

        }

        public void PrintAll()
        {
            Node p = head;
            while (p.Forwards[0] != null)
            {
                Console.WriteLine(p.Forwards[0] + " "); 
                p = p.Forwards[0];
            }
            Console.WriteLine();
        }

        private int RandomLevel()
        {
            int level = 1;
            var r = new Random();
            // 当 level < MAX_LEVEL，且随机数小于设定的晋升概率时，level + 1
            while (r.Next() < SKIPLIST_P && level < MAX_LEVEL)
                level += 1;
            return level;
        }

    }

    
}
