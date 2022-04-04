using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Interest
{
#pragma warning disable CS8618
    public int Id { get; set; }
    public string Title { get; set; }
    [StringLength(320)]
    public string Description { get; set; }
    public int PersonId { get; set; }


    public Interest() { }

}