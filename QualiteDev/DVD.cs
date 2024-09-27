namespace QualiteDev;

public class DVD : Media
{
    private int length;
    
    public void AfficherInfos() 
    {
        Console.WriteLine("Length : " + this.length);
    }
}