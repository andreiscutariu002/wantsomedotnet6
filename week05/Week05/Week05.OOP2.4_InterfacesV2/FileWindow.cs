namespace Week05.OOP2._4_InterfacesV2
{
    using System;

    class FileWindow: IShape, IClosable, IMovable, IResizable
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

        public void Resize(int weight)
        {
            throw new NotImplementedException();
        }

        public void Resize(int weightX, int weightY)
        {
            throw new NotImplementedException();
        }

        public void ResizeByX(int weightX)
        {
            throw new NotImplementedException();
        }

        public void ResizeByY(int weightY)
        {
            throw new NotImplementedException();
        }
    }
}
