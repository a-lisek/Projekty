using System;
namespace Lab5
{
    public class Zadanie7
    {
        public void Wyw7()
        {
            int[] tab1 = { 1, 2, 3, 4 }; 
            Matrix m1 = new Matrix(2,3,tab1);
            
            m1.PrintMatrix();

            int elem = 9;
            int col = 1;
            int row = 2;
            m1.AddElem(elem, col, row);

            m1.PrintMatrix();

            int[] tab2 = { 4,3,2,1 };
            Matrix m2 = new Matrix(3, 2, tab2);
            m2.PrintMatrix();


            Matrix m3 = m1.AddMatrix(m2);
            m3.PrintMatrix();
        }
        
    }
    public class Matrix
    {
        int[] matrix;
        int c;
        int r;

        public Matrix(int col, int row, int[] tab)
        {
            int size = col * row;
            matrix = new int[size];

            c = col;
            r = row;

            for(int i= 0; i < size; i++)
            {
                if (i < tab.Length)
                {
                    matrix[i] = tab[i];
                }
                else
                {
                    matrix[i] = 0;
                }
            }

        }

        public void PrintMatrix()
        {
            Console.WriteLine("Macierz:");
            for (int i = 0; i< r; i++)
            {
                for(int j= 0; j<c; j++)
                {
                    int idx = c * i + j;
                
                    Console.Write(matrix[idx]+" ");
                }
                Console.WriteLine();
            }
        }

        public void AddElem(int elem, int col, int row) 
        {
            if (col < c && row < r)
            {
                int ind = row * c + col;
                matrix[ind] += elem;
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
            int ind = row * c + col;
            return matrix[ind];
        }
        public Matrix AddMatrix(Matrix m2)
        {
            int r1 = this.GetRow();
            int c1 = this.GetCol();

            int r2 = m2.GetRow();
            int c2 = m2.GetCol();

            int[] tab2 = { };

            Matrix m3 = new Matrix(Math.Max(c1,c2), Math.Max(r1,r2), tab2);
            
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
