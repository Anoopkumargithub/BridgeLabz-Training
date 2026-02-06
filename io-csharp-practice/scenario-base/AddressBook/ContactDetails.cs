using System;

namespace BridgeLabzTraining.senariobased.address_book
{
    internal class ContactDetails
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address {  get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string ZIPCode { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }

        public ContactDetails(string firstName, string lastName, string address, string city, string state, string zIPCode, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZIPCode = zIPCode;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Getter methods
        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string GetCity()
        {
            return City;
        }

        public string GetState()
        {
            return State; 
        }

        public string GetZIPCode()
        {
            return ZIPCode;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public string GetEmail()
        {
            return Email;
        }


        public override string? ToString()
        {
            return "Name: " + FirstName + " " + LastName + "\n" +
                "Address: " + Address + "\n" +
                "City: " + City + "\n" +
                "State: " + State + "\n" +
                "ZIP Code: " + ZIPCode + "\n" +
                "------------------------------------\n" +
                "Contact Details: \n" +
                "PhoneNumber: " + PhoneNumber + "\n" +
                "Email Address: " + Email;
        }
    }
}
