using System.ComponentModel.DataAnnotations;

namespace ModelsAndModelBinding.Models;

/// <summary>
///
/// </summary>
public class Animal
{
    // what properties are needed for an animal?
    [StringLength(35)]
    [Required(ErrorMessage = "Classification is required. For Example: Mammal")]
    public string Classification { get; set; }
    [StringLength(35)]
    [Required(ErrorMessage = "Species is required. For Example: Lion")]
    public string Species { get; set; }
    [StringLength(35)]
    [Required(ErrorMessage = "Location of animal is required.")]
    public string Location { get; set; }
    public bool Endangered {get; set; } = false; // default value

    public Animal(string classification, string species, string location, bool endangered)
    {
        Classification = classification;
        Species = species;
        Location = location;
        Endangered = endangered;
    }

}
