using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasker.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        public Details(Product product)
        {

            InitializeComponent();
            Product = product;
            BindingContext = product;
        }

        public Product Product { get; }
    }
}