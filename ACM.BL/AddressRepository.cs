using System;
using System.Collections.Generic;

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

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that retrieves defined address

            // temp hard code to return an address
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146",
            };
            addressList.Add(address);

            return addressList;
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
