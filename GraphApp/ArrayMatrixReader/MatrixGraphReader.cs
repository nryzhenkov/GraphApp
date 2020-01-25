using System;
using System.IO;

namespace GraphApp
{
    public class MatrixGraphReader : IMatrixReader
    {
        public int[,] read(string path)
        {
            int[,] result = null;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string[] str = reader.ReadLine().Split(' ');
                    
                    result = new int[str.GetLength(0),str.GetLength(0)];
                    for(int i = 1; i < str.GetLength(0); i++)
                    {
                        for(int j = 0; j < str.GetLength(0); j++)
                        {
                            result[i,j] = Int32.Parse(str[j]);
                        }
                        str = reader.ReadLine().Split(' ');
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
