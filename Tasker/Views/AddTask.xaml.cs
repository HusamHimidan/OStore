using Tasker.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTask : ContentPage
    {
        private readonly TasksViewModel tasksViewModel;



        public AddTask(TasksViewModel tasksViewModel)
        {
            this.tasksViewModel = tasksViewModel;
            InitializeComponent();
            BindingContext = tasksViewModel;
            tasksViewModel.OnAdd -= TasksViewModel_OnAdd;
            tasksViewModel.OnAdd += TasksViewModel_OnAdd;
        }

        private async void TasksViewModel_OnAdd(object sender, System.EventArgs e)
        {
            try
            {
                await App.Current.MainPage.Navigation.PopModalAsync();

            }
            catch (System.Exception)
            {
                 
            }
        }
    }
}