using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI
{
    public abstract class BaseMenu : IMenu
    {
        protected class MenuItem
        {
            public string Id;
            public string Text;
            public bool IsSelected;
            public ILogic Logic;
        }

        protected abstract List<MenuItem> Items { get; }

        public virtual void Draw()
        {
            ConsoleHelper.ClearScreen();
            foreach (MenuItem menuItem in Items)
            {
                Console.BackgroundColor = menuItem.IsSelected
                    ? ConsoleColor.DarkRed
                    : ConsoleColor.Black;

                Console.WriteLine(menuItem.Text);
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Next()
        {
            var selectedItem = Items.First(x => x.IsSelected);
            int selectedIndex = Items.IndexOf(selectedItem);
            selectedItem.IsSelected = false;

            selectedIndex = selectedIndex == Items.Count - 1
                ? 0
                : ++selectedIndex;

            Items[selectedIndex].IsSelected = true;
        }

        public void Prev()
        {
            var selectedItem = Items.First(x => x.IsSelected);
            int selectedIndex = Items.IndexOf(selectedItem);
            selectedItem.IsSelected = false;

            selectedIndex = selectedIndex == 0
                ? Items.Count - 1
                : --selectedIndex;

            Items[selectedIndex].IsSelected = true;
        }

        public string Select()
        {
            var selectedItem = Items.First(x => x.IsSelected);
            if (selectedItem.Logic != null)
            {
                selectedItem.Logic.Execute();
            }

            return selectedItem.Id;
        }
    }

}
