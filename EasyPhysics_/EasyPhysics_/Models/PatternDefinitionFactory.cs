using System;
using System.Collections.Generic;
using EasyPhysics_.Models;
using EasyPhysics_.CollectionViewModel;
using EasyPhysics_.Pages;
using System.Text;
using Xamarin.Forms;

namespace EasyPhysics_.Models
{
    public class PatternDefinitionFactory
    {
        public List<PatternDefinition> GetItemsSpecs()
        {
            return new List<PatternDefinition>()
            {
                new PatternDefinition{Id = 1, Name = "Droga w ruchu jednostajnym", Png = "predkosc.png"},
                new PatternDefinition{Id = 2, Name = "Droga w ruchu jednostajnie przyspieszonym", Png = "ruch_jednostajnie_prz.png"},
                new PatternDefinition{Id = 3, Name = "Droga w ruchu jednostajnie opóźnionym", Png = "ruch_jednostajnie_op.png"},
                new PatternDefinition{Id = 4, Name = "Przyspieszenie", Png = "przyspieszenie.png"},
                new PatternDefinition{Id = 5, Name = "Przemieszczenie ciała od początku układu odniesienia w ruchu jednostajnym", Png = "Przemieszczenie_1.png"},
                new PatternDefinition{Id = 6, Name = "Przemieszczenie ciała od początku układu odniesienia w ruchu jednostajnie przyśpieszonym", Png = "Przemieszczenie_2.png"},
                new PatternDefinition{Id = 7, Name = "Przemieszczenie ciała od początku układu odniesienia w ruchu jednostajnie opóźnionym", Png = "Przemieszczenie_3.png"},
                new PatternDefinition{Id = 8, Name = "Prędkość końcowa (po czasie t) w ruchu jednostajnie przyśpieszonym", Png = "PredkoscK_przy.png"},
                new PatternDefinition{Id = 9, Name = "Prędkość końcowa (po czasie t) w ruchu jednostajnie opóźnionym", Png = "PredkoscK_op.png"},
                new PatternDefinition{Id = 10, Name = "Przyspieszenie w ruchu jednostajnie przyspieszonym", Png = "przysp_przy.png"},
                new PatternDefinition{Id = 11, Name = "Przyspieszenie w ruchu jednostajnie opóźnionym", Png = "przysp_op.png"},
            };
        }   
    }
}
