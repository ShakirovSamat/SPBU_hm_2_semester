namespace RoutersNetwork
{
    public static class Graph
    {

        //Prim's algorithm
        public static List<Edge> PrimsAlgorithm(int amountOfVertexes, List <Edge> edges)
        {
            List<Edge> mst = new List<Edge>();
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
                int maxEdge = -1;
                for (int i = 0; i < notUesdEedges.Count; ++i)
                {
                    if ((usedVertexes.IndexOf(notUesdEedges[i].Vertex1) != -1) && (notUsedVertexes.IndexOf(notUesdEedges[i].Vertex2) != -1)
                        || (usedVertexes.IndexOf(notUesdEedges[i].Vertex2) != -1)  && (notUsedVertexes.IndexOf(notUesdEedges[i].Vertex1) != -1))
                    {
                        if (maxEdge != -1)
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

                mst.Add(notUesdEedges[maxEdge]);
                notUesdEedges.RemoveAt(maxEdge);

            }
            return mst;

        }
    }
}
