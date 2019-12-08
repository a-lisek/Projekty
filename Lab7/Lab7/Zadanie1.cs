using System;
namespace Lab7
{
    public class Zadanie1
    {
        public void Wyw1()
        {
            Auto A1 = new Auto(typ:"Typ1", marka:"Marka1", imienazwisko:"Jan Kowalski", lpktk:6);
            Auto A2 = new Auto(typ: "Typ2", marka: "Marka2", imienazwisko: "Anna Kowalska", lpktk: 9);
            Auto A3 = new Auto(typ: "Typ1", marka: "Marka2", imienazwisko: "Anna Nowak", lpktk: 0);
            Auto A4 = new Auto(typ: "Typ3", marka: "Marka1", imienazwisko: "Jan Nowak", lpktk: 3);

            Console.WriteLine("Auto 1");
            A1.GetICepikData();
            A1.GetIStatData();
            A1.GetIPoliceData();

            Console.WriteLine("Auto 2");
            A2.GetICepikData();
            A2.GetIStatData();
            A2.GetIPoliceData();

            Console.WriteLine("Auto 3");
            A3.GetICepikData();
            A3.GetIStatData();
            A3.GetIPoliceData();

            Console.WriteLine("Auto 4");
            A4.GetICepikData();
            A4.GetIStatData();
            A4.GetIPoliceData();
        }

    }
    interface ICepikData
    {
        void GetICepikData();
    }
    interface IStatData
    {
        void GetIStatData();
    }
    interface IPoliceData
    {
        void GetIPoliceData();
    }
    public class Auto: ICepikData, IStatData, IPoliceData
    {
        string _typ;
        string _marka;
        int _pojemnosc;
        int _liczba_miejsc;
        int _vin;
        int _nr_rej;
        int _rok_prod;
        string _kolor;
        int _nr_pol;

        string _imie_nazwisko;
        string _adres;
        int _pesel;
        int _nr_prawa_jazdy;
        int _data;
        int _rok_Zakupu;
        int _l_pkt_k;

        public Auto(string typ="", string marka="", int pojemnosc=0, int liczba_miejsc=0, int vin=0, int nr_rej=0, int rok_prod=0, string kolor="", int nr_pol=0, string adres="", string imienazwisko="", int pesel=0, int nrprja=0, int data=0, int rok=0, int lpktk=0 )
        {
            _typ=typ;
            _marka=marka;
            _pojemnosc= pojemnosc;
            _liczba_miejsc= liczba_miejsc;
            _vin= vin;
            _nr_rej= nr_rej;
            _rok_prod= rok_prod;
            _kolor= kolor;
            _nr_pol= nr_pol;
            _imie_nazwisko= imienazwisko;
            _adres =adres;
            _pesel =pesel;
            _nr_prawa_jazdy=nrprja;
            _data=data;
            _rok_Zakupu=rok;
            _l_pkt_k=lpktk;

        }

     

        public void GetICepikData()
        {
            Console.WriteLine("Typ: {0}, Marka: {1}, Imie i Nazwisko: {2}",this._typ,this._marka,this._imie_nazwisko);
        }
        public void GetIStatData()
        {
            Console.WriteLine("Typ: {0}, Marka: {1}", this._typ, this._marka);
        }
        public void GetIPoliceData()
        {
            Console.WriteLine("Typ: {0}, Marka: {1}, Imie i Nazwisko: {2}, Punkty karne {3}", this._typ, this._marka, this._imie_nazwisko, this._l_pkt_k);
        }
    }
}
