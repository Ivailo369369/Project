using System;
using System.Linq;
using System.Collections.Generic;

namespace BricksWorkOOPVersion
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //The entrance to my program. First I read input from the console, then I divide it, then I remove the empty strings and parse it to int, and finally I add it to the array.
            var inputBricks = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();  

            //rows = n
            int rows = inputBricks[0]; 

            //cols = m
            int cols = inputBricks[1];

            //I use "try catch" to tell the compiler to try to execute the logic I gave it, and if it fails somewhere and there is an input error, it calls the "catch" (exseption) I set in advance.
            try
            {
                //I create an instance of type brickWork, giving it data that is pre - written in the constructor. 
                //I create this instance so that I can use all the methods and proparties that are written in the BrickWork class.
                BrickWork brickWork = new BrickWork(rows, cols); 
                int[,] matrixBricks = brickWork.Create(rows, cols); 
                int[,] matrixResult = new int[rows, cols];
                matrixResult = matrixBricks;
                brickWork.MatrixLogic(rows, cols, matrixResult);
                Console.WriteLine(new string('-', 8));
                brickWork.Print(matrixResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
    }
}
