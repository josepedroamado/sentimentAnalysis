using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Author
    {
        public static int NextId = 1;

        public int EntityId { get; set; }

        public String UserName { get; set; }

        public String Name { get; set; }

        public String LastName { get; set; }

        public DateTime BirthDate { get; set; }

        private const int MAX_UserName_TEXT = 15;

        private const int MAX_Name_TEXT = 10;

        private const int MAX_LastName_TEXT = 10;

        private const int Min_Name_TEXT = 0;

        private const int Min_Age = 13;

        private const int Max_Age = 100;

        public Author(String aUserName, String aName, String aLastName, DateTime birthDate)
        {
            AssignId();
            this.Name = SetText(aName, MAX_Name_TEXT, Min_Name_TEXT);
            this.UserName = SetText(aUserName, MAX_UserName_TEXT, Min_Name_TEXT);
            this.LastName = SetText(aLastName, MAX_LastName_TEXT, Min_Name_TEXT);
            IsAgeOkay(birthDate);
            this.BirthDate = birthDate;
        }

        private String SetText(String aText, int max, int min)
        {
            IsTextLenghtOkay(aText, max, min);
            return aText;
        }
        private bool IsTextLenghtOkay(String aName, int max, int Min)
        {
            TooLong(aName, MAX_Name_TEXT);
            TooShort(aName, Min_Name_TEXT);
            return true;
        }
        private void TooLong(String aText, int aLength)
        {
            if(aText.Length > aLength)
            {
                throw new TextTooLongException(aLength);
            }
        }
        private void TooShort(String aText, int aLength)
        {
            if (aText.Length <= aLength)
            {
                throw new TextTooShortException(aLength);
            }
        }

        public int GetNextId()
        {
            return NextId;
        }

        private void AssignId()
        {
            this.EntityId = NextId;
            NextId++;
        }
        private void IsAgeOkay(DateTime birthdate)
        {
            int age = GetAge(birthdate);
            if(age < Min_Age)
            {
                throw new AgeTooShortException(Min_Age);
            }
            if (age > Max_Age)
            {
                throw new AgeTooLongException(Max_Age);
            }
        }
        private int GetAge (DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
