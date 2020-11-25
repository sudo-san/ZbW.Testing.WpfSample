using System.Windows;
using ZbW.Testing.WpfSample.Client.ViewModels;

namespace ZbW.Testing.WpfSample.Client.Views
{
    /// <summary>
    ///     Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
        }
    }
}