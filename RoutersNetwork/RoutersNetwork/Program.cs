namespace RoutersNetwork
{
    class Program
    {
        // входные данные считавать с параметров консольного приложения
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Router's network*****");
            string path;

            //getting file path
            while (true)
            {
                Console.Write("Enter absolute path to file: ");
                path = Console.ReadLine();
                if (File.Exists(path))
                {
                    break;
                }
                Console.WriteLine("Wrong path");
            }

            List<Edge> edges = new List<Edge>();
            UniqueList vertexes = new UniqueList();

            //reading file
            using (StreamReader stream = new StreamReader(@path))
            {
                string data;
                while (true)
                {
                    data = stream.ReadLine();
                    if (data == null)
                    {
                        break;
                    }
                    //добавить проверку корректности файла
                    data = data.Replace("(", "").Replace(")", "").Replace(":", "").Replace(",", "");
                    string[] edgesData = data.Split(' ');
                    try
                    {
                        if (!int.TryParse(edgesData[0], out int vertex1) || vertex1 <= 0)
                        {
                            throw new BadFileInputException("Bad input in file");
                        }
                        vertexes.Add(vertex1);

                        for (int i = 1; i < edgesData.Length; i += 2)
                        {
                            if (!int.TryParse(edgesData[i], out int vertex2) || vertex2 <= 0)
                            {
                                throw new BadFileInputException("Bad input in file");
                            }
                            vertexes.Add(vertex2);

                            if (!int.TryParse(edgesData[i + 1], out int weight) || weight <= 0)
                            {
                                throw new BadFileInputException("Bad input in file");
                            }

                            Edge edge = new Edge(vertex1, vertex2, weight);
                            edges.Add(edge);
                        }
                    }
                    catch (BadFileInputException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            //solving task
            List<Edge> result = Graph.PrimsAlgorithm(vertexes.GetSize(), edges);

            //вынести печать в отдельный метод
            //outputing result to the console
            int lastVertex1 = -1;
            for (int i = 0; i < result.Count; ++i)
            {
                if (lastVertex1 == result[i].Vertex1)
                {
                    Console.Write($", {result[i].Vertex2} ({result[i].Weight})");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write($"{result[i].Vertex1}: {result[i].Vertex2} ({result[i].Weight})");
                }
                lastVertex1 = result[i].Vertex1;
            }
        }
    }
}