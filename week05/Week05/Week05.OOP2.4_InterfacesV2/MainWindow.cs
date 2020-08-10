namespace Week05.OOP2._4_InterfacesV2
{
    using System;

    class MainWindow : IShape, IClosable, IMovable
    {
        public void SetPosition(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int CalculateSurface()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }
    }
}
