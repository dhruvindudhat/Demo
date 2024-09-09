using System.ComponentModel;

namespace Demo;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public MainPage()
    {
        InitializeComponent();
        //Started.IsVisible = true;
        //Ended.IsVisible = false;
    }

    public void ChangeText(System.Object sender, System.EventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            //Started.IsVisible = !Started.IsVisible;
            //Ended.IsVisible = !Ended.IsVisible;
        });
    }
}

