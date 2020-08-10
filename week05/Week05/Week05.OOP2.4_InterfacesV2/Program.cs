using System;

namespace Week05.OOP2._4_InterfacesV2
{
    public abstract class Shape
    {
        public abstract void SetPosition(int x, int y);
        public abstract int CalculateSurface();
    }

    public abstract class Movable
    {
        public abstract void Move(int deltaX, int deltaY);
    }

    // error
    //public class SomeShape : Shape, Movable 
    //{
    //    public override void SetPosition(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override int CalculateSurface()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Move(int deltaX, int deltaY)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    // este permis
    public class SomeShape : Shape, IMovable, IClosable
    {
        public override void SetPosition(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override int CalculateSurface()
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }

    public interface IShape
    {
        void SetPosition(int x, int y);
        int CalculateSurface();
    }

    public interface IMovable
    {
        void Move(int deltaX, int deltaY);
    }

    public interface IClosable 
    {
        void Close();
    }

    public interface IResizable
    {
        void Resize(int weight);
        void Resize(int weightX, int weightY);
        void ResizeByX(int weightX);
        void ResizeByY(int weightY);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
