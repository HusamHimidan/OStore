using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tasker.Models;
using Xamarin.Forms;

namespace Tasker.ViewModels
{
    public class ProductViewModel:BaseViewModel
    {
       
        public ObservableCollection<Models.Product> Products { get; set; }
        public ObservableCollection<Models.Product> Basket { get; set; }
        public Command AddCommand { get; }
        public Command AddListCommand { set; get; }
        public Command DetailsCommand { set; get; } 
        private decimal totalPrice;
        public Product Product { set; get; }
        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; OnPropertyChanged(nameof(TotalPrice)); }
        }
         

        public ProductViewModel()
        {
            AddListCommand = new Command<Product>(AddIteam);
            Basket = new ObservableCollection<Product>();
            DetailsCommand = new Command<Product>(Details);
               Products = new ObservableCollection<Models.Product>()
            {
                 new Models.Product
                 {
                     Name ="Boot",
                     Size ="43",
                     Price = 40,
                      ImageUrl="https://cdn.shopify.com/s/files/1/0252/3276/9072/products/wolf-lace-up-boot-890199_800x.jpg?v=1617589821"
                 },
                 new Models.Product
                 {
                     Name ="Shirt",
                     Size ="XL",
                     Price = 30,
                     ImageUrl="https://www.sneak-a-venue.com/files/image/id/52145/fixed/1/w/2000/h/2000/n/champion-reverse-weave-crewneck-t-shirt-yellow-210971-ys001-1.jpg"
                  },
                 new Models.Product
                 {
                     Name ="Jacket",
                     Size ="M",
                     Price = 50,
                     ImageUrl="https://rohan.imgix.net/product/05668P21.jpg?w=2500&auto=format&q=77"
                 },
                 new Models.Product
                 {
                     Name ="Cap",
                     Size ="Small",
                     Price = 10,
                     ImageUrl="https://www.efootwear.eu/media/catalog/product/cache/image/650x650/4/0/4062055497552_1_.jpg"
                 },
                  new Models.Product
                 {
                     Name ="Bag",
                     Size ="Medium",
                     Price = 30, 
                     ImageUrl ="https://5.imimg.com/data5/RK/LT/MY-2379745/rexine-school-bag-500x500.png"
                 }
            };
            AddCommand = new Command(Add);
            
        }

      
        private void Details(Product obj)
        {
            App.Current.MainPage.Navigation.PushModalAsync(new Views.Details(AddListCommand, obj));
        }

        private void AddIteam(Product obj)
        {   TotalPrice += obj.Price; 

            Basket.Add(obj);
         

        }

        private void Add()
        {
            App.Current.MainPage.Navigation.PushModalAsync(new Views.AddProductPage(new AddProductViewModel(this)));
        }

        
        
    }
}
