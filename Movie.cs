public class Movie
{
    private string id;
    private int releasedate;
    private string moviename;
    private string moviedirector;

    public Movie(string id, int releasedate, string moviename, string moviedirector)
    {
        this.id = id;
        this.releasedate = releasedate;
        this.moviename = moviename;
        this.moviedirector = moviedirector;
    }

    public Movie()
    {
        // this is an empty constructor
        // this allows me to use and create my own objects
    }
    public Movie(Movie other)
    {
        id = other.id;
        releasedate = other.releasedate;
        moviename = other.moviename;
        moviedirector = other.moviedirector;
    }

    public void SetId(string id)
    {
        this.id = id;
    }

    public string GetId()
    {
        return this.id;
    }

    public string ID // this is the shorter version of getter and setter
    {
        set { id = value; }
        get { return id; }
    }

    public int ReleaseDate
    {
        set { releasedate = value; }
        get { return releasedate; }
    }

    public void SetMovieName(string moviename)
    {
        this.moviename = moviename;
    }
    public string GetMovieName()
    {
        return moviename;
    }

    public void SetMovieDirector(string moviedirector)
    {
        this.moviedirector = moviedirector;
    }
    public string GetMovieDirector()
    {
        return moviedirector;
    }

    
}