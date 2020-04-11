public class Person
{
    public string Name { get; set; }
    private int Age { get; set; }
    
    public void GetNameAndAge()
    {
        Console.WriteLine("the person has name:{0} and age:{1}", Name, Age);
    }
}