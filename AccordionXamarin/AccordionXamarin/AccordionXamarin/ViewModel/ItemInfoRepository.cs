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
            Info.Add(new ItemInfo() { Name = "Veg Extravaganza", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 300 }, new Variety() { Name = "Fresh Pan Pizza", Price = 260 }, new Variety() { Name = "Wheat Thin Crust", Price = 500 } } , Description = "Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." });
            Info.Add(new ItemInfo() { Name = "Deluxe Veggie", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 320 }, new Variety() { Name = "Fresh Pan Pizza", Price = 310 }, new Variety() { Name = "Wheat Thin Crust", Price = 480 } }, Description = "Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties." });
            Info.Add(new ItemInfo() { Name = "Peppy Panner", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 280 }, new Variety() { Name = "Fresh Pan Pizza", Price = 270 }, new Variety() { Name = "Wheat Thin Crust", Price = 510 } }, Description = "Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes." });
            Info.Add(new ItemInfo() { Name = "Mexican Green Wave", Varieties = new ObservableCollection<Variety>() { new Variety() { Name = "Cheese Burst", Price = 330 }, new Variety() { Name = "Fresh Pan Pizza", Price = 340 }, new Variety() { Name = "Wheat Thin Crust", Price = 550 } }, Description = "Consists of a hamburger, with the patty topped with chili con carne." });
        }
    }
}