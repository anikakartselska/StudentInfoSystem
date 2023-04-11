using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public int studentId;
        public string Ime;
        public string Prezime;
        public string Familia;
        public string Faklutet;
        public string Specialnost;
        public string ObrazovatelnoKvalifikacionnaStepen;
        public string Status;
        public string FaklutetenNomer;
        public int Kurs;
        public int Potok;
        public int Grupa;
        public byte[] image;

        public byte[] Image
        {
            get => image;
            set { image = value; }
        }

        public int StudentId
        {
            get => studentId;
            set => studentId = value;
        }

        public string Ime1
        {
            get => Ime;
            set => Ime = value;
        }

        public string Prezime1
        {
            get => Prezime;
            set => Prezime = value;
        }

        public string Familia1
        {
            get => Familia;
            set => Familia = value;
        }

        public string Faklutet1
        {
            get => Faklutet;
            set => Faklutet = value;
        }

        public string Specialnost1
        {
            get => Specialnost;
            set => Specialnost = value;
        }

        public string ObrazovatelnoKvalifikacionnaStepen1
        {
            get => ObrazovatelnoKvalifikacionnaStepen;
            set => ObrazovatelnoKvalifikacionnaStepen = value;
        }

        public string Status1
        {
            get => Status;
            set => Status = value;
        }

        public string FaklutetenNomer1
        {
            get => FaklutetenNomer;
            set => FaklutetenNomer = value;
        }

        public int Kurs1
        {
            get => Kurs;
            set => Kurs = value;
        }

        public int Potok1
        {
            get => Potok;
            set => Potok = value;
        }

        public int Grupa1
        {
            get => Grupa;
            set => Grupa = value;
        }

        public Student(string ime, string prezime, string familia, string faklutet, string specialnost, string obrazovatelnoKvalifikacionnaStepen, string status, string faklutetenNomer, int kurs, int potok, int grupa)
        {
            Ime = ime;
            Prezime = prezime;
            Familia = familia;
            Faklutet = faklutet;
            Specialnost = specialnost;
            ObrazovatelnoKvalifikacionnaStepen = obrazovatelnoKvalifikacionnaStepen;
            Status = status;
            FaklutetenNomer = faklutetenNomer;
            Kurs = kurs;
            Potok = potok;
            Grupa = grupa;
        }
        public Student()
        {
           
        }
    }
}
