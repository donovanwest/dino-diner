using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        double Price { get; set; }
        uint Calories { get; set; }
        List<string> Ingredients { get; }

    }
}
