

namespace GraphApp
{
    public class MinSpanningTree : Graph
    {
        IMatrixReader _reader;
        public int[][] M { get; protected set; }
        public int[][] S { get; protected set; }

        public MinSpanningTree(IMatrixReader reader) 
        {
            _reader = reader;
        }

        public void LoadMatrix(string path)
        {
            M = _reader.read(path);
        }

    }
}
