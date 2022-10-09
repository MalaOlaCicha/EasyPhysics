using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyPhysics_.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElektrycznoscPage : ContentPage
    {
        public ElektrycznoscPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public ObservableCollection<Equation> Elektrycznosc { get => GetEquations(); }

        private ObservableCollection<Equation> GetEquations()
        {
            return new ObservableCollection<Equation>
            {
                new Equation { Id = 1, Name = "", Png = "",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1, Info = ""},
                    }
                },
            };
        }

        public class Equation : Description
        {
            public string Name { get; set; }
            public string Png { get; set; }
            public ObservableCollection<Description> Descriptions { get; set; }
        }

        public class Description
        {
            public double Id { get; set; }
            public string Info { get; set; }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchresult = Elektrycznosc.Where(c => c.Name.ToLower().Contains(SearchElektrycznosc.Text.ToLower()));
            CV_Elektrycznosc.ItemsSource = searchresult;
        }
    }
}