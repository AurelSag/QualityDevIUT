namespace QualiteDev;

public class Borrowing
{
    private static int nextId = 0;
    
    private int id;
    
    private Media media;

    private string user;
    
    public Borrowing(Media media, string user)
    {
        this.id = nextId++;
        this.media = media;
        this.user = user;
    }
    
    public Media Media => Media;

    public string User => user;
}