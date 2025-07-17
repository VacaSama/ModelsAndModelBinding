using System.ComponentModel.DataAnnotations;

namespace ModelsAndModelBinding.Models;

/// <summary>
/// An Animal class that represents 
/// an animal with properties such as Classification, Species, Location, and Endangered status.
/// </summary>
public class Animal
{
    // what properties are needed for an animal?
    /// <summary>
    ///  Classification of the Animal means; Mammal, Retile, Amphinian, etc
    /// </summary>
    [StringLength(35)]
    [Required(ErrorMessage = "Classification is required. For Example: Mammal")]
    public string Classification { get; set; }
    /// <summary>
    /// /The Species, asks for the specific type of animal. 
    /// In other words, the animals name. Example: Lion, Tiger, Bear, etc
    /// </summary>
    public string Species { get; set; }
    /// <summary>
    /// The location in which the animal can be found.
    /// Eastern Hemisphere, Taiwan, New Hampshire Zoo are all accepted.
    /// </summary>
    public string Location { get; set; }
    /// <summary>
    /// By the user selecting this check box, it will indicate if the animal is at risk of extinction.
    /// Endangered animals should me separated from non-endangered animals in a list. So that they are 
    /// easier to find in the future. 
    /// </summary>
    public bool Endangered {get; set; } = false; // default value
    /// <summary>
    /// Animal Object that creates a new animal with the following properties.
    /// </summary>
    /// <param name="classification"></param>
    /// <param name="species"></param>
    /// <param name="location"></param>
    /// <param name="endangered"></param>
    public Animal(string classification, string species, string location, bool endangered)
    {
        Classification = classification;
        Species = species;
        Location = location;
        Endangered = endangered;
    }
    /// <summary>
    /// Parameterless constructor for the Animal class.
    /// </summary>
    public Animal()
    {

    }
}
