using System;
using System.Collections.Generic;
using System.Text;

namespace BricksWorkOOPVersion
{
    public interface IBrickWork : ICreatable, IPrintable
    {
        //This is the interface that is responsible for the logic matrix. 
        //Anyone who inherits this interface agrees that it will contain this method. 
        //This interface inherits the other two interfaces and agrees to retain the methods of the other two interfaces.
        void MatrixLogic(int rows, int cols, int[,] matrixResult);
    }
}
