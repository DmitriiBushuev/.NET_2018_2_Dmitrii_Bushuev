

namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * (x + 1) * 9 + x.GetHashCode();
            hash = hash * (y + 1) * 44 + y.GetHashCode();
            return hash;
        }
    }
}
