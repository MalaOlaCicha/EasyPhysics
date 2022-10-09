using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System;
using Xamarin.CommunityToolkit.UI.Views;

namespace EasyPhysics_.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KinematykaPage : ContentPage
    { 
        public KinematykaPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchresult = Kinematyka.Where(c => c.Name.ToLower().Contains(SearchKinematyka.Text.ToLower()));
            CV_Kinematyka.ItemsSource = searchresult;
        }

        public ObservableCollection<Equation> Kinematyka { get => GetEquations(); }
       
        private ObservableCollection<Equation> GetEquations()
        {
            return new ObservableCollection<Equation>
            {
                new Equation { Id = 1, Name = "Droga w ruchu jednostajnym", Png = "predkosc.png",
                    Descriptions = new ObservableCollection<Description>
                    { 
                        new Description { Id = 1.1, Name = "S — droga"},
                        new Description { Id = 1.2, Name = "v — prędkość"},
                        new Description { Id = 1.3, Name = "t — czas"}
                    }
                },

                new Equation { Id = 2, Name = "Droga w ruchu jednostajnie przyspieszonym", Png = "ruch_jednostajnie_prz.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 2.1, Name = "S — droga"},
                        new Description { Id = 2.2, Name = "vp — prędkość początkowa"},
                        new Description { Id = 2.3, Name = "a — przyspieszenie"},
                        new Description { Id = 2.4, Name = "t — czas"}
                    }
                },

                new Equation { Id = 3, Name = "Droga w ruchu jednostajnie opóźnionym", Png = "ruch_jednostajnie_op.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 3.1, Name = "S — droga"},
                        new Description { Id = 3.2, Name = "vp — prędkość początkowa"},
                        new Description { Id = 3.3, Name = "a — przyspieszenie"},
                        new Description { Id = 3.4, Name = "t — czas"}
                    }
                },

                new Equation { Id = 4, Name = "Przyspieszenie", Png = "przyspieszenie.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 4.1, Name = "a — przyspieszenie"},
                        new Description { Id = 4.2, Name = "∆v — różnica prędkości"},
                        new Description { Id = 4.3, Name = "∆t — różnica czasu"}
                    }
                },

                new Equation { Id = 5, Name = "Przemieszczenie ciała od początku układu odniesienia w ruchu jednostajnym", Png = "Przemieszczenie_1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 5.1, Name = "x0 — początkowe położenie ciała"},
                        new Description { Id = 5.2, Name = "v — prędkość"},
                        new Description { Id = 5.3, Name = "t — czas"}
                    }
                },

                new Equation { Id = 6, Name = "Przemieszczenie ciała od początku układu odniesienia w ruchu jednostajnie przyśpieszonym", Png = "Przemieszczenie_2.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 6.1, Name = "x — położenie ciała"},
                        new Description { Id = 6.2, Name = "x0 — początkowe położenie ciała"},
                        new Description { Id = 6.3, Name = "v0 — prędkość początkowa"},
                        new Description { Id = 6.4, Name = "a — przyspieszenie"},
                        new Description { Id = 6.5, Name = "t — czas"}
                    }
                },

                new Equation { Id = 7, Name = "Przemieszczenie ciała od początku układu odniesienia w ruchu jednostajnie opóźnionym", Png = "Przemieszczenie_3.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 7.1, Name = "x — położenie ciała"},
                        new Description { Id = 7.2, Name = "x0 — początkowe położenie ciała"},
                        new Description { Id = 7.3, Name = "v0 — prędkość początkowa"},
                        new Description { Id = 7.4, Name = "a — przyspieszenie"},
                        new Description { Id = 7.5, Name = "t — czas"}
                    }
                },

                new Equation { Id = 8, Name = "Prędkość końcowa (po czasie t) w ruchu jednostajnie przyśpieszonym", Png = "PredkoscK_przy.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 8.1, Name = "vk — prędkość końcowa"},
                        new Description { Id = 8.2, Name = "v0 — prędkość początkowa"},
                        new Description { Id = 8.3, Name = "a — przyspieszenie"},
                        new Description { Id = 8.2, Name = "t — czas"}
                    }
                },

                new Equation { Id = 9, Name = "Prędkość końcowa (po czasie t) w ruchu jednostajnie opóźnionym", Png = "PredkoscK_op.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 9.1, Name = "vk — prędkość końcowa"},
                        new Description { Id = 9.2, Name = "v0 — prędkość początkowa"},
                        new Description { Id = 9.3, Name = "a — przyspieszenie"},
                        new Description { Id = 9.4, Name = "t — czas"}
                    }
                },

                new Equation { Id = 10, Name = "Przyspieszenie w ruchu jednostajnie przyspieszonym", Png = "przysp_przy.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 10.1, Name = "a — przyspieszenie"},
                        new Description { Id = 10.2, Name = "∆v — różnica prędkości"},
                        new Description { Id = 10.3, Name = "∆t — różnica czasu"}                       
                    }
                },

                new Equation { Id = 11, Name = "Przyspieszenie w ruchu jednostajnie opóźnionym", Png = "przysp_op.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 11.1, Name = "a — przyspieszenie"},
                        new Description { Id = 11.2, Name = "∆v — różnica prędkości"},
                        new Description { Id = 11.3, Name = "∆t — różnica czasu"}
                    }
                },

                new Equation { Id = 12, Name = "Siła (II zasada dynamiki Newtona)", Png = "II_zasadaDN.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 12.1, Name = "F — siła"},
                        new Description { Id = 12.2, Name = "m — masa"},
                        new Description { Id = 12.3, Name = "a — przyspieszenie"}
                    }
                },

                new Equation { Id = 13, Name = "Okres ruchu po okręgu (czas jednego pełnego obrotu)", Png = "ruch_po_okregu_1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 13.1, Name = "T — okres ruchu (w sekundach s) "},
                        new Description { Id = 13.2, Name = "t — czas w jakim odbywa się ruch, lub jego fragment (w sekundach s)"},
                        new Description { Id = 13.3, Name = "N — ilość wykonanych (również niepełnych, wtedy będzie ułamek) okrążeń okręgu (liczba niemianowana)"}
                    }
                },

                new Equation { Id = 14, Name = "Częstotliwość (ilość obrotów na jednostkę czasu)", Png = "ruch_po_okregu_2.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 14.1, Name = "f — częstotliwość (w Hz = 1/s = s^-1)"},
                        new Description { Id = 14.2, Name = "t — czas w jakim odbywa się ruch, lub jego fragment (w sekundach s)"},
                        new Description { Id = 14.3, Name = "N — ilość wykonanych (również niepełnych, wtedy będzie ułamek) okrążeń okręgu (liczba niemianowana)"}
                    }
                },

                new Equation { Id = 15, Name = "Częstotliwość (ilość obrotów na jednostkę czasu)", Png = "ruch_po_okregu_3.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 15.1, Name = "f — częstotliwość (w Hz = 1/s = s^-1)"},
                        new Description { Id = 15.2, Name = "1 — jedno okrążenie"},
                        new Description { Id = 15.3, Name = "T — okres ruchu (w sekundach s) "}
                    }
                },

                new Equation { Id = 16, Name = "Okres ruchu po okręgu (czas jednego pełnego obrotu)", Png = "ruch_po_okregu_4.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 16.1, Name = "T — okres ruchu (w sekundach s) "},
                        new Description { Id = 16.2, Name = "1 — jedno okrążenie"},
                        new Description { Id = 16.3, Name = "f — częstotliwość (w Hz = 1/s = s^-1)"}
                    }
                },

                new Equation { Id = 17, Name = "Kąt wyrażony w radianach", Png = "ruch_po_okregu_5.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 17.1, Name = "∆α, α — kąt (w układzie SI w radianach, co jest równoważne wielkości niemianowanej)"},
                        new Description { Id = 17.2, Name = "∆L — długość drogi przebytej wzdłuż łuku okręgu (w układzie SI w metrach m)"},
                        new Description { Id = 17.3, Name = "R — promień okręgu którego fragmentem jest zakreślany łuk (w układzie SI w metrach m)"}
                    }
                },

                new Equation { Id = 18, Name = "Prędkość kątowa", Png = "ruch_po_okregu_6.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 18.1, Name = "∆α — kąt zakreślony przez promień wodzący (w radianach)"},
                        new Description { Id = 18.2, Name = "∆t — czas w jakim odbywa się ruch, lub jego fragment (w sekundach s)"},
                        new Description { Id = 18.3, Name = "ω — prędkość kątowa (w rad/s, lub 1/s = s^-1)"}
                    }
                },

                new Equation { Id = 19, Name = "Związek między prędkością liniową i prędkością kątową", Png = "ruch_po_okregu_7.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 19.1, Name = "ω — prędkość kątowa (w rad/s, lub 1/s = s-1)"},
                        new Description { Id = 19.1, Name = "R — promień okręgu"},
                        new Description { Id = 19.1, Name = "v — prędkość liniowa"}
                    }
                },

                new Equation { Id = 20, Name = "Przyspieszenie dośrodkowe", Png = "ruch_po_okregu_8.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 20.1, Name = "R — promień okręgu"},
                        new Description { Id = 20.2, Name = "v — prędkość liniowa"},
                        new Description { Id = 20.3, Name = "αdosr — przyśpieszenie dośrodkowe"}
                    }
                },

                new Equation { Id = 21, Name = "Wartość przyspieszenia odśrodkowego", Png = "ruch_po_okregu_9.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 21.1, Name = "R — promień okręgu"},
                        new Description { Id = 21.2, Name = "ω — prędkość kątowa (w rad/s, lub 1/s = s^-1)"},
                        new Description { Id = 21.3, Name = "αdosr — wartość przyśpieszenia odśrodkowe"}
                    }
                },

                new Equation { Id = 22, Name = "Prędkość kątowa", Png = "ruch_po_okregu_10.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 22.1, Name = "ω — prędkość kątowa (w rad/s, lub 1/s = s^-1)"},
                        new Description { Id = 22.2, Name = "n — ilość wykonanych (również niepełnych, wtedy będzie ułamek) okrążeń okręgu (liczba niemianowana)"},
                        new Description { Id = 22.3, Name = "f — częstotliwość (w Hz = 1/s = s^-1)"}
                    }
                },

                new Equation { Id = 23, Name = "Prędkość kątowa", Png = "ruch_po_okregu_11.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 23.1, Name = "ω — prędkość kątowa (w rad/s, lub 1/s = s^-1)"},
                        new Description { Id = 23.2, Name = "T — okres ruchu (w sekundach s)"},
                        new Description { Id = 23.3, Name = "π — stała matematyczna"}
                    }
                },

                new Equation { Id = 24, Name = "Droga w ruchu jednostajnym po okręgu", Png = "ruch_po_okregu_12.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 24.1, Name = "w — prędkość kątowa"},
                        new Description { Id = 24.2, Name = "R — promień okręgu"},
                        new Description { Id = 24.3, Name = "t — czas"},
                        new Description { Id = 24.3, Name = "S — przebywana droga liczona wzdłuż łuku"}
                    }
                },
            };
        }

        public class Equation : Description
        {
            public string Png { get; set; }
            public ObservableCollection<Description> Descriptions { get; set; }
        }

        public class Description
        {
            public double Id { get; set; }
            public string Name { get; set; }
        }


    }
}