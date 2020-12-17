using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BricksWorkOOPVersion
{
    public class BrickWork : IBrickWork
    {  
        //private fields.
        //N
        private int rows; 
        //M
        private int cols;

        private int bricks;

        //Constructor.
        public BrickWork() {}

        //Constructors.
        public BrickWork(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
        } 

        //Proparty
        public int Bricks
        {
            //Get - returns a value.  
            //We can do manipulations.
            get { return bricks; }
            //Set - sets our value and we can also do validations.
            set
            {
                if (bricks >= 3)
                {
                    throw new InvalidOperationException("The bricks cannot cover 3 rows / columns!");
                }
                this.bricks = value;
            }
        }

        //Proparty
        public int Cols
        {
            get { return this.cols; }
            set 
            {
                if (cols > 100)
                {
                    throw new InvalidOperationException("The columns cannot be more than 100!");
                }
                this.cols = value;
            }
        }

        //Proparty
        public int Rows
        {         
            get { return this.rows; }        
            set
            {
                if (rows > 100)
                {
                    throw new InvalidOperationException("The rows cannot be more than 100!");
                }
                this.rows = value;
            }
        }

        //The method is virtual so that if at some point it is necessary to change the way the matrix is ​​created, it can be overwritten only for the specific case that is needed.
        public virtual int[,] Create(int rows, int cols)
        {
            int[,] matrixBricks = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrixBricks[row, col] = int.Parse(line[col]);
                }
            }

            return matrixBricks;
        }

        //This logic for the matrix may not be the most correct but it works for this case and that is why the method is virtual so that it can be overwritten for each case that is different from this one.
        public virtual void MatrixLogic(int rows, int cols, int[,] matrixResult)
        {
            //I work directly with the indexes, making a circle, setting them.
            matrixResult[0, 2] = matrixResult[0, 0];
            matrixResult[0, 0] = matrixResult[0, 3];
            matrixResult[1, 0] = matrixResult[0, 0];
            matrixResult[1, 2] = matrixResult[1, 1];
            matrixResult[0, 3] = matrixResult[1, 3];
        }
        public virtual void Print(int[,] matrixResult)
        {
            for (int row = 0; row < matrixResult.GetLength(0); row++)
            {
                for (int col = 0; col < matrixResult.GetLength(1); col++)
                {
                    Console.Write(matrixResult[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
