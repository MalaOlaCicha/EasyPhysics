using System;
using System.Collections.Generic;
using EasyPhysics_.Models;
using EasyPhysics_.Pages;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace EasyPhysics_.CollectionViewModel
{
    public class PatternDefinitionList
    {
        public List<PatternDefinition> Patterns { get; set; }

        public PatternDefinitionList()
        {
            Patterns = new PatternDefinitionFactory().GetItemsSpecs();
        }
    }
}
