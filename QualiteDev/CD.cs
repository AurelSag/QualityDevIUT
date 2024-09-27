namespace QualiteDev;

public class CD : Media
{
    private string artist;
    
    public void AfficherInfos() 
    {
        Console.WriteLine("Artist : " + this.artist);
    }
}