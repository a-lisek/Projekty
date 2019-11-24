using System;
namespace Lab5
{
    public class Zadanie8
    {
        public void Wyw8()
        {
            int[][] tab1 =
            {
                new int[] { 1, 3, 5, 7},
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };
            Matrix2 m1 = new Matrix2(4, 3, tab1);

            m1.PrintMatrix();

            int[][] tab2 =
            {
                new int[] { 1, 3},
                new int[] { 0, 2, 4},
                new int[] { 11, 22 },
                new int[] { 10, 22 }
            };
            Matrix2 m2 = new Matrix2(3, 4, tab2);
            m2.PrintMatrix();


            Matrix2 m3 = m1.AddMatrix(m2);
            m3.PrintMatrix();
        }
    }
    public class Matrix2
    {
        int[][] matrix;
        int c;
        int r;

        public Matrix2(int col, int row, int[][] tab)
        {
            matrix = new int[col][];

            c = col;
            r = row;

            for(int i= 0; i < col; i++)
            {
                matrix[i] = new int[row];
                for (int j=0; j< row; j++)
                {
                    if(i<tab.Length && j < tab[i].Length)
                    {
                        matrix[i][j] = tab[i][j];
                    }
                    else
                    {
                        matrix[i][j] = 0;
                    }
                    
                }
                
            }

        }

        public void PrintMatrix()
        {
            Console.WriteLine("Macierz:");
            for (int i = 0; i< c; i++)
            {
                for(int j= 0; j<r; j++)
                {
                
                    Console.Write(matrix[i][j]+" ");
                }
                Console.WriteLine();
            }
        }

        public void AddElem(int elem, int col, int row) 
        {
            if (col < c && row < r)
            {
                matrix[col][row] += elem;
            }
            else
            {
                Console.WriteLine("Poza zakresem");
            }

        }
        public int GetRow()
        {
            return r;
        }
        public int GetCol()
        {
            return c;
        }
        public int GetElem(int col, int row)
        {
            return matrix[col][row];
        }
        public Matrix2 AddMatrix(Matrix2 m2)
        {
            int r1 = this.GetRow();
            int c1 = this.GetCol();

            int r2 = m2.GetRow();
            int c2 = m2.GetCol();

            int[][] tab2 = { };

            Matrix2 m3 = new Matrix2(Math.Max(c1,c2), Math.Max(r1,r2), tab2);
            

            for (int i =0; i< c1; i++)
            {
                for(int j = 0; j < r1; j++)
                {
                    m3.AddElem(this.GetElem(i, j),i,j);
                }
                
            }
            for (int i = 0; i < c2; i++)
            {
                for (int j = 0; j < r2; j++)
                {
                    m3.AddElem(m2.GetElem(i, j), i, j);
                }

            }


            return m3;

        }
    }
}
