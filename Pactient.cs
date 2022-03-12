using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalForms
{
    static class ListPactient
    {
       static public List<Pactient> Pactients=new List<Pactient>();
        static public int ActiveId = -1;
    }
    class Pactient
    {
        static int id = 0;
        public Pactient(string Name, string SecondName,DateTime DateofBirth, bool Sex, string Information, string History,string PathPhoto)
        {
            this.PathPhoto = PathPhoto;
            this.Name = Name;
            this.SecondName = SecondName;
            this.Sex = Sex;
            this.DateofBirth = (DateofBirth.Year.ToString() + ":" + DateofBirth.Month.ToString() + ":" + DateofBirth.Day.ToString()) ;
            this.Information = Information;
            this.History = History;
            Id = id;
            id++;
        }
        public string PathPhoto { get; set; }
        public string DateofBirth { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Information { get; set; }
        public string History { get; set; }
        public bool Sex { get; set; }
        public int Id { get; set; }

    }
}
