using System;

namespace CSh_Lab_7
{
    public class Person
    {
        #region Variables
        private string name;
        private string lastName;
        private DateTime bday;
        #endregion
        #region Constructors
        public Person()
        {
            name = "NoName";
            lastName = "NoLastName";
            bday = new DateTime();
        }
        public Person(string name, string lastName, DateTime bday)
        {
            this.name = name;
            this.lastName = lastName;
            this.bday = bday;
        }
        #endregion
        #region Properties
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }
        public DateTime Bday
        {
            get { return this.bday; }
            private set { this.bday = value; }
        }
        public int YearChanger
        {
            get { return Bday.Year; }
            set { this.Bday = new DateTime(value, this.Bday.Month, this.Bday.Day); }
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            string personProperties = Name + " " + LastName + " " + Convert.ToString(Bday);
            return personProperties;
        }
        public string ToShortString()
        {
            string personProperties = Name + " " + LastName;
            return personProperties;
        }
        #endregion
    }
}