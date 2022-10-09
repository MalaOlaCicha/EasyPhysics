using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyPhysics_.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OptykaPage : ContentPage
    {
        public OptykaPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public ObservableCollection<Equation> Optyka { get => GetEquations(); }

        private ObservableCollection<Equation> GetEquations()
        {
            return new ObservableCollection<Equation>
            {
                new Equation { Id = 1 , Name = "Ogniskowa zwierciadła wklęsłego", Png = "Ogniskowa_zwierciadla_wkleslego.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 1.1 , Info = "R — promień sfery"},
                        new Description { Id = 1.2 , Info = "f — ogniskowa"}
                    }
                },

                new Equation { Id = 2 , Name = "Ogniskowa zwierciadła wypukłego", Png = "Ogniskowa_zwierciadla_wypuklego.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 2.1, Info = "R — promień sfery"},
                        new Description { Id = 2.2, Info = "f — ogniskowa"}
                    }
                },

                new Equation { Id = 3 , Name = "Ogniskowa zwierciadła oraz  soczewki", Png = "ozc.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 3.1 , Info = "x — odległość przedmiotu"},
                        new Description { Id = 3.2 , Info = "y — odległość obrazu"},
                        new Description { Id = 3.3 , Info = "f — ogniskowa"}
                    }
                },

                new Equation { Id = 4 , Name = "Powiększenie obrazu w zwierciadle oraz soczewce", Png = "powiekszenie.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 4.1 , Info = "p — powiększenie"},
                        new Description { Id = 4.2 , Info = "x — odległość przedmiotu"},
                        new Description { Id = 4.3 , Info = "y — odległość obrazu"},
                        new Description { Id = 4.4 , Info = "H — wysokość obrazu"},
                        new Description { Id = 4.5 , Info = "h — wysokość przedmiotu"}
                    }
                },

                new Equation { Id = 5 , Name = "Prawo załamania promieni świetlnych na granicy ośrodków", Png = "prawozalamania.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 5.1 , Info = "α — kąt padania"},
                        new Description { Id = 5.2 , Info = "β — kąt załamania"},
                        new Description { Id = 5.3 , Info = "v1 — prędkość w ośrodku pierwszym"},
                        new Description { Id = 5.4 , Info = "v2 — prędkość w ośrodku drugim"},
                        new Description { Id = 5.5 , Info = "n1 — bezwzględny współczynnik załamania ośrodka pierwszego"},
                        new Description { Id = 5.6 , Info = "n2 — bezwzględny współczynnik załamania ośrodka drugiego"}
                    }
                },

                new Equation { Id = 6 , Name = "Bezwzględny współczynnik załamania ośrodka", Png = "wspzalamania.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 6.1 , Info = "v — prędkość promieni świetlnych"},
                        new Description { Id = 6.2 , Info = "n — współczynnik załamania/rząd maksimum interferencyjnego"},
                        new Description { Id = 6.3 , Info = "c — prędkość światła w próżni"}
                    }
                },

                new Equation { Id = 7 , Name = "Względny współczynnik załamania ośrodka", Png = "cos.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 7.1 , Info = "n1 — bezwzględny współczynnik załamania ośrodka pierwszego"},
                        new Description { Id = 7.2 , Info = "n2 — bezwzględny współczynnik załamania ośrodka drugiego"},
                        new Description { Id = 7.3 , Info = "v2 — prędkość w ośrodku drugim"},
                        new Description { Id = 7.4 , Info = "v1 — prędkość w ośrodku pierwszym"},
                        new Description { Id = 7.5 , Info = "λ1 — długość fali w ośrodku pierwszym"},
                        new Description { Id = 7.6 , Info = "λ2  — długość fali w ośrodku drugim"},
                        new Description { Id = 7.7 , Info = "n21 — względny współczynnik załamania światła przy przejściu z ośrodka 1 do ośrodka 2"}
                    }
                },

                new Equation { Id = 8 , Name = "Kąt graniczny w załamaniu ośrodka pierwszego względem drugiego", Png = "alfag.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 8.1 , Info = "α g — kąt graniczny"},
                        new Description { Id = 8.2 , Info = "n1 — bezwzględny współczynnik załamania ośrodka pierwszego"},
                        new Description { Id = 8.3 , Info = "n2 — bezwzględny współczynnik załamania ośrodka drugiego"}
                    }
                },

                new Equation { Id = 9 , Name = "Warunek wzmocnienia interferencyjnego fal świetlnych", Png = "lambda.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 9.1, Info = "λ — długość fali w ośrodku"},
                        new Description { Id = 9.2 , Info = "n — współczynnik załamania/rząd maksimum interferencyjnego"},
                        new Description { Id = 9.3 , Info = "r1, r2 — droga przebyta przez fale do miejsca nałożenia (interferencji) "}
                    }
                },

                new Equation { Id = 10 , Name = "Siatka dyfrakcyjna", Png = "cosdlueew.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 10.1 , Info = "α n — kąt łamaniaw pryzmacie"},
                        new Description { Id = 10.2 , Info = "d — stała siatki"},
                        new Description { Id = 10.3 , Info = "n — współczynnik załamania/rząd maksimum interferencyjnego"},
                        new Description { Id = 10.4 , Info = "λ — długość fali w ośrodku"}
                    }
                },

                new Equation { Id = 11 , Name = "Warunek wygaszenia interferencyjnego fal świetlnych", Png = "texdl.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 11.1 , Info = "r1, r2 — droga przebyta przez fale do miejsca nałożenia (interferencji)"},
                        new Description { Id = 11.2 , Info = "λ — długość fali w ośrodku"},
                        new Description { Id = 11.3 , Info = "n — współczynnik załamania/rząd maksimum interferencyjnego"}
                    }
                },

                new Equation { Id = 12 , Name = "Zdolność skupiającą układu składającego się z n soczewek", Png = "skupienie.png",
                    Descriptions = new ObservableCollection<Description>
                    {

                        new Description { Id = 12.1 , Info = "Z — zdolność skupiająca soczewki"}
                    }
                },

                new Equation { Id = 13 , Name = "Zdolność skupiająca soczewki ", Png = "z.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 13.1 , Info = "Z — zdolność skupiająca soczewki"},
                        new Description { Id = 13.2 , Info = "f — ogniskowa"}
                    }
                },

                new Equation { Id = 14 , Name = "Powiększenie lunety", Png = "p1.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 14.1 , Info = "f1 — ogniskowa obiektywu"},
                        new Description { Id = 14.2 , Info = "f2 — ogniskowa okularu"},
                        new Description { Id = 14.3 , Info = "p — powiększenie"}
                    }
                },

                new Equation { Id = 15 , Name = "Powiększenie mikroskopu", Png = "mikroskop.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 15.1, Info = "f1 — ogniskowa obiektywu"},
                        new Description { Id = 15.2 , Info = "f2 — ogniskowa okularu"},
                        new Description { Id = 15.3 , Info = "p — powiększenie"},
                        new Description { Id = 15.4 , Info = "d — odległość dobrego widzenia"},
                        new Description { Id = 15.5 , Info = "l — odległość między okularem, a obiektywem"}
                    }
                },

                new Equation { Id = 16 , Name = "Powiększenie lupy", Png = "lupa.png",
                    Descriptions = new ObservableCollection<Description>
                    {
                        new Description { Id = 16.1 , Info = "p — powiększenie"},
                        new Description { Id = 16.2 , Info = "d — odległość dobrego widzenia"},
                        new Description { Id = 16.3 , Info = "f — ogniskowa"}
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
            var searchresult = Optyka.Where(c => c.Name.ToLower().Contains(SearchOptyka.Text.ToLower()));
            CV_Optyka.ItemsSource = searchresult;
        }
    }
}