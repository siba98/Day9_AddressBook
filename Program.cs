using System;

namespace Day9_AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Welcome To Address Book Programm******");
            Console.WriteLine("\n");
            //#region
            //UC1_Details.AddPerson();
            //#endregion


            //#region
            //UC2_AddNewContact.NewContact();
            //UC2_AddNewContact.ListPeople();
            //UC2_AddNewContact.AddNew();
            //#endregion

            #region
            UC3_UpdateExistingContact.NewContact();
            UC3_UpdateExistingContact.ListAllContacts();
            UC3_UpdateExistingContact.Update();
            #endregion

            //#region
            //UC4_DeleteContact.NewContact();
            //UC4_DeleteContact.ListContacts();
            //UC4_DeleteContact.RemovePerson();
            //#endregion

            //#region
            //UC5_AddMultipleContacts.NewContact();
            //UC5_AddMultipleContacts.ListPeople();
            //UC5_AddMultipleContacts.AddNew();
            //#endregion

            //#region
            //UC6_UniqueAddress.ContactDetails();
            //UC6_UniqueAddress.ListAllPeople();
            //UC6_UniqueAddress.AddUniqueAddress();
            //#endregion

        }
    }
}
