public struct Dog
{
    public string name {get; set;}
    public float age {get; set;}
    public string owner {get; set;}
    public Rating rating {get; set;}
    public Dog(string name, float age, string owner, Rating rating): this()
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }
    public override string ToString()
    {
      return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}\n", name, age, owner, rating);
    }
}
public enum Rating
{
    Good,
    Great,
    Excellent
}
