using System;

namespace BusinessLogic
{
    public class Author
    {
        public Guid AuthorId { get; set; }

        public String UserName { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime BirthDate { get; set; }

        private const int MIN_USERNAME_TEXT = 0;
        private const int MAX_USERNAME_TEXT = 10;
        private const int MIN_FIRSTNAME_TEXT = 0;
        private const int MAX_FIRSTNAME_TEXT = 15;
        private const int MIN_LASTNAME_TEXT = 0;
        private const int MAX_LASTNAME_TEXT = 15;
        private const int MIN_AGE = 13;
        private const int MAX_AGE = 100;

        public Author(String aUserName, String aFirstName, String aLastName, DateTime aBirthDate)
        {
            AuthorId = Guid.NewGuid();
            UserName = VerifyText(aUserName, MAX_USERNAME_TEXT, MIN_USERNAME_TEXT);
            FirstName = VerifyText(aFirstName, MAX_FIRSTNAME_TEXT, MIN_FIRSTNAME_TEXT);
            LastName = VerifyText(aLastName, MAX_LASTNAME_TEXT, MIN_LASTNAME_TEXT);
            VerifyAge(aBirthDate);
            BirthDate = aBirthDate;
        }

        private String VerifyText(String text, int max, int min)
        {
            VerifyTextLength(text, max, min);
            return text;
        }

        private bool VerifyTextLength(String text, int max, int min)
        {
            VerifyTextTooLong(text, max);
            VerifyTextTooShort(text, min);
            return true;
        }

        private void VerifyTextTooLong(String text, int length)
        {
            if(text.Length > length)
            {
                throw new TextTooLongException(length);
            }
        }
        private void VerifyTextTooShort(String text, int length)
        {
            if (text.Length <= length)
            {
                throw new TextTooShortException(length);
            }
        }

        private void VerifyAge(DateTime birthdate)
        {
            int age = CalculateAge(birthdate);
            if(age < MIN_AGE)
            {
                throw new TooYoungException(MIN_AGE);
            }
            if (age > MAX_AGE)
            {
                throw new TooOldException(MAX_AGE);
            }
        }

        public int CalculateAge (DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            int birthMonth = birthdate.Month;
            int birthDay = birthdate.Day;
            if (birthMonth > today.Month)
            {
                age--;
            }
            else if(birthMonth == today.Month)
            {
                if (birthDay > today.Day)
                {
                    age--;
                }
            }
            return age;
        }

        public override bool Equals(object obj)
        {
            Author author = obj as Author;
            if (author != null) return UserName == author.UserName;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.UserName.GetHashCode();
        }
    }
}
