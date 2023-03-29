using List.Exceptions;

namespace List
{
    public class UniqueList : List
    {
        override public void Add(int value)
        {
            if (Contains(value))
            {
                throw new AddSameValueException("Adding the same value to UniqueList");
            }
            base.Add(value);
        }

        override public void Delete(int value)
        {
            if (!Contains(value))
            {
                throw new DeleteNotExistingElementException("Deleting element that is not existing");
            }
            base.Delete(value);
        }

        override public void Reset(int index, int value)
        {
            if (Contains(value))
            {
                throw new ResetingToAldreadyExisingElementException("Reseting to aldready exsiting element");
            }
            base.Reset(index, value);
        }
    }
}
