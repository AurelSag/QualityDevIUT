namespace QualiteDev;

public class Book : Media
{
    private string author;

    public void AfficherInfos() 
    {
        Console.WriteLine("Author : " + this.author);
    }
}