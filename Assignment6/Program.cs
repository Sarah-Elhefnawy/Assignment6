using System;
using System.Xml.Linq;

namespace Assignment6_Part1;

internal class Program
{
    static void Main(string[] args)
    {
        #region Q1 
        //Explain with code example how class and struct behave differently 

        /*
         * class: stored on the heap, can inherit, default constructor is provided if none defined
         * struct: stored on the stack, can't inherit from other struct || class, default constructor always exists and can't be removed
         */

        Person p1 = new Person(1, "Original");
        Person p2 = p1;
        p2.Name = "Modified";
        //p1.PrintPerson();                      //Id = 1, name = Modified
        //p2.PrintPerson();                      //Id = 1, name = Modified

        Axis a1 = new Axis(180.5,90.7);
        Axis a2 = a1;
        a2.x = 999.9;
        //a1.PrintAxis();                        //x = 180.5, y = 90.7
        //a2.PrintAxis();                        //x = 999.9, y = 90.7

        #endregion

        #region Q2
        //Explain the difference between public and private access modifiers with an example. 

        /*
         * public: are availabe to access through the whole project
         * private: are only available through it's direct block
         */

        Person person = new Person();
        //person.Id = 10;                 // error as it's a private field can't be accessed
        //person.Name = "Ali";
        //Console.WriteLine(person.PrintPrivateId());      // 1    -> private field's data was assigned only in it's class
        //Console.WriteLine(person.PrintPublicName());     // Ali  -> can access and assign the value of the field in the program class

        #endregion

        #region Q3
        //Describe the steps to create and use a class library in Visual Studio.

        /*
         * right click on solution, choose add, choose new project, add the name then create
         * 
         * after the class creation to use it you must have using keyword to be used in another project 
         */

        #endregion

        #region Q4
        //What is a class library? Why do we use class libraries? 

        /*
         * they are reusable libraries (.dll) which has no output
         * they're a separate project that contain reusable class withou the Main method
         * 
         * they're organized, reusable, teamwork, maintenance
         */
        #endregion
    }
}
