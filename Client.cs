public class Client
{
    private string Name;
    private string Surname;
    private int age;

    public Client(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.age = age;
    }

    public Client()
    {
        // this is an empty constructor
    }

    public void SetName(string name)
    {
        this.Name = name;
    }
    public string GetName()
    {
        return this.Name;
    }

    public void SetSurname(string surname)
    {
        this.Surname = surname;
    }
    public string GetSurname()
    {
        return this.Surname;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
    public int GetAge()
    {
        return this.age;
    }
}