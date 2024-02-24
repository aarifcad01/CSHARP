using System;

namespace inheritancedemo{

    class Students : Management{
       public void stds(){
           int[] classes={10,11,12};
           Console.WriteLine(classes[0] + " , " + classes[1] + " , " + classes[2]) ;
       }
    }
}