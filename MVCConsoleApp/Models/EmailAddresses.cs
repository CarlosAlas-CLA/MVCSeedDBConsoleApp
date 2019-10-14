using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactSInformation
{
    public class EmailAddresses
    {

        [Key]
        public int EmailID { get; set; }


        [EmailAddress]
        public string Email{ get; set; }
        public string  EmailType { get; set; }
       [ForeignKey("Contact")]
        public int ContactID { get; set; }
        public Contact Contact { get; set; }
    }
    public enum EmailType
    {
        Personal, Business
    }
}