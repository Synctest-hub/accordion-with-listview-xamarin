using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AccordionXamarin
{
    public class ItemInfoRepository
    {
        public ObservableCollection<ItemInfo> Info { get; set; }

        public ItemInfoRepository()
        {
            Info = new ObservableCollection<ItemInfo>();
            Info.Add(new ItemInfo() { Name = "Veg Extravaganza", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 300 }, new Variety() { Name = "Fresh Pan Pizza", Price = 260 }, new Variety() { Name = "Wheat Thin Crust", Price = 500 }, new Variety() { Name = "Wheat Crust", Price = 600 } } });
            Info.Add(new ItemInfo() { Name = "Deluxe Veggie", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 320 }, new Variety() { Name = "Fresh Pan Pizza", Price = 310 }, new Variety() { Name = "Wheat Thin Crust", Price = 480 } }});
            Info.Add(new ItemInfo() { Name = "Peppy Panner", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 280 }, new Variety() { Name = "Fresh Pan Pizza", Price = 270 }} });
            Info.Add(new ItemInfo() { Name = "Mexican Green Wave", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 330 }, new Variety() { Name = "Fresh Pan Pizza", Price = 340 }, new Variety() { Name = "Wheat Thin Crust", Price = 550 } } });
        }
    }
}