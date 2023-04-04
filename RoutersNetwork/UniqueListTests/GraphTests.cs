namespace Tests
{
    public class GraphTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(1, 2, 10));
            edges.Add(new Edge(1, 3, 5));
            edges.Add(new Edge(2, 3, 1));

            List<Edge> result = Graph.PrimsAlgorithm(3, edges);
            Assert.IsTrue(result[0].Weight == 10 && result[1].Weight == 5);
        }

        [Test]
        public void Test2()
        {
            List<Edge> edges = new List<Edge>();
            edges.Add(new Edge(1, 2, 10));
            edges.Add(new Edge(1, 3, 5));
            edges.Add(new Edge(1, 4, 4));
            edges.Add(new Edge(2, 3, 1));
            edges.Add(new Edge(3, 4, 15));
            List<Edge> result = Graph.PrimsAlgorithm(4, edges);
            Assert.IsTrue(result[0].Weight == 10 && result[1].Weight == 5 && result[2].Weight == 15);
        }


    }
}