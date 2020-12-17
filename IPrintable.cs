using System;
using System.Collections.Generic;
using System.Text;

namespace BricksWorkOOPVersion
{
    public interface IPrintable
    {
        //This is the interface that is responsible for the printing. 
        //Anyone who inherits this interface agrees that it will contain this method.
        void Print(int[,] matrixResult);
    }
}
