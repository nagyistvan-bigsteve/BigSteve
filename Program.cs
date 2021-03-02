using System;

namespace Tema_oras
{
    public class Oras {
        public Primar primar;
        public Scoala[] scoala;
        public Masina[] masina;
        public Park[] park;
        public Locuitor[] locuitor;
        public String nume;
        public Oras(String nume, Primar primar, Locuitor[] locuitor, Scoala[] scoala, Masina[] masina, Park[] park)
        {
            this.primar = primar;
            this.scoala = scoala;
            this.masina = masina;
            this.park = park;
            this.nume = nume;
            this.locuitor = locuitor;
        }
        public String toString()
        {
            return "Orasul: " + nume + " ,primarul este " + primar.toString();

        }
       public void Masinii()
        { for (int i = 0; i < masina.Length; i++)
                Console.WriteLine(masina[i].toString() + ", ");
        }
        public void Locuitori()
        {
            for (int i = 0; i < locuitor.Length; i++)
                Console.WriteLine(locuitor[i].toString() + ", ");
        }
        public void Scolii()
        {
            for (int i = 0; i < scoala.Length; i++)
                Console.WriteLine(scoala[i].toString() + ", ");
        }
        public void Parkuri()
        {
            for (int i = 0; i < park.Length; i++)
                Console.WriteLine(park[i].toString() + ", ");
        }

    }
    public class Locuitor
    {
        private String nume;
        private int cnp;
        public Locuitor(String nume, int cnp)
        {
            this.nume = nume;
            this.cnp = cnp;
        }
        public String GetNume()
        {
            return nume;
        }
        public String toString()
        {
            return GetNume()+" - cnp: "+cnp;
        }

    }

    public class Primar
    {
        Locuitor primar;
        public Primar(Locuitor primar)
        {
            this.primar = primar;
        }
        public String GetNume()
        {
            return primar.GetNume();
        }
        public String toString()
        {
            return GetNume();
        }

    }

    public class Scoala
    { private String nume;
        private int nrStudenti;
        private int nrProfesori;
        public Scoala(String nume,int nrStudenti, int nrProfesori)
        {
            this.nume = nume;
            this.nrProfesori = nrProfesori;
            this.nrStudenti = nrStudenti;
        }
        public String toString()
        {
            return "Scoala: "+nume+" are: "+nrStudenti+" de student, si "+nrProfesori+" de profesori";
        }
    }

    public class Masina
    {
        private String nrInmatriculare;
        private Locuitor utilizator;
        public Masina(String nrInmatriculare, Locuitor utilizator)
        {
            this.nrInmatriculare = nrInmatriculare;
            this.utilizator = utilizator;
        }
        public String toString()
        {
            return "Masina: "+nrInmatriculare + " - utilizatorul: " + utilizator.toString(); ;
        }
    }

    public class Park
    {
        private int aria;
        private String nume;
        public Park(String nume, int aria)
        {
            this.aria = aria;
            this.nume = nume;
        }
        public String toString()
        {
            return "Parkul: " + nume + " - aria: " + aria ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Locuitor locuitor1 = new Locuitor("Gutu",1234567);
            Locuitor locuitor2 = new Locuitor("Maria", 1234568);
            Locuitor locuitor3 = new Locuitor("Andrei", 1234569);
            Locuitor[] l1 = new Locuitor[] { locuitor1, locuitor2, locuitor3 };

            Primar primar1 = new Primar(locuitor1);
            
            Scoala scoala1 = new Scoala("Emanuel", 500, 40);
            Scoala scoala2 = new Scoala("Eminescu", 2000, 70);
            Scoala[] s1 = new Scoala[] { scoala1, scoala2 };

            Masina masina1 = new Masina("SJ77SDG", locuitor1);
            Masina masina2 = new Masina("SJ99SDG", locuitor1);
            Masina masina3 = new Masina("SJ66SDG", locuitor2);
            Masina masina4 = new Masina("SJ88SDG", locuitor3);
            Masina[] m1 = new Masina[] { masina1, masina2,masina3,masina4 };

            Park park1 = new Park("sf.Gheorge", 500);
            Park[] p1 = new Park[] { park1};

            Oras oras1 = new Oras("Orade", primar1,l1, s1,  m1 , p1);
            Console.WriteLine(oras1.toString());
            oras1.Masinii();
            oras1.Locuitori();
            oras1.Scolii();
            oras1.Parkuri();

        }
    }

}
