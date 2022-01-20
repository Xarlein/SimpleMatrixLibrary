namespace MatrixLibrary
{
    public struct Matrix
    {

        private int rows;
        private int columns;
        private float[,] values;

        #region Preperties

        public int Rows { get => rows; }
        public int Columns { get => columns; }
        public float[,] Values { get => values; }

        #endregion

        #region Constructors

        public Matrix() 
        {
            rows = 0;
            columns = 0;
            values = new float[0, 0];
        }

        public Matrix(int rows, int columns) 
        { 
            this.rows = rows;
            this.columns = columns;
            values = new float[rows, columns];
        }

        public Matrix(int rows, int columns, float[,] values)
        {
            this.rows = rows;
            this.columns = columns;
            this.values = new float[rows, columns];

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    this.values[i, j] = values[i, j];
                }
            }
        }

        #endregion

        #region Methods and Funtions

        public static Matrix Addition(Matrix a, Matrix b) 
        {

            if ((a.Columns != b.Columns) || (a.Rows != b.Rows))
                throw new Exception("Matrixs is not equals of size");

            Matrix result = new Matrix(a.Rows, b.Columns);

            for (int i = 0; i < a.Rows; i++) 
            {
                for (int j = 0; j < b.Columns; j++) 
                {
                    
                    result.Values[i, j] = a.Values[i, j] + b.Values[i, j];

                }
            }

            return result;

        }

        public static void Display(Matrix matrix) 
        {
            for (int i = 0; i < matrix.Rows - 1; i++)
            {
                for (int j = 0; j < matrix.Columns - 1; j++)
                {

                    Console.Write(matrix.Values[i, j]);

                }

                Console.WriteLine();
            }
        }
        
        #endregion
    }

}