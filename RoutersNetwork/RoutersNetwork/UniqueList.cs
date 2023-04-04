namespace RoutersNetwork
{
    public class UniqueList : List
    {
        override public void Add(int value)
        {
            if (!Contains(value))
            {
                base.Add(value);
            }
        }

        override public void Delete(int value)
        {
            if (Contains(value))
            {
                base.Delete(value);
            }
        }

        override public void Reset(int index, int value)
        {
            if (!Contains(value))
            {
                base.Reset(index, value);
            }
        }
    }
}
