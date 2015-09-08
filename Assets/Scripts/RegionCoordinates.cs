namespace Assets.Scripts
{
    public struct RegionCoordinates
    {
        private short x, y, z;

        public RegionCoordinates(short xParam, short yParam, short zParam)
        {
            x = xParam; y = yParam; z = zParam;
        }

        public short X()
        {
            return x;
        }

        public void SetX(short xParam)
        {
            x = xParam;
        }

        public short Y()
        {
            return y;
        }

        public void SetY(short yParam)
        {
            y = yParam;
        }

        public short Z()
        {
            return z;
        }

        public void SetZ(short zParam)
        {
            z = zParam;
        }


    }
}
