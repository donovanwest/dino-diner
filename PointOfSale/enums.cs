using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    /// <summary>
    /// All the possible Entrees
    /// </summary>
    public enum Entrees
    {
        Brontowurst,
        DinoNuggets,
        PrehistoricPBJ,
        PterodactylWings,
        Steakosaurus,
        TRexKingBurger,
        VelociWrap
    }
    /// <summary>
    /// All the possible Sides
    /// </summary>
    public enum Sides
    {
        Fryceritops,
        MeteorMacAndCheese,
        MezzorellaSticks,
        Triceritots
    }
    /// <summary>
    /// all the possible drinks
    /// </summary>
    public enum Drinks
    {
        JurrasicJava,
        Sodasaurus,
        Tyrannotea,
        Water
    }
    /// <summary>
    /// keeps track of what the previous page was
    /// </summary>
    public enum PreviousPages
    {
        MenuCategorySelection,
        ComboCustomization,
        EntreeSelection,
        DrinkSelection,
        SideSelection
    }
}
