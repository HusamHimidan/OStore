using System;
using System.Collections.ObjectModel;
using System.Linq;
using Tasker.Models;
using Xamarin.Forms;

namespace Tasker.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {

        public ObservableCollection<Product> Products { get; set; }
        public Command AddListCommand { set; get; }
        public Command OpenBasketCommand { set; get; }
        public Command DetailsCommand { set; get; }
        private decimal totalPrice;
        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; OnPropertyChanged(nameof(TotalPrice)); }
        }

        public ProductViewModel(Category category):this()
        {
            var all = Products.ToList();
            Products.Clear();
            foreach (var item in all)
            {
                if (item.CategoryId==category.Id)
                {
                    Products.Add(item);
                }
            }
        }
        public ProductViewModel()
        {

            OpenBasketCommand = new Command (OpenBasket);
            AddListCommand = new Command<Product>(AddIteam);
            DetailsCommand = new Command<Product>(Details);


            Products = new ObservableCollection<Product>()
            {    //Boot 
                 new Product
                 {
                     CategoryId =1,
                     Name ="Boot",
                     Size ="40",
                     Price = 70,
                     ImageUrl="https://cdn.shopify.com/s/files/1/0252/3276/9072/products/wolf-lace-up-boot-890199_800x.jpg?v=1617589821"
                 },
                 new Product
                 {
                     CategoryId =1,
                     Name ="Boot",
                     Size ="45",
                     Price = 100,
                     ImageUrl="https://images.timberland.com/is/image/timberland/10361024-HERO?wid=500&hei=500"
                 },
                  new Product
                 {
                     CategoryId =1,
                     Name ="Boot",
                     Size ="42",
                     Price = 70,
                     ImageUrl="https://pyxis.nymag.com/v1/imgs/a31/e97/8eba14655e250e161bf9f67f2ef3a33e3d-aacp-ankle-boots-3.2x.rsquare.w600.jpg"
                 },

                 //Shirts
                 new Product
                 {
                     CategoryId =2,
                     Name ="Shirt",
                     Size ="XL",
                     Price = 30,
                     ImageUrl="https://www.sneak-a-venue.com/files/image/id/52145/fixed/1/w/2000/h/2000/n/champion-reverse-weave-crewneck-t-shirt-yellow-210971-ys001-1.jpg"
                  },
                 new Product
                 {
                     CategoryId =2,
                     Name ="Shirt",
                     Size ="M",
                     Price = 70,
                     ImageUrl="https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg"
                  },

                 //Jakets
                 new Product
                 {
                     CategoryId=3,
                     Name ="Jacket",
                     Size ="L",
                     Price = 50,
                     ImageUrl="https://rohan.imgix.net/product/05668P21.jpg?w=2500&auto=format&q=77"
                 },
                 new Product
                 {
                     CategoryId=3,
                     Name ="Jacket",
                     Size ="XXL",
                     Price = 40,
                     ImageUrl="https://ae01.alicdn.com/kf/HTB1bqTcQXXXXXbFXFXXq6xXFXXXX/2017New-spring-mens-jackets-and-coats-Army-green-fashion-jaket-veste-homme-autumn-men-black-Mandarin.jpg_640x640.jpg"
                 },

                 //Caps
                 new Product
                 {
                     CategoryId=4,
                     Name ="Cap",
                     Size ="Small",
                     Price = 10,
                     ImageUrl="https://www.efootwear.eu/media/catalog/product/cache/image/650x650/4/0/4062055497552_1_.jpg"
                 },
                 new Product
                 {
                     CategoryId=4,
                     Name ="Cap",
                     Size ="Medium",
                     Price = 15,
                     ImageUrl="https://image.made-in-china.com/202f0j00rSeQPMGRuIUz/Custom-Plain-Blank-6-Panel-Sports-Blue-Baseball-Cap-Cap-Hat.jpg"
                 },


                 //Bags
                  new Product
                 {
                     CategoryId=5,
                     Name ="Bag",
                     Size ="Medium",
                     Price = 30,
                     ImageUrl ="https://5.imimg.com/data5/RK/LT/MY-2379745/rexine-school-bag-500x500.png"
                 },
                  new Product
                 {
                     CategoryId=5,
                     Name ="Bag",
                     Size ="Small",
                     Price = 22,
                     ImageUrl ="https://target.scene7.com/is/image/Target/GUEST_9c2a3793-30c8-4b85-af99-5a1806facf25?wid=488&hei=488&fmt=pjpeg"
                 }
            };
            Products.CollectionChanged += Products_CollectionChanged;
        }

        private void OpenBasket()
        {
            App.Current.MainPage.Navigation.PushModalAsync(new Views.BasketPage());
        }

        private void Products_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
             TotalPrice  = Products.Sum(a=>a.Price); 
        }

        private void Details(Product obj)
        {
            App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage( new Views.Details(AddListCommand, obj)));
        }

        protected virtual   void AddIteam(Product obj)
        {
           
            Products.Add(obj);

            
        }





    }
}
