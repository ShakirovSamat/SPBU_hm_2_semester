namespace RoutersNetwork
{
    public static class Graph
    {
        //Prim's algorithm
        public static List<Edge> PrimsAlgorithm(int amountOfVertexes, List <Edge> edges)
        {
            List<Edge> miningSpanningTree = new List<Edge>();
            List<Edge> notUesdEedges = new List<Edge>(edges);
            List<int> notUsedVertexes = new List<int>();
            List<int> usedVertexes = new List<int>();

            for (int i = 0; i < amountOfVertexes; ++i)
            {
                notUsedVertexes.Add(i + 1);
            }

            usedVertexes.Add(1);
            notUsedVertexes.Remove(usedVertexes[0]);

            while (notUsedVertexes.Count > 0)
            {
                int maxEdge = int.MinValue;
                for (int i = 0; i < notUesdEedges.Count; ++i)
                {
                    if (usedVertexes.Contains(notUesdEedges[i].Vertex1) && notUsedVertexes.Contains(notUesdEedges[i].Vertex2)
                        || usedVertexes.Contains(notUesdEedges[i].Vertex2)  && notUsedVertexes.Contains(notUesdEedges[i].Vertex1))
                    {
                        if (maxEdge != int.MinValue)
                        {
                            if (notUesdEedges[i].Weight > notUesdEedges[maxEdge].Weight)
                            {
                                maxEdge = i;
                            }      
                        }
                        else
                        {
                            maxEdge = i;
                        }
                    }
                }

                if (usedVertexes.IndexOf(notUesdEedges[maxEdge].Vertex1) != -1)
                {
                    usedVertexes.Add(notUesdEedges[maxEdge].Vertex2);
                    notUsedVertexes.Remove(notUesdEedges[maxEdge].Vertex2);
                }
                else
                {
                    usedVertexes.Add(notUesdEedges[maxEdge].Vertex1);
                    notUsedVertexes.Remove(notUesdEedges[maxEdge].Vertex1);
                }

                miningSpanningTree.Add(notUesdEedges[maxEdge]);
                notUesdEedges.RemoveAt(maxEdge);//опасность

            }
            // Добавить проверку на несвязанный граф
            return miningSpanningTree;

        }
    }
}
