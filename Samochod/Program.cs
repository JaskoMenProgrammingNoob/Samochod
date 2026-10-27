using System.Runtime.InteropServices.Java;

class Samochod
{
    public string Marka { get; set; }
        public int rokProdukcji { get; set; }


    public Samochod()
    {
        ustawDane("Toyota", 2020);
    }
    public Samochod(string marka, int rokprodukcji)
    {
        ustawDane(marka, rokprodukcji);
    }

    public void ustawDane(string Marka, int rokProdukcji)
    {
        this.Marka = Marka;
        this.rokProdukcji = rokProdukcji;
    }

    
        public void wyswietl()
    {
        Console.WriteLine($"Samochó marki {Marka}, rok produkcji {rokProdukcji}");
    }
    
    static void Main(string[] args)
    {
        Samochod samochod1 = new Samochod();
        Samochod samochod2 = new Samochod("BMW", 2023);
        samochod1.wyswietl();
        samochod2.wyswietl();
        
        

    }
}