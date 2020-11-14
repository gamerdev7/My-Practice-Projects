namespace Partial_Classes
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
