using System;


namespace ContactList
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string notes;
        private string email;
        private string phone;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set {
                if (value.Length == 10)
                {
                    phone = value;
                }
                else
                {
                    phone = "0000000000";
                }

            }
        }
        public Contact()
            {
            FirstName = "John";
            LastName = "Doe";
            Phone = "0000000000";
            Notes = "comments";
            Email = "JohnDoe@gmail.com";
        }
        public Contact(string firstName, string lastName, string phone, string email, string notes)
        {
            FirstName = firstName;  
            LastName = lastName;
            Phone = phone;  
            Email = email;  
            Notes = notes;
        }
        public override string ToString()
        {
            String output = string.Empty;

            output += String.Format("{0}, {1}", LastName, FirstName);
            output += String.Format("{0}, {1}-{2]", Phone.Substring(0,3), Phone.Substring(3, 3), Phone.Substring(6, 4));

            return output;  
        }


    }// end of class
}// end of main space

