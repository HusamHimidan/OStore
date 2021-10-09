using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Tasker.Models;
using Tasker.Views;
using Xamarin.Forms;

namespace Tasker.ViewModels
{
    public class TasksViewModel : INotifyPropertyChanged
    {
        public event EventHandler OnAdd;
        public Task Task { get; set; }
        public Command AddCommand { get; set; }
        public Command OpenAddPageCommand { get; set; }
        public Command RemoveCommand { get; set; }
        public Command FinishCommand { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
        public ObservableCollection<Task> FinishedTasks { get; set; }
        public TasksViewModel()
        {
            AddCommand = new Command(Add);
            RemoveCommand = new Command<Task>(Remove);
            FinishCommand = new Command<Task>(Finish);
            OpenAddPageCommand = new Command(OpenAddPage);
            Task = new  Task();
            Tasks = new ObservableCollection<Task>();
            FinishedTasks = new ObservableCollection<Task>();
        }

        private void OpenAddPage(   )
        {
            App.Current.MainPage.Navigation.PushModalAsync(new AddTask(this));
        }

        private void Finish(Task obj)
        {
            Remove(obj);
            FinishedTasks.Add(obj);
        }

        private void Remove(Task obj)
        {
            Tasks.Remove(obj);
        }

        private void Add()
        {
            Tasks.Add(Task);
            Task = new  Task();
            OnAdd?.Invoke(this, null);
        }
        
        protected void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
