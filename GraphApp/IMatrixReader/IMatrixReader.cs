using System;

namespace GraphApp
{
    public interface IMatrixReader
    {
        public int[][] read(string path);
    }
}
