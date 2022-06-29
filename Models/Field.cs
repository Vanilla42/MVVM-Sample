using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.Models
{
    public class Field
    {
        List<int> numbersAll;

        NodeChain[] NodeChains;

        public Node[,] Nodes;

        public Field()
        {
            numbersAll = new List<int>() { 1, 2, 3, 4 };
            Nodes = GenerateNodes();
            //NodeChains = ConnectNodes();
            //Console.WriteLine(Nodes.AsQueryable().ToString());
        }

        private Node[,] GenerateNodes()
        {
            Node[,] nodes = new Node[4, 4];

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    // Get list of possible number values.
                    List<int> numbersPossible = numbersAll;
                    // Remove used numbers in the same row and the same column.
                    for (int i = 0; i < x; i++)
                        numbersPossible.Remove(nodes[i, y].Number);
                    for (int i = 0; i < y; i++)
                        numbersPossible.Remove(nodes[x, i].Number);

                    if (numbersPossible.Count == 0)
                    {
                        nodes[x, y] = new Node(x, y, 0);
                        //throw new Exception("ERROR creating the field.");
                    }

                    else
                    {
                        Random random = new Random();
                        int randomNumber = numbersPossible[random.Next(numbersPossible.Count)];

                        nodes[x, y] = new Node(x, y, randomNumber);
                    }
                }
            }   
            return nodes;
        }

        private NodeChain[] ConnectNodes()
        {
            Node[,] nodes = new Node[4, 4];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    nodes[i, j] = null;
                }
            return null;
        }
    }
}
