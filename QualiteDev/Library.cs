namespace QualiteDev;

public class Library
{
    private List<Media> medias = new List<Media>();
    
    private List<Borrowing> borrowings = new List<Borrowing>();

    public Media this[int refNumber]
    {
        get => medias[refNumber];
        set => medias[refNumber] = value;
    }
    
    
    
    public void Add(Media media)
    {
        medias.Add(media);
    }
    
    public void Remove(int refNumber)
    {
        medias.RemoveAt(refNumber);
    }
    
    public void Borrow(int refNumber, string user)
    {
        if (medias[refNumber].IsAvailable())
        {
            medias[refNumber].TotalAvailable--;
            borrowings.Add(new Borrowing(medias[refNumber], user));
        }
    }
    
    public void Return(Borrowing borrowing)
    {
        int refNumber = borrowing.Media.RefNumber;
        medias[refNumber].TotalAvailable++;
        borrowings.RemoveAll(borrowing => borrowing.Media == medias[refNumber] && borrowing.User == borrowings);
    }

    public List<Media> Search(string title)
    {
        return medias.Where(media => media.Title == title).ToList();
    }
}