using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.Models
{
    public class Field
    {
        Node[,] Nodes;

        NodeChain[] NodeChains;

        public Field()
        {
            Nodes = GenerateNodes();
            //NodeChains = ConnectNodes();
            Console.WriteLine(Nodes.AsQueryable().ToString());
        }

        private Node[,] GenerateNodes()
        {
            Node[,] nodes = new Node[4, 4];

            // Get list of all number values.
            Array numbersAllArray = Enum.GetValues(typeof(Numbers));
            List<Numbers> numbersAll = new List<Numbers>();
            foreach (Numbers n in numbersAllArray)
            {
                numbersAll.Add(n);
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    // Get list of unused number values.
                    List<Numbers> numbersUnused = numbersAll;
                    // Remove used numbers in the same row and the same column.
                    for (int i = 0; i < x; i++)
                        numbersUnused.Remove(nodes[i, y].Number);
                    for (int i = 0; i < y; i++)
                        numbersUnused.Remove(nodes[x, i].Number);

                    Random random = new Random();
                    Numbers randomNumber = numbersUnused[random.Next(numbersUnused.Count)];

                    nodes[x, y] = new Node(x, y, randomNumber);
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
