using System.Collections.ObjectModel;
using System.Windows;

namespace help
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Cats = Database.GetCats();
        }

        public ObservableCollection<Cat> Cats { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Window1().Show();
        }
    }
}
