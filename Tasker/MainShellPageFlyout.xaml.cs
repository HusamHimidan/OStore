using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Tasker.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainShellPageFlyout : ContentPage
    {
        public ListView ListView;

        public MainShellPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MainShellPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MainShellPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainShellPageFlyoutMenuItem> MenuItems { get; set; }

            public MainShellPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MainShellPageFlyoutMenuItem>(new[]
                {
                    new MainShellPageFlyoutMenuItem
                    {
                        Id = 0,
                        Tag=new ViewModels.ProductViewModel(),
                        Title = "All Products",
                        TargetType=typeof(Views.ProductsPage)
                    },
                    new MainShellPageFlyoutMenuItem
                    {
                        Id = 1,
                        Tag=new ViewModels.ProductViewModel(new Category()   {
                         Id=1})
                    , Title = "Boots",TargetType=typeof(Views.ProductsPage)
                    },
                    new MainShellPageFlyoutMenuItem { Id = 2,
                        Tag=new ViewModels.ProductViewModel(new Category()   {
                          Id=2})
                    , Title = "Shirts",TargetType=typeof(Views.ProductsPage)
                    },
                     new MainShellPageFlyoutMenuItem { Id = 3,
                        Tag=new ViewModels.ProductViewModel(new Category()   {
                          Id=3})
                    , Title = "Jacket",TargetType=typeof(Views.ProductsPage)
                    },
                     new MainShellPageFlyoutMenuItem { Id = 4,
                        Tag=new ViewModels.ProductViewModel(new Category()   {
                         Id=4})
                    , Title = "Cap",TargetType=typeof(Views.ProductsPage)
                    }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                {
                    return;
                }

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}