public class Spelare
{
    private string _namn;
    private int _nummer;
    private string _position;

    public string Namn
    {
      get { return _namn;}    
      private set { _namn = value;}
    }
 
    public int Nummer
    {
       get {return _nummer;}     
       private set { _nummer = value; }
    }

    public string Position
    {
       get {return _position;}  
       private set { _position = value;} 
    }

    
    public Spelare(string namn, int nummer, string position)
    {
      _namn = namn;
      _nummer = nummer;
      _position = position;
    }
}
