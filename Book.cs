public class Book
{
   // public string id;
    private string bookname;
    private string author;
    private int bookpage;


    public Book(string bookname, string author, int bookpage)
    {
        this.bookname = bookname;
        this.author = author;
        this.bookpage = bookpage;
        
    }


    public Book()
    {

    }


    public void SetBookName(string bookname)
    {
        this.bookname = bookname;
    }
    public string GetBookName()
    {
        return this.bookname;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }
    public string GetAuthor()
    {
        return this.author;
    }

    public int BookPage // this is the short cut of doing getters and setters
    {
        set {
            if(value <= 0)
            {
                Console.WriteLine("invalid book page");
                bookpage = 1;
            }
            else
            {
                bookpage = value; }
            }
        get { return bookpage; }
    }



   
}