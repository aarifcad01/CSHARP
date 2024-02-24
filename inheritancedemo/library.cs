using System;

namespace inheritancedemo{
  class Library : School{
    public void details(){
        string Entry="entry time should be on ";
        int[] x={9,6};
        Console.WriteLine(Entry + x[0] + " to " + x[1]);
    }
  }

}