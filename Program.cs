// See https://aka.ms/new-console-template for more information

//TODO: delete this line

using System;
if(args.Count() > 0)
{

Console.WriteLine(args[0]);
if (args[0] == "Imraan")
{
Console.WriteLine("code is working");
Environment.Exit(0);
}
else if (args[0] != "Imraan")
{
Console.WriteLine("ERROR please type in Imraan");
Environment.Exit(0);
}
}

Console.WriteLine("Welcome to the library :)");

Client client1 = new();

Console.WriteLine("What is your name?");
client1.SetName(Console.ReadLine());
Console.WriteLine($"What is your surname: ");
client1.SetSurname(Console.ReadLine());
Console.WriteLine($"What is your age: ");
client1.SetAge(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Person name: {client1.GetName()}");
Console.WriteLine($"Person surname: {client1.GetSurname()}");
Console.WriteLine($"Person age: {client1.GetAge()}");

Console.WriteLine($"Welcome to the library {client1.GetName()}, how can I help today!");



Library library = new Library();
Library movies = new();
while (true)
{
    ListOfOptions();
    //LibraryOptions();

    
    Console.Write("What are you looking for today? ");
    string option = Console.ReadLine();
    if (option.ToUpper() == "ADD BOOK")
    {
        Console.WriteLine($"Welcome to the Add book Section {client1.GetName()}");
        Console.Write("Please enter Add to Add books: ");
        while (true)
        {
            string choice = Console.ReadLine();
            if (choice.ToUpper() == "ADD")
            {
                Book b1 = new();
                Console.Write("Please Add the Bookname of the book: ");
                b1.SetBookName(Console.ReadLine());
                Console.Write("Please Add the author name of the book: ");
                b1.SetAuthor(Console.ReadLine()); ;
                Console.Write("Please enter the amout of book pages: ");
                b1.BookPage = Convert.ToInt32(Console.ReadLine());
                library.AddBook(b1);
            }
            library.PrintList();
            library.FilterBooks();
            break;
        }
    }
    
    else if (option.ToUpper() == "ADD MOVIE")
    {
        Console.WriteLine($"Welcome to the Add movie Section {client1.GetName()}");
        Console.Write("Please enter Add to add movies: ");
        while (true)
        {
            string o = Console.ReadLine();
            if(o.ToUpper() == "ADD")
            {
                Movie m1 = new();
                Console.Write("Please Add the movie year: ");
                m1.ReleaseDate = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Add the movie name: ");
                m1.SetMovieName(Console.ReadLine()); ;
                Console.Write("Please enter the movie Director name: ");
                m1.SetMovieDirector(Console.ReadLine());
                movies.AddMovie(m1);
            }
            library.PrintMovieList();
            library.FilterMovieList();
            break;
        }
    }
    else if (option.ToUpper() == "LIBRARY")
    {
        LibraryOptions();
        /////
        Console.Write("What are you looking for today? ");
        string option2 = Console.ReadLine();
        if (option2.ToUpper() == "BOOKS")
        {
            library.PrintList();
            library.FilterBooks();
            break;
        }
        else if (option2.ToUpper() == "MOVIES")
        {
            Console.WriteLine($"Welcome to the Movie section {client1.GetName()}, how can i help");
            library.PrintMovieList();
            library.FilterMovieList();
            break;
        }
        else if (option2.ToUpper() == "MENU")
        {
            ListOfOptions();

        }
        else if (option2.ToUpper() == "EXIT")
        {
            Console.WriteLine($"Thank you for your visit today {client1.GetName()}, have a good day :)");
            break;
        }
        else // this will appear when the user does not input something correct
        {
            Console.WriteLine("ERROR please select something form the LIST");

        }


        //////

    }
    else
    {
        Console.WriteLine("ERROR please select something form the LIST");
    }
}






//void TheMovieList() // i have created this function to make sure that this fucntion only runs when the usesr wants to
//{

//    {
//        Movie m1 = new();
//        m1.ID = "2013"; // this is the function for the short version of the getter and setters
//        m1.ReleaseDate = 2013;
//        m1.SetMovieName("World War Z");
//        m1.SetMovieDirector("Marc Forster");

//        List<Movie> movies = new() // this is a list now that allows the user to find thier movies
//    {
//        {new Movie("2013", 2013,  "World War Z", "Marc Forster")},
//        {new Movie("2013", 2016,  "Deadpool", "Tim Miller")},

//        {new Movie("2000", 2000,  "X-Men", "Bryan Singer")},
//        {new Movie("2001", 2001,  "Harry Potter and the Philosopher's Stone", "Chris Columbus")},
//        {new Movie("2002", 2002,  "Star Wars: Episode II - Attack of the Clones", "George Lucas")},

//        {new Movie("2003", 2003,  "The Lord of the Rings: The Return of the King ", "Peter Jackson Bloom")},
//        {new Movie("2003", 2003,  "Pirates of the Caribbean: The Curse of the Black Pearl", "Gore Verbinski Knightley")},
//        {new Movie("2004", 2004,  "Troy", "Wolfgang Petersen")},
//        {new Movie("2004", 2004,  "Harry Potter and the Philosopher's Stone", "Chris Columbus")},
//        {new Movie("2005", 2005,  "War of the Worlds", "Steven Spielberg")},

//        {new Movie("2006", 2006,  "Cars", "John Lasseter, Joe Ranft Larry the Cable Guy")},
//        {new Movie("2007", 2007,  "Transformers", "Michael Bay")},
//        {new Movie("2008", 2008,  "The Dark Knight", "Christopher Nolan Michael Caine")},

//        {new Movie("2009", 2009,  "Avatar", "James Cameron Michelle Rodriguez")},
//        {new Movie("2010", 2010,  "Harry Potter and the Deathly Hallows: Part 1", "David Yates")},
//        {new Movie("2011", 2011,  "Captain America: The First Avenger", "Joe Johnston Atwell")},
//    };

//        var ShowList = movies.ToList();
//        foreach (var m in ShowList) Console.WriteLine($"Release Date: {m.ReleaseDate}, Movie Name: {m.GetMovieName()}, Movie Director: {m.GetMovieDirector()}");

//        Console.Write("Please enter a year between 2000 - 2010 for the movie: ");
//        string YearMovie = Console.ReadLine();

//        {
//            var releasedate = movies.Where(i => i.ID.Contains(YearMovie));

//            foreach (var mov in releasedate)
//            {
//                Console.WriteLine($"Movie release date: {mov.ReleaseDate}");
//                Console.WriteLine($"Movie name: {mov.GetMovieName()}");
//                Console.WriteLine($"Movie Director name: {mov.GetMovieDirector()}");

//            }
//        }
//    }

//}

//void TheBookList() // this is the fuction that will only run when the user chooses to do so
//{
//    {

//        Dictionary<string, Book> library = new()

//{
//    {"Animal Farm",                    new Book("Animal Farm", "George Orwell",                       112)},
//    {"All Quiet on the Western Front", new Book("All Quiet on the Western Front", "Erich Maria",      296)},
//    {"Alice in Wonderland",            new Book("Alice in Wonderland", "ane Carruth",                  52)},
//    {"Bag of Bones",                   new Book("Bag of Bones", "Stephen King",                       164)},
//    {"Beach House",                    new Book("Beach House", "James Patterson",                     164)},
//    {"Bearwalker",                     new Book("Beach House", "James Patterson",                     164)},
//    {"Christmas Carol",                new Book("Christmas Carol", "Charls dickens",                  467)},
//    {"Dune",                           new Book("Dune", "Frank herbered",                             800)},
//    {"Easter Island",                  new Book("Easter Island", "Jennifer Vanderbes",                467)},
//    {"Fall of Giants",                 new Book("Fall of Giants", "Ken Follett ",                    1008)},
//    {"Go Tell It on the Mountain",     new Book("Go Tell It on the Mountain", "Jennifer",             565)}, 
//    {"Half A Life",                    new Book("Half A Life", "V.S. Naipaul",                        224)},
//    {"I Refuse",                       new Book("I Refuse", "Per Petterson",                          228)},
//    {"I, Hogarth",                     new Book("I, Hogarth", "Michael Dean",                         272)},
//    {"K Zero",                         new Book("K Zero", "Don DeLillo",                              288)},
//    {"L'Assassin",                     new Book("L'Assassin", "Don DeLillo",                          288)},
//    {"L.A. Weather",                   new Book("L.A. Weather", "María Amparo Escandón",              336)},
//    {"M, King's Bodyguard",            new Book("M, King's Bodyguard", "Niall Leonard",               272)},
//    {"N Is For Noose",                 new Book("N Is For Noose", "Sue Grafton",                      286)},
//    {"O, Africa! ",                    new Book("O, Africa! ", "Andrew Lewis Conn",                   384)},
//    {"Patrick O'Brian",                new Book("Patrick O'Brian", "Dean King",                       400)},
//    {"Philosophy of software design",  new Book("Philosophy of software design", "John ousterhout",   183)},
//    {"Rich Dad, Poor Dad",             new Book("Rich Dad, Poor Dad", "Robert Kiyosaki",              223)},                                                                                                          
//};
//        // this var allows the user to pick a letter that then will display all the books that contain the letter which has been inputted

//        var BookName = library.Values.ToList();
//        foreach (var i in BookName) Console.WriteLine($"Book name: {i.GetBookName()}, Book author: {i.GetAuthor()}, Book page: {i.BookPage}");

//        Console.Write($"Please enter a letter For book: ".ToUpper());
//        string letter = Console.ReadLine();


//            var result = library.Values.Where(i => i.GetBookName()[0].ToString().ToUpper() == letter.ToUpper());

//            foreach (var n in result)
//            {
//                //Console.WriteLine($"Book ID: {n.id}");
//                Console.WriteLine($"Book Name: {n.GetBookName()}");
//                Console.WriteLine($"Book author: {n.GetAuthor()}");
//                Console.WriteLine($"Book Page: {n.BookPage}");
//            }
//    }
//}

void LibraryOptions() // this is the list of options for the user
{
    Console.WriteLine("1) Books");
    Console.WriteLine("2) Movies");
    Console.WriteLine("3) Menu");
    Console.WriteLine("4) Exit");
}

void ListOfOptions()
{
    Console.WriteLine("1) Add Book");
    Console.WriteLine("2) Add Movie");
    Console.WriteLine("3) Library");

}



{
    void clientsList()
    {

        Client client1 = new();
        Dictionary<string, Client> test = new();

        Console.WriteLine("What is your name?");
        client1.SetName(Console.ReadLine());
        Console.WriteLine($"What is your surname: ");
        client1.SetSurname(Console.ReadLine());
        Console.WriteLine($"What is your age: ");
        client1.SetAge(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine($"Person name: {client1.GetName()}");
        Console.WriteLine($"Person surname: {client1.GetSurname()}");
        Console.WriteLine($"Person age: {client1.GetAge()}");

        test.Add(client1.GetName(), client1);

        Console.Write("Please enter a name: ");
        string t = Console.ReadLine();
        if (test.ContainsKey(t))
        {

            Console.WriteLine($"Person name: {client1.GetName()}");
            Console.WriteLine($"Person surname: {client1.GetSurname()}");
            Console.WriteLine($"Person age: {client1.GetAge()}");
        }
    }
}