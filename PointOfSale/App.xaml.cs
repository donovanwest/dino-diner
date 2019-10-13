using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entrees currentEntree;
        public static Sides currentSide;
        public static Drinks currentDrink;
        public static PreviousPages PreviousPage;
    }
}
