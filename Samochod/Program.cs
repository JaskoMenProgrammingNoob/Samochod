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

    public void ustawDane(string marka, int rokprodukcji)
    {
        Marka = marka;
        rokProdukcji = rokprodukcji;
    }

    
     
    
    static void Main(string[] args)
    {
        Samochod samochod1 = new Samochod();
        Samochod samochod2 = new Samochod("BMW", 2023);
        
        Console.WriteLine($"Samochód marki {samochod1.Marka}, rok produkcji {samochod1.rokProdukcji}");
        Console.WriteLine($"Samochód marki {samochod2.Marka}, rok produkcji {samochod2.rokProdukcji}");



    }
}