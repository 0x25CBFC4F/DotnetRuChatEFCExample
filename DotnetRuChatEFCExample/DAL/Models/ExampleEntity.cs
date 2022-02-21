using System.ComponentModel.DataAnnotations;

namespace DotnetRuChatEFCExample.DAL.Models;

public class ExampleEntity
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    public string ExampleString { get; set; }
    
    [Required]
    public bool ExampleBool { get; set; }
}