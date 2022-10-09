using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyPhysics_.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrganiaPage : ContentPage
    {
        public DrganiaPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public ObservableCollection<Equation> Drgania { get => GetEquations(); }

        private ObservableCollection<Equation> GetEquations()
        {
            return new ObservableCollection<Equation>
            {
                new Equation { Id = 1, Name = "Okres drgań wahadła matematycznego", Png = "drg_1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1, Info = "T - okres drgań wahadła matematycznego"},
                        new Description { Id = 1.2, Info = "l - długość wahadła w metrach"},
                        new Description { Id = 1.3, Info = "g - przyspieszenie grawitacyjne (ziemskie) w m/s2"},
                    }
                },

                new Equation { Id = 2, Name = "Okres drgań wahadła matematycznego", Png = "drg_1b.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 2.1, Info = "n – liczba wahnięć"},
                        new Description { Id = 2.2, Info = "tn – czas trwania n wahnięć"},
                    }
                },

                new Equation { Id = 3, Name = "Równanie ruchu harmonicznego", Png = "drg_2a.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 3.1, Info = "x – wychylenie"},
                        new Description { Id = 3.2, Info = "a  – przyspieszenie ruchu"},
                        new Description { Id = 3.3, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                    }
                },

                new Equation { Id = 4, Name = "Równanie ruchu harmonicznego", Png = "drg_2b.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 4.1, Info = "x – wychylenie"},
                        new Description { Id = 4.2, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                    }
                },

                new Equation { Id = 5, Name = "Wychylenie w ruchu harmonicznym", Png = "drg_3a.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 5.1, Info = "x – wychylenie"},
                        new Description { Id = 5.2, Info = "A – amplituda"},
                        new Description { Id = 5.3, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                        new Description { Id = 5.4, Info = "t - czas"},
                    }
                },

                new Equation { Id = 6, Name = "Wychylenie w ruchu harmonicznym", Png = "drg_3b.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 6.1, Info = "x – wychylenie"},
                        new Description { Id = 6.2, Info = "A, B – amplituda"},
                        new Description { Id = 5.3, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                        new Description { Id = 5.4, Info = "t - czas"},
                    }
                },

                new Equation { Id = 7, Name = "Wychylenie w ruchu harmonicznym", Png = "drg_3c.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 7.1, Info = "x – wychylenie"},
                        new Description { Id = 7.2, Info = "A – amplituda"},
                        new Description { Id = 7.3, Info = "φ  – faza początkowa"},
                        new Description { Id = 7.4, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                        new Description { Id = 7.5, Info = "t - czas"},
                    }
                },

                new Equation { Id = 8, Name = "Prędkość w ruchu harmonicznym", Png = "drg_4.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 8.1, Info = "A – amplituda"},
                        new Description { Id = 8.2, Info = "φ  – faza początkowa"},
                        new Description { Id = 8.3, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                        new Description { Id = 8.4, Info = "v  – prędkość ruchu"},
                    }
                },

                new Equation { Id = 9, Name = "Przyspieszenie w ruchu harmonicznym", Png = "drg_5.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 9.1, Info = "A – amplituda"},
                        new Description { Id = 9.2, Info = "φ  – faza początkowa"},
                        new Description { Id = 9.3, Info = "ω  - częstość kołowa, ω = 2 π f = 2 π / T"},
                        new Description { Id = 9.4, Info = "a  – przyspieszenie ruchu"},
                    }
                },

                new Equation { Id = 10, Name = "Energia potencjalna w ruchu harmonicznym", Png = "drg_6.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 10.1, Info = "Ep - energia potencjalna"},
                        new Description { Id = 10.2, Info = "x – wychylenie"},
                        new Description { Id = 10.3, Info = "k - stała sprężystości sprężyny, lub innego układu odpowiedzialnego za powrót do położenia równowagi "},
                        new Description { Id = 10.4, Info = "k = – ω^2m"},
                    }
                },

                new Equation { Id = 11, Name = "Prędkość fali (prędkość fazowa)", Png = "drg_7a.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 11.1, Info = "λ - długość fali"},
                        new Description { Id = 11.2, Info = "v - prędkość fali"},
                        new Description { Id = 11.3, Info = "T - okres fali"},
                    }
                },

                new Equation { Id = 12, Name = "Prędkość fali (prędkość fazowa)", Png = "drg_7b.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 12.1, Info = "λ - długość fali"},
                        new Description { Id = 12.2, Info = "v - prędkość fali"},
                        new Description { Id = 12.3, Info = "f - częstotliwość fali"},
                    }
                },

                new Equation { Id = 13, Name = "Równanie ruchu fali harmonicznej", Png = "drg_8a.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 13.1, Info = "λ - długość fali"},
                        new Description { Id = 13.2, Info = "φ0 - faza początkowa"},
                        new Description { Id = 13.3, Info = "A - amplituda"},
                        new Description { Id = 13.4, Info = "k - liczba falowa"},
                        new Description { Id = 13.5, Info = "T - okres fali"},
                        new Description { Id = 13.6, Info = "v - prędkość fali"},
                        new Description { Id = 13.7, Info = "ω  - częstość kołowa"},
                    }
                },

                new Equation { Id = 14, Name = "Równanie ruchu fali harmonicznej", Png = "drg_8b.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 14.1, Info = "ω  - częstość kołowa"},
                        new Description { Id = 14.2, Info = "t - czas"},
                        new Description { Id = 14.3, Info = "k - liczba falowa"},
                        new Description { Id = 14.4, Info = "φ0 - faza początkowa"},
                    }
                },

                new Equation { Id = 15, Name = "Liczba falowa", Png = "drg_9.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 15.1, Info = "λ - długość fali"},
                    }
                },

                new Equation { Id = 16, Name = "Częstotliwość fali", Png = "drg_10.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 16.1, Info = "T - okres fali"},
                    }
                },

                new Equation { Id = 17, Name = "Długość fali", Png = "drg_11.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 17.1, Info = "v - prędkość fali"},
                        new Description { Id = 17.2, Info = "T - okres"},
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
            var searchresult = Drgania.Where(c => c.Name.ToLower().Contains(SearchDrgania.Text.ToLower()));
            CV_Drgania.ItemsSource = searchresult;
        }
    }
}