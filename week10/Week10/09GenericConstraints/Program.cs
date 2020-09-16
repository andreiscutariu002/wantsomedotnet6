using System;

namespace _09GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            // new()

            ModelManager<Student> studentManager = new ModelManager<Student>();
            studentManager.CreateNewInstace();

            //will not work because Professor does not have a empty constructor
            //ModelManager<Professor> professorManager = new ModelManager<Professor>();
            //studentManager.CreateNewInstace();

            // class

            //ModelManagerV2<Date> modelManagerV2;

            // class

            ModelManagerV3<Date> modelManagerV3;

            //ModelManagerV3<Professor> modelManagerV3a;

            // base class, interface

            //ModelMagerV4<string> modelMagerV4a; error. string not inherit from Human
            ModelMagerV4<Professor> modelMagerV4b;
            ModelMagerV4<Student> modelMagerV4c;
            ModelMagerV4<Director> modelMagerV4d;
            //ModelMagerV4<SuperProfessor> modelMagerV4; error. SuperProfessor not inherit from Human
        }
    }

    public class ModelManager<T> where T : new()
        // The type argument must be a reference type which has a public parameterless constructor. 
        // It cannot be combined with struct and unmanaged constraints.
    {
        internal T CreateNewInstace()
        {
            return new T();
        }
    }

    public class ModelManagerV2<T> where T : class
        // The type argument must be any class, interface, delegate, or array type.
    {
    }

    public class ModelManagerV3<T> where T : struct
        // The type argument must be any class, interface, delegate, or array type.
    {
    }

    public class ModelMagerV4<T> where T : Human //, IComparable, new()
    {
        public void Print(T param)
        {
            Console.WriteLine(param.Id);
        }
    }
}
