using System.Linq;
using Tasker.Models;
using Tasker.Views;
using Xamarin.Forms;

namespace Tasker.ViewModels
{
    public class BasketViewModel : ProductViewModel
    {
        public static BasketViewModel Default { get; } = new BasketViewModel();

        public BasketViewModel()
        {
            RemoveFromListCommand = new Command<Product>(RemoveFromList);
            Products.Clear();
        }
        protected override async void AddIteam(Product obj)
        {
            base.AddIteam(obj);
            if (App.Current.MainPage.Navigation.ModalStack.Any(a => a is Views.Details))
            {
                await App.Current.MainPage.Navigation.PopModalAsync();
            }
        }
        private void RemoveFromList(Product obj)
        {
            this.Products.Remove(obj);
        }

        public Command RemoveFromListCommand { set; get; }

    }
}
