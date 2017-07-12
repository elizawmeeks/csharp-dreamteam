using System;
using System.Collections.Generic;

namespace dreamteam
{
    public interface ICohort {

        string Specialty { get; set; }
        string FirstName { get; set; }
        string LastName{ get; set; }
        string FullName { get; }
       void Work();
    }

    class Eliza : ICohort
    {
        public string Specialty { get => "C#"; set => Specialty = value; }
        public string FirstName { get => "Eliza"; set => FirstName = value; }
        public string LastName { get => "Meeks"; set => LastName = value; }

        public string FullName {get => FirstName + " " + LastName;}

        public void Work()
        {
            Console.WriteLine("Eliza gets stuff done and is sometimes nice and sometimes fun.");
        }
    }

    class Chaz : ICohort
    {
        public string Specialty { get => "C#"; set => Specialty = value; }
        public string FirstName { get => "Chaz"; set => FirstName = value; }
        public string LastName { get => "Henricks"; set => LastName = value; }

        public string FullName {get => FirstName + " " + LastName;}

        public void Work()
        {
            Console.WriteLine("Chaz is p helpful and wears lots of hats.");
        }
    }

    public class Jackie : ICohort
    {
        public string Specialty { get => "C#"; set => Specialty = value; }
        public string FirstName { get => "Jackie"; set => FirstName = value; }
        public string LastName { get => "Knight"; set => LastName = value; }

        public string FullName {get => FirstName + " " + LastName;}

        public void Work()
        {
            Console.WriteLine("Jackie eats Cheetos for breakfast and chops hair. NEVER USE TABLES!!!");
        }
    }

    public class Madeline : ICohort
    {
        public string Specialty { get => "CSS"; set => Specialty = value; }
        public string FirstName { get => "Madeline"; set => FirstName = value; }
        public string LastName { get => "Power"; set => LastName = value; }

        public string FullName {get => FirstName + " " + LastName;}

        public void Work()
        {
            Console.WriteLine("Madeline kicks ass and never brushes her hair.");
        }
    }

    public class Kathy : ICohort
    {
        public string Specialty { get => "HTML"; set => Specialty = value; }
        public string FirstName { get => "Kathy"; set => FirstName = value; }
        public string LastName { get => "Weisensal"; set => LastName = value; }

        public string FullName {get => FirstName + " " + LastName;}

        public void Work()
        {
            Console.WriteLine("Kathy will have none of your shit and if you have a problem with that it is only your problem.");
        }
    }

    public class Tamela : ICohort
    {
        public string Specialty { get => "HTML"; set => Specialty = value; }
        public string FirstName { get => "Tamela"; set => FirstName = value; }
        public string LastName { get => "Lerma"; set => LastName = value; }

        public string FullName {get => FirstName + " " + LastName;}

        public void Work()
        {
            Console.WriteLine("Tamela will support you as long as she can get some vodka and cigs in on the side.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You got this, girl!!");

            Eliza eliza = new Eliza();
            Chaz chaz = new Chaz();
            Jackie jackie = new Jackie();
            Kathy kathy = new Kathy();
            Tamela tamela = new Tamela();
            Madeline madeline = new Madeline();

            List<ICohort> serverSide = new List<ICohort>{
                eliza, chaz, jackie
            };

            List<ICohort> clientSide = new List<ICohort>{
                kathy, tamela, madeline
            };

            foreach (var gal in serverSide){
                gal.Work();
            }

            foreach (var gal in clientSide){
                gal.Work();
            }
        }
    }
}
