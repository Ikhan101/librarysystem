class Library
{
    Dictionary<string, Book> library;
    List<Movie> movies;

    public Library()
    {
        LoadFromFile();
        LoadFromFileMovies();
    }

    public void LoadFromFile()
    {
        library = new Dictionary<string, Book>()
        {
    {"Animal Farm",                    new Book("Animal Farm", "George Orwell",                       112)},
    {"All Quiet on the Western Front", new Book("All Quiet on the Western Front", "Erich Maria",      296)},
    {"Alice in Wonderland",            new Book("Alice in Wonderland", "ane Carruth",                  52)},
    {"Bag of Bones",                   new Book("Bag of Bones", "Stephen King",                       164)},
    {"Beach House",                    new Book("Beach House", "James Patterson",                     164)},
    {"Bearwalker",                     new Book("Beach House", "James Patterson",                     164)},
    {"Christmas Carol",                new Book("Christmas Carol", "Charls dickens",                  467)},
    {"Dune",                           new Book("Dune", "Frank herbered",                             800)},
    {"Easter Island",                  new Book("Easter Island", "Jennifer Vanderbes",                467)},
    {"Fall of Giants",                 new Book("Fall of Giants", "Ken Follett ",                    1008)},
    {"Go Tell It on the Mountain",     new Book("Go Tell It on the Mountain", "Jennifer",             565)},
    {"Half A Life",                    new Book("Half A Life", "V.S. Naipaul",                        224)},
    {"I Refuse",                       new Book("I Refuse", "Per Petterson",                          228)},
    {"I, Hogarth",                     new Book("I, Hogarth", "Michael Dean",                         272)},
    {"K Zero",                         new Book("K Zero", "Don DeLillo",                              288)},
    {"L'Assassin",                     new Book("L'Assassin", "Don DeLillo",                          288)},
    {"L.A. Weather",                   new Book("L.A. Weather", "María Amparo Escandón",              336)},
    {"M, King's Bodyguard",            new Book("M, King's Bodyguard", "Niall Leonard",               272)},
    {"N Is For Noose",                 new Book("N Is For Noose", "Sue Grafton",                      286)},
    {"O, Africa! ",                    new Book("O, Africa! ", "Andrew Lewis Conn",                   384)},
    {"Patrick O'Brian",                new Book("Patrick O'Brian", "Dean King",                       400)},
    {"Philosophy of software design",  new Book("Philosophy of software design", "John ousterhout",   183)},
    {"Rich Dad, Poor Dad",             new Book("Rich Dad, Poor Dad", "Robert Kiyosaki",              223)},
        };                                                                                                           
    }

    public void PrintList()
    {
        var BookName = library.Values.ToList();
        foreach (var i in BookName) Console.WriteLine($"Book name: {i.GetBookName()}, Book author: {i.GetAuthor()}," +
            $" Book page: {i.BookPage}");
    }

    public void FilterBooks()
    {

        Console.Write($"Please enter a letter For book: ".ToUpper());
        string letter = Console.ReadLine();


        var result = library.Values.Where(i => i.GetBookName()[0].ToString().ToUpper() == letter.ToUpper());

        foreach (var n in result)
        {
            //Console.WriteLine($"Book ID: {n.id}");
            Console.WriteLine($"Book Name: {n.GetBookName()}");
            Console.WriteLine($"Book author: {n.GetAuthor()}");
            Console.WriteLine($"Book Page: {n.BookPage}");
        }
    }
    public void AddBook(Book book) // this can be anything
    {
        library.Add(book.GetBookName(), book);
    }




    public void LoadFromFileMovies()
    {
    movies = new()// this is a list now that allows the user to find thier movies
    {
        {new Movie("2013", 2013,  "World War Z", "Marc Forster")},
        {new Movie("2013", 2016,  "Deadpool", "Tim Miller")},

        {new Movie("2000", 2000,  "X-Men", "Bryan Singer")},
        {new Movie("2001", 2001,  "Harry Potter and the Philosopher's Stone", "Chris Columbus")},
        {new Movie("2002", 2002,  "Star Wars: Episode II - Attack of the Clones", "George Lucas")},

        {new Movie("2003", 2003,  "The Lord of the Rings: The Return of the King ", "Peter Jackson Bloom")},
        {new Movie("2003", 2003,  "Pirates of the Caribbean: The Curse of the Black Pearl", "Gore Verbinski Knightley")},
        {new Movie("2004", 2004,  "Troy", "Wolfgang Petersen")},
        {new Movie("2004", 2004,  "Harry Potter and the Philosopher's Stone", "Chris Columbus")},
        {new Movie("2005", 2005,  "War of the Worlds", "Steven Spielberg")},

        {new Movie("2006", 2006,  "Cars", "John Lasseter, Joe Ranft Larry the Cable Guy")},
        {new Movie("2007", 2007,  "Transformers", "Michael Bay")},
        {new Movie("2008", 2008,  "The Dark Knight", "Christopher Nolan Michael Caine")},

        {new Movie("2009", 2009,  "Avatar", "James Cameron Michelle Rodriguez")},
        {new Movie("2010", 2010,  "Harry Potter and the Deathly Hallows: Part 1", "David Yates")},
        {new Movie("2011", 2011,  "Captain America: The First Avenger", "Joe Johnston Atwell")},
    };
    }

    public void PrintMovieList()
    {
        var ShowList = movies.ToList();
        foreach (var m in ShowList) Console.WriteLine($"Release Date: {m.ReleaseDate}, Movie Name: {m.GetMovieName()}," +
            $" Movie Director: {m.GetMovieDirector()}");
    }

    public void FilterMovieList()
    {
        Console.Write("Please enter a year between 2000 - 2010 for the movie: ");
        string YearMovie = Console.ReadLine();

        {
            var releasedate = movies.Where(i => i.ID.Contains(YearMovie));

            foreach (var mov in releasedate)
            {
                Console.WriteLine($"Movie release date: {mov.ReleaseDate}");
                Console.WriteLine($"Movie name: {mov.GetMovieName()}");
                Console.WriteLine($"Movie Director name: {mov.GetMovieDirector()}");

            }
        }
    }
    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }



}


