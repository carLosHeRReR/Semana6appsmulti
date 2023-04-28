using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
        {
            new Group("A")
            {
                new Item { Title = "Amelia", Subtitle = "Cedar" },
                new Item { Title = "Alfie", Subtitle = "Spruce" },
                new Item { Title = "Ava", Subtitle = "Pline" },
                new Item { Title = "Archie", Subtitle = "Maple" }
            },
            new Group("B")
            {
                new Item { Title = "Brooke", Subtitle = "Lumia" },
                new Item { Title = "Bobby", Subtitle = "Xperia" },
                new Item { Title = "Bella", Subtitle = "Desire" },
                new Item { Title = "Ben", Subtitle = "Chocolate" }
            },
            new Group("C")
            {
                new Item { Title = "Clhoe", Subtitle = "Brighton" },
                new Item { Title = "Charlotte", Subtitle = "Hennietta" },
                new Item { Title = "Mendez", Subtitle = "Diego" },
                new Item { Title = "Connor", Subtitle = "Dallas" }
            },
        };
            GroupedView.ItemsSource = Groups;
        }
    }
}