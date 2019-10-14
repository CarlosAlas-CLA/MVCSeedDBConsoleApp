using System.Collections.Generic;

namespace ContactSInformation

{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<EmailAddresses> EmailAddresses { get; set; }
    }
}
