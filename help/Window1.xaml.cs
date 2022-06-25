using System.Windows;

namespace help
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cat cat = new()
            {
                Name = NameTextBox.Text,
                Poroda = PorodaTextBox.Text,
                Birthday = BirthdayCalendar.SelectedDate
            };

            Database.AddCat(cat);

            Hide();
            new MainWindow().Show();
        }
    }
}
