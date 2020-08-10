using System;

namespace Week05.OOP2._4_InterfacesV2
{
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
