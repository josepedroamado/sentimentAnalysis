using System;

namespace DataAccess
{
    public class AuthorDto
    {
        public Guid AuthorDtoId { get; set; }

        public String UserName { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
