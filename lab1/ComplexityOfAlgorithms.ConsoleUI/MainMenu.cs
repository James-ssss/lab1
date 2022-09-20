using lab1.Algorithms;
using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI
{
    class MainMenu : BaseMenu
    {
        protected override List<MenuItem> Items => new List<MenuItem>
        {
            new MenuItem {Text = "Список людей", Logic = new BucketSort(), IsSelected = true},
            new MenuItem {Text = "Выход"}
        };
    }

}
