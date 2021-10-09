using System.ComponentModel;

namespace Tasker.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
