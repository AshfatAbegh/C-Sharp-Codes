using System;


namespace ConsoleApp5
{
    class AddressBook
    {
        private String ownerName;
        private String info;
        private Contact[] listOfContact;

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public string Info { get => info; set => info = value; }

        public AddressBook() { }

        public AddressBook(string ownerName, string info, int size)
        {
            this.ownerName = ownerName;
            this.info = info;
            listOfContact = new Contact[size];
        }

        public void ShowAllContactInfo()
        {
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] != null)
                {
                    listOfContact[i].ShowPersonInfo();
                }
            }
        }

        public void AddContact(Contact con)
        {
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] == null)
                {
                    listOfContact[i] = con;
                    break;
                }
            }
        }

        public void DeleteContact(Contact con)
        {
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] == null)
                {
                    continue;
                }
                else if (listOfContact[i] == con)
                {
                    listOfContact[i] = null;
                    for (int j = i; j < listOfContact.Length - 1; j++)
                    {
                        listOfContact[j] = listOfContact[j + 1];

                    }
                    listOfContact[listOfContact.Length - 1] = null;
                    Console.WriteLine("***Contact deleted***\n");
                    break;
                }

            }
        }
    }
}
