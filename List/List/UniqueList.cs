namespace program
{
    public class UniqueList : List
    {
        /// <summary>
        /// adds elements to unique list
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="AddSameValueException"></exception>
        override public void Add(int value)
        {
            if (Contains(value))
            {
                throw new AddSameValueException("Adding the same value to UniqueList");
            }
            base.Add(value);
        }

        /// <summary>
        /// deletes element from unique list
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="DeleteNotExistingElementException"></exception>
        override public void Delete(int value)
        {
            if (!Contains(value))
            {
                throw new DeleteNotExistingElementException("Deleting element that is not existing");
            }
            base.Delete(value);
        }

        /// <summary>
        /// resets element to another from unique list at particulart index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <exception cref="ResetingToAldreadyExisingElementException"></exception>
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
