using System;
using System.Collections.Generic;
using EasyPhysics_.Models;
using EasyPhysics_.CollectionView;
using System.Text;

namespace EasyPhysics_.CollectionViewModel
{
    class ViewItemsModel
    {
        public List<ItemsSpec> Items { get; set; }

        public ViewItemsModel()
        {
            Items = new ViewItems().GetItemsSpecs();
        }
    }
}
