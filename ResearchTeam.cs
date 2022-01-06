using System;
using System.Collections.Generic;
using System.Text;

namespace CSh_Lab_7
{
    public enum TimeFrame
    {
        Year,
        TwoYears,
        Long,
    }
    class ResearchTeam
    {
        //Поля
        private string topic;
        private string nameOfOrganization;
        private int regNum;
        private TimeFrame durationOfResearch;
        private Paper[] listOfPublications;

        //Конструкторы
        public ResearchTeam(string topic, string nameOfOrganization, int regNum, TimeFrame durationOfResearch)
        {
            this.topic = topic;
            this.nameOfOrganization = nameOfOrganization;
            this.regNum = regNum;
            this.durationOfResearch = durationOfResearch;
        }
        public ResearchTeam()
        {
            this.topic = "Empty";
            this.nameOfOrganization = "Empty";
            this.regNum = 0;
            this.durationOfResearch = new TimeFrame();
        }

        //Свойства
        public string Topic
        {
            get { return topic; }
            private set { this.topic = value; }
        }
        public string NameOfOrganization
        {
            get { return nameOfOrganization; }
            private set { this.nameOfOrganization = value; }
        }
        public int RegNum
        {
            get { return regNum; }
            private set { this.regNum = value; }
        }
        public TimeFrame DurationOfResearch
        {
            get { return durationOfResearch; }
            private set { this.durationOfResearch = value; }
        }
        public Paper[] ListOfPublications
        {
            get { return listOfPublications; }
            private set { ListOfPublications = value; }
        }
        public Paper LastPublication
        {
            get { return listOfPublications[listOfPublications.Length-1]; }
        }
        //Индексаторы
        public bool this[TimeFrame i] { get { return true; } }
        //Методы
        public void AddPapers(params Paper[] somePaper)
        {
            if (ListOfPublications == null)
            {
                ListOfPublications = somePaper;
            }
            else
            {
                Paper[] newArr = new Paper[ListOfPublications.Length + somePaper.Length];
                Array.Copy(ListOfPublications, newArr, ListOfPublications.Length);
                Array.Copy(somePaper, 0, newArr, ListOfPublications.Length, somePaper.Length);
                ListOfPublications = newArr;
            }

        }
        public override string ToString()
        {
            string RTProperties = Topic + " " + NameOfOrganization + " " + RegNum + " " + DurationOfResearch + " " + ListOfPublications;
            return RTProperties;
        }
        public string ToShortString()
        {
            string RTProperties = Topic + " " + NameOfOrganization + " " + RegNum + " " + DurationOfResearch;
            return RTProperties;
        }
    }
}
