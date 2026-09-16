public class Match
{

    
    public string Hemmalag { get; private set; }

    public string Bortalag { get; private set; }
  
    public string Datum { get; private set; }
    
    public Match(string hemmalag, string bortalag, string datum)
    {
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine($"Dagens match är mellan {Hemmalag} och {Bortalag} idag den {Datum}");
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine($"Idag spelar dessutom {spelare.Namn} med nummer {spelare.Nummer} på position {spelare.Position}");
    }
}
