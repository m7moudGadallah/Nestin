using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestin.Core.Dtos.UserProfilesDto
{
    public class UserprofileEditDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Bio { get; set; }
        public DateOnly BirthDate { get; set; }
     
        public int CountryId { get; set; }
        public string PhotoId { get; set; }
    }
}
