using System;
using System.Collections.Generic;
using System.Text;

namespace BricksWorkOOPVersion
{
    public interface ICreatable
    {
        //This is the interface that is responsible for the create. 
        //Anyone who inherits this interface agrees that it will contain this method.
        int[,] Create(int rows, int cols);
    }
}
