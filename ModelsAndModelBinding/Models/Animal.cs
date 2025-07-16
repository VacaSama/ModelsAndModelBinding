namespace ModelsAndModelBinding.Models;

/// <summary>
/// Animals in the zoo, tells the user which exibits are open to visiting and which are closed
/// </summary>
public class Animal
{
    // what properties are needed for an animal?
    public string Classification { get; set; } 
    public string Species { get; set; }
    // idea may have to be chanaged to a store that sells animal plushies. 
    // public bool InStock {get; set; } = true; // default value
    // public int price {get; set;}
    public bool ExibitOpen { get; private set; } = true; // default value

    public Animal(string classification, string species, bool exibitOpen)
    {
        Classification = classification;
        Species = species;
        ExibitOpen = exibitOpen;
    }
}
