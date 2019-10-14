using ContactSInformation;
using System.Collections.Generic;

namespace ContactsInformation
{

    class Program
    {//Install  before building project
     //Install-Package EntityFramework -Version 6.3.0
     //In the App.config Add your Connection String and the the name that was use in the base() DataBaseContext.cs Contex folder
     //To Seed the data base with a file record  add  firstName , lastName ,emailAddress,emailType
     //When building the app the code will create the database 
    

        static void Main(string[] args)
        {

          
            string firstName = "C";
            string lastName = "Alas";
            string emailAddress = "C@gmail.com";
            EmailType emailType=EmailType.Personal;
          

            Seed( firstName, lastName, emailAddress,emailType);

        }
        public static void Seed(string vFirstName, string vLastName, string vEmailAddress, EmailType vEmailType)
        {
            DatabaseContext context = new DatabaseContext();


            List<Contact> contacts = new List<Contact> {
            new Contact {FirstName=vFirstName,LastName=vLastName} };
            contacts.ForEach(c => context.Contacts.Add(c));

            List<EmailAddresses> emailAddresses = new List<EmailAddresses> {
            new EmailAddresses{   Email=vEmailAddress,EmailType=vEmailType.ToString()} };
            emailAddresses.ForEach(e => context.EmailAddresses.Add(e));

            context.SaveChanges();

        }

    }
}