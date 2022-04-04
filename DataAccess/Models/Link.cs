using System.Text.Json.Serialization;

public class Link
{
#pragma warning disable CS8618
    public int Id { get; set; }
    public string Url { get; set; }
    public int? PersonId { get; set; }
    public Person Person { get; set; }
    public int InterestId { get; set; }
    public Interest Interest { get; set; }


    public Link() { }
}