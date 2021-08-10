using System;

namespace ClientDB
{
    class Client
    {

        private string lastName;
        private string firstName;
        private string secondName;
        private int myAge;

        private void setNames(string name)
        {
            string[] names = name.Split(new string[] { " ", "." },
                StringSplitOptions.RemoveEmptyEntries);
            int n = names.Length;

            if (n == 1)
            {
                firstName = names[0];

            }
            else if (n == 2)
            {
                firstName = names[0];
                secondName = names[1];
            }
            else
            {
                firstName = names[0];
                secondName = names[1];
                lastName = names[n - 1];
            }
        }

        public string fullName
        {
            get
            {
                return firstName + " " + secondName + " " + lastName;
            }

            set
            {
                setNames(value);
            }
        }
        public Client(string name)
        {

        }

        public bool isSame(string name)
        {
            string[] names = name.Split(new string[] { " ", "." },
                StringSplitOptions.RemoveEmptyEntries);

            int n = names.Length;
            return lastName.Equals(names[n - 1]) && firstName.Equals(names[0]);

        }
    }
}
