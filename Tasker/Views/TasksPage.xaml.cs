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
    public partial class TasksPage : TabbedPage
    {
        public TasksPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.TasksViewModel();
        }
    }
}