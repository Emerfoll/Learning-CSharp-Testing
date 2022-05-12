using System;
namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public Address Retrieve(int addressId)
        {
            // Create the instance of the address class
            // pass in requested Id

            Address address = new Address(addressId);

            // code that retrieves defined address

            // temp hard code to return an address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;

        }

        /// <summary>
        /// Saves current address
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // code to save address

            return true;
        }
    }
}
