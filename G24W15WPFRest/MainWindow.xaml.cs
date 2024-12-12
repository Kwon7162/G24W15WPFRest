using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace G24W15WPFRest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private GameViewModel vm = new GameViewModel();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = vm; //반드시 연결, 시험출제 가능

        //GameGrid.ItemsSource = vm.Games;

        InitializeGames();
    }

    private async void InitializeGames()
    {
        await vm.GetGames();
    }

    public void StartWebBrowser(object sender, EventArgs e)
    {
        string url = (string)((Button)sender).Tag;
        Process.Start(
            new ProcessStartInfo("cmd", $"/c start {url}")
            {
                CreateNoWindow = true
            }
        );
    }
}