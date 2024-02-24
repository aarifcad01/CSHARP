using System;

namespace inheritancedemo{
class Inheritancedemo{
  public static void Main(string[]args){
   Console.WriteLine("enter school name is chellamal");
   Library obj1=new Library();
   obj1.nameofschool();
   obj1.details();
   Students obj2=new Students();
   obj2.manage();
   obj2.stds();
  }

}
  }


