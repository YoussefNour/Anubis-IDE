using System;

struct test;
/*testing 
multiline comments*/
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 5;
      int y = 5;
      int z = x+y;
      z += z*y;
      z += z-x;
      z += z+y;
      z += y/x;
      if(z>=10){
        Console.WriteLine("Hello World!"); 
      }  
    }
  }
}