namespace G_NET_26_OOP_1
{
    internal class Program
    {
        //class PersonClass
        //{
        //    public string? Name;
        //}
        //struct PersonStruct
        //{
        //    public string Name;
        //}

        //class Student
        //{
        //    public string? name { get; set; }
        //    private int age { get; set; }
        //}
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            // Struct:
            // - Value Type
            // - Stored in Stack
            // - When assigned -> copies the actual data
            // - Does NOT support inheritance
            // - Cannot be null
            // - Has implicit default constructor
            // - Best for small, simple data

            //PersonStruct s1 = new();
            //s1.Name = "Ali";

            //PersonStruct s2 = s1;
            //s2.Name = "Omar";

            //Console.WriteLine(s1.Name); // Ali (copied value)

            // Class:
            // - Reference Type
            // - Object stored in Heap (reference stored in stack)
            // - When assigned → copies the reference (not the data)
            // - Supports inheritance
            // - Can be null
            // - Default constructor exists only if you don't define one
            // - Best for complex objects with behavior

            //PersonClass p1 = new PersonClass();
            //p1.Name = "Ali";

            //PersonClass p2 = p1;
            //p2.Name = "Omar";

            //Console.WriteLine(p1.Name); // Omar (same reference)


            #endregion
            #region Q2
            // public : accessible everywhere
            // private : accessible only inside the same class

            //Student s = new Student();
            //s.name = "Shorouk";  // Ok
            //s.age = 20; // Error (private)

            #endregion
            #region Q3
            // 1) open visual studio
            // 2) click create new project
            // 3) choose class library (.NET)
            // 4) name the project
            // 5) add your classes inside it
            // 6) build the project
            // 7) create another project (Console App)
            // 8) right click console project → Add Reference
            // 9) select your classlLibrary
            // 10) now you can use its classes inside the Console App

            #endregion
            #region Q4
            // Class Library:
            // - a project that contains reusable classes and methods
            // - it doesn't contain a Main() method
            // - it cannot run alone

            // Why we use it:
            // - reuse code in multiple projects
            // - different developers can work on different libraries independently
            // - separate the system into different parts
            // - make code cleaner and maintainable
            #endregion
            #endregion
            #region Part02
            #endregion
        }
    }
}
