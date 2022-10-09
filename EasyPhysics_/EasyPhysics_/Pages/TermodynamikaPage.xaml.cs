using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyPhysics_.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermodynamikaPage : ContentPage
    {
        public TermodynamikaPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public ObservableCollection<Equation> Termodynamika { get => GetEquations(); }

        private ObservableCollection<Equation> GetEquations()
        {
            return new ObservableCollection<Equation>
            {
                new Equation { Id = 1, Name = "I Zasada Termodynamiki", Png = "wzor_1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1, Info = "∆Ew — zmiana energii wewnętrznej (oznaczane też jako ∆U)"},
                        new Description { Id = 1.2, Info = "Q — ciepło"},
                        new Description { Id = 1.3, Info = "W — praca"}
                    }
                },

                new Equation { Id = 2, Name = "Równanie Clapeyrona", Png = "wzor_2.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 2.1, Info = "p — ciśnienie"},
                        new Description { Id = 2.2, Info = "R — stała gazowa"},
                        new Description { Id = 2.3, Info = "n — ilość moli"},
                        new Description { Id = 2.4, Info = "T — temperatura"}
                    }
                },

                 new Equation { Id = 3, Name = "Ciepło topnienia", Png = "wzor_3.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 3.1, Info = "E — energia"},
                        new Description { Id = 3.2, Info = "m — masa"},
                        new Description { Id = 3.3, Info = "Lt — ciepło topnienia"}
                    }
                },

                new Equation { Id = 4, Name = "Ciepło parowania", Png = "wzor_4.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 4.1, Info = "E — energia"},
                        new Description { Id = 4.2, Info = "m — masa"},
                        new Description { Id = 4.3, Info = "Lp — ciepło parowania"}
                    }
                },

                new Equation { Id = 5, Name = "Ciepło molowe gazu dla gazu jednoatomowego (v)", Png = "wzor_5.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 5.1, Info = "Cv - ciepło molowe przy stałej objętości"},
                        new Description { Id = 5.2, Info = "R — stała gazowa"}
                    }
                },

                new Equation { Id = 6, Name = "Ciepło molowe gazu dla gazu jednoatomowego (p)", Png = "wzor_6.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 6.1, Info = "Cp — ciepło molowe przy stałym ciśnieniu"},
                        new Description { Id = 6.2, Info = "R — stała gazowa"}
                    }
                },

                new Equation { Id = 7, Name = "Ciepło molowe gazu dla gazu dwuatomowego (v)", Png = "wzor_7.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 7.1, Info = "Cv — ciepło molowe przy stałej objętości"},
                        new Description { Id = 7.2, Info = "R — stała gazowa"}
                    }
                },

                new Equation { Id = 8, Name = "Ciepło molowe gazu dla gazu dwuatomowego (p)", Png = "wzor_8.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 8.1, Info = "Cp — ciepło molowe przy stałym ciśnieniu"},
                        new Description { Id = 8.2, Info = "R — stała gazowa"}
                    }
                },

                 new Equation { Id = 9, Name = "Równanie przemiany izotermicznej gazu doskonałego (p)", Png = "wzor_9.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 9.1, Info = "p — ciśnienie"},
                        new Description { Id = 9.2, Info = "V — objętość"},
                        new Description { Id = 9.3, Info = "const — stały"}
                    }
                },

                new Equation { Id = 10, Name = "Równanie przemiany izotermicznej gazu doskonałego (p1)", Png = "wzor_10.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 10.1, Info = "p1 — ciśnienie gazu przed"},
                        new Description { Id = 10.2, Info = "V1 — objętość gazu przed"},
                        new Description { Id = 10.3, Info = "p2 — ciśnienie gazu po"},
                        new Description { Id = 10.4, Info = "V2 — objętość gazu po"}
                    }
                },

                new Equation { Id = 11, Name = "Równanie przemiany izobarycznej gazu doskonałego (V/T)", Png = "wzor_11.png",
                    Descriptions = new ObservableCollection<Description>
                    {                       
                        new Description { Id = 11.1, Info = "V — objętość"},
                        new Description { Id = 11.2, Info = "T — temperatura"},
                        new Description { Id = 11.3, Info = "const — stały"}
                    }
                },

                new Equation { Id = 12, Name = "Równanie przemiany izobarycznej gazu doskonałego (V1/T1)", Png = "wzor_12.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 12.1, Info = "V1 — objętość gazu przed"},
                        new Description { Id = 12.2, Info = "T1 — temperatura gazu przed"},
                        new Description { Id = 12.3, Info = "V2 — objętość gazu po"},
                        new Description { Id = 12.4, Info = "T2 — temperatura gazu po"}
                    }
                },

                new Equation { Id = 13, Name = "Równanie przemiany izochorycznej gazu doskonałego (p/T)", Png = "wzor_13.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 13.1, Info = "p — ciśnienie"},
                        new Description { Id = 13.2, Info = "T — temperatura"},
                        new Description { Id = 13.3, Info = "const — stały"}
                    }
                },

                new Equation { Id = 14, Name = "Równanie przemiany izochorycznej gazu doskonałego (p1/T1)", Png = "wzor_14.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 14.1, Info = "p1 — ciśnienie gazu przed"},
                        new Description { Id = 14.2, Info = "T1 — temperatura gazu przed"},
                        new Description { Id = 14.3, Info = "p2 — ciśnienie gazu po"},
                        new Description { Id = 14.4, Info = "T2 — temperatura gazu po"}
                    }
                },

                 new Equation { Id = 15, Name = "Związek między Cp i Cv", Png = "wzor_15.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 15.1, Info = "Cp - ciepło molowe przy stałym ciśnieniu"},
                        new Description { Id = 15.2, Info = "Cv - ciepło molowe przy stałej objętości"},
                        new Description { Id = 15.3, Info = "R — stała gazowa"}
                    }
                },

                new Equation { Id = 16, Name = "Energia potrzebna do zajścia przemian fazowych (1)", Png = "wzor_16.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 16.1, Info = "Q — ciepło"},
                        new Description { Id = 16.1, Info = "m — masa"},
                        new Description { Id = 16.1, Info = "Rp — ciepło parowania"}
                    }
                },

                new Equation { Id = 17, Name = "Enrgia potrzebna do zajścia przemian fazowych (2)", Png = "wzor_17.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 17.1, Info = "Q — ciepło"},
                        new Description { Id = 17.1, Info = "m — masa"},
                        new Description { Id = 17.1, Info = "L — ciepło topnienia"}
                    }
                },

                new Equation { Id = 18, Name = "Stała gazowa R", Png = "wzor_18.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1, Info = "R — stała gazowa"},
                        new Description { Id = 1.1, Info = "k — stała Boltzmana"},
                        new Description { Id = 1.1, Info = "N — liczba cząstek w gazie"},
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
            var searchresult = Termodynamika.Where(c => c.Name.ToLower().Contains(SearchTermodynamika.Text.ToLower()));
            CV_Termodynamika.ItemsSource = searchresult;
        }
    } 
}