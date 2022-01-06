using System;

namespace CSh_Lab_7
{
    class Paper
    {
        //Поля
        string nameOfPublication;
        Person author;
        DateTime dateOfPublication;

        // Свойства
        public string NameOfPublication { get; set; }
        public Person Author { get; set; }
        public DateTime DateOfPublication { get; set; }

        //Конструкторы
        public Paper(string nameOfPublication, Person author, DateTime dateOfPublication)
        {
            this.nameOfPublication = nameOfPublication;
            this.author = author;
            this.dateOfPublication = dateOfPublication;
        }
        public Paper()
        {
            this.nameOfPublication = "No Name";
            this.author = new Person();
            this.dateOfPublication = new DateTime();
        }

        //Методы
        public override string ToString()
        {
            string paperProperties = NameOfPublication + author.ToString() + DateOfPublication;
            return paperProperties;
        }
    }
}
