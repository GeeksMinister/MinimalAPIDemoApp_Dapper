using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Person
{
#pragma warning disable CS8618
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    [Range(0, Int64.MaxValue, ErrorMessage = "Contact number should not contain characters")]
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string City { get; set; }
    IEnumerable<Interest> Interest { get; set; }
    public Person() { }
}