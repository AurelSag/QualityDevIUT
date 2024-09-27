namespace QualiteDev;

public class Media
{
    private string title;

    private int refNumber;

    private int totalAvailable;
    

    public bool IsAvailable()
    {
        return totalAvailable > 0;
    }

    public int TotalAvailable
    {
        get => totalAvailable;
        set => totalAvailable = value;
    }

    public string Title => title;
    
    public int RefNumber => refNumber;
}