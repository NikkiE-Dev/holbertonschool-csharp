public struct Dog
{
    public Dog(string name, float age, string owner, Rating rating): this()
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;

    }
    public string name {get; set;}
    public float age {get; set;}
    public string owner {get; set;}
    public Rating rating {get; set;}
        

}
public enum Rating
{
    Good,
    Great,
    Excellent
}