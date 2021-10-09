using System;
using Xamarin.Forms;

namespace Tasker.ViewModels
{
    public class AddProductViewModel : BaseViewModel
    {
        public AddProductViewModel(ViewModels.ProductViewModel productViewModel)
        {
            SaveCommand = new Command(Save,CanSave);
            this.productViewModel = productViewModel;
        }

        private bool CanSave(   )
        {
            if (string.IsNullOrEmpty(Name))
            {
                return false;
            }
            if (Price<=0)
            {
                return false;
            }
            return true;
        }

        private void Save(   )
        {
            productViewModel.Products.Add(new Models.Product() { Name=this.Name,Price=this.Price });
            try
            {
                App.Current.MainPage.Navigation.PopModalAsync();
            }
            catch (Exception)
            {
                 
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; SaveCommand.ChangeCanExecute(); }
        }

        private decimal price;
        private readonly ProductViewModel productViewModel;

        public decimal Price
        {
            get { return price; }
            set { price = value; SaveCommand.ChangeCanExecute();  }
        }


        public Command SaveCommand { get; }
    }
}
