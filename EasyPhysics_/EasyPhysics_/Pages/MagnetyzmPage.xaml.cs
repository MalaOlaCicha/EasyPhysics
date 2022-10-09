using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyPhysics_.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagnetyzmPage : ContentPage
    {
        public MagnetyzmPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public ObservableCollection<Equation> Magnetyzm { get => GetEquations(); }

        private ObservableCollection<Equation> GetEquations()
        {
            return new ObservableCollection<Equation>
            {
                new Equation { Id = 1, Name = "Siła Magnetyczna (Wektorowo)", Png = "SilaMag1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1, Info = "F – siła"},
                        new Description { Id = 1.2, Info = "I - natężenie prądu"},
                        new Description { Id = 1.3, Info = "l – długość części przewodnika znajdującej się w polu magnetycznym"},
                        new Description { Id = 1.4, Info = "B – indukcja magnetyczna"},                      
                    }
                },

                new Equation { Id = 2, Name = "Siła Magnetyczna (Skalarnie)", Png = "SilaMag2.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 2.1, Info = "F – siła"},
                        new Description { Id = 2.2, Info = "I - natężenie prądu"},
                        new Description { Id = 2.3, Info = "l – długość części przewodnika znajdującej się w polu magnetycznym"},
                        new Description { Id = 2.4, Info = "B – indukcja magnetyczna"},
                        new Description { Id = 2.5, Info = "α – kąt między wektorami prędkości v i indukcji magnetycznej B"},
                    }
                },
                
                new Equation { Id = 3, Name = "Siła Lorentza (Wektorowo)", Png = "SilaLo1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 3.1, Info = "F – siła"},
                        new Description { Id = 3.2, Info = "v – prędkość cząstki"},
                        new Description { Id = 3.3, Info = "q – ładunek cząstki"},
                        new Description { Id = 3.4, Info = "B – indukcja magnetyczna"},
                    }
                },

                new Equation { Id = 4, Name = "Siła Lorentza (Skalarnie)", Png = "SilaLo2.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 4.1, Info = "F – siła"},
                        new Description { Id = 4.2, Info = "v – prędkość cząstki"},
                        new Description { Id = 4.3, Info = "q – ładunek cząstki"},
                        new Description { Id = 4.4, Info = "B – indukcja magnetyczna"},
                        new Description { Id = 4.5, Info = "α – kąt między wektorami prędkości v i indukcji magnetycznej B"},
                    }
                },

                new Equation { Id = 5, Name = "Wektor indukcji magnetycznej", Png = "WektorIn1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1, Info = "F – siła"},
                        new Description { Id = 1.2, Info = "I - natężenie prądu"},
                        new Description { Id = 1.3, Info = "l – długość części przewodnika znajdującej się w polu magnetycznym"},
                        new Description { Id = 1.4, Info = "B – indukcja magnetyczna"},
                    }
                },

                new Equation { Id = 6, Name = "Wektor indukcji magnetycznej", Png = "WektorIn2.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 4.1, Info = "F – siła"},
                        new Description { Id = 4.2, Info = "v – prędkość cząstki"},
                        new Description { Id = 4.3, Info = "q – ładunek cząstki"},
                        new Description { Id = 4.4, Info = "B – indukcja magnetyczna"},
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
            var searchresult = Magnetyzm.Where(c => c.Name.ToLower().Contains(SearchMagnetyzm.Text.ToLower()));
            CV_Magnetyzm.ItemsSource = searchresult;
        }
    }
}