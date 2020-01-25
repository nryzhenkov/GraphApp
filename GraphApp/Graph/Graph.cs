namespace GraphApp
{
    public abstract class Graph
    {
        protected IMatrixReader _reader;
        protected IFindSpanningTree _finder;

        public Graph (IMatrixReader reader, IFindSpanningTree finder)
        {
            _reader = reader;
            _finder = finder;
        }
    }
}
