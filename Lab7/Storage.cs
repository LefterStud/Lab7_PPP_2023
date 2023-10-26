namespace Lab7
{
    /// <summary>
    /// Storage is a class for managing spare parts in the Storage
    /// </summary>
    public class Storage
    {
        List<SparePart> spareParts = new List<SparePart>();

        /// <summary>
        /// Add the Spare part in the Storage.
        /// </summary>
        /// <param name="newPart">Part for add.</param>
        public void AddPart(SparePart newPart)
        {

            if (!spareParts.Contains(newPart))
            {
                spareParts.Add(newPart);
            }
            else
            {
                throw new ArgumentOutOfRangeException("This spare part is already in Storage!/Incorrect Id.");
            }
        }

        /// <summary>
        /// Remove the Spare part from the Storage
        /// </summary>
        /// <param name="partId">Id of the spare part to delete</param>
        public void RemovePart(int partId)
        {
            foreach (SparePart partToRemove in spareParts)
            {
                if (partToRemove.Id == partId)
                {
                    spareParts.Remove(partToRemove);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("This spare part is not exist!/Incorrect Id.");
                }
            }
        }

        /// <summary>
        /// Find the Spare part in the Storage
        /// </summary>
        /// <param name="partId">Id of the part.</param>
        public SparePart FindPartById(int partId)
        {
            foreach (SparePart sparePart in spareParts)
            {
                if (sparePart.Id == partId)
                {
                    return sparePart;
                }
            }
            throw new ArgumentOutOfRangeException("Element not found!");
        }

        public List<SparePart> GetAllParts()
        {
            return spareParts;
        }
    }
}
