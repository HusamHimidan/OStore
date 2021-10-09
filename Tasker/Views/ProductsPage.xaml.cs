using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : TabbedPage
    {
        public ProductsPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ProductViewModel();
        }
    }
}