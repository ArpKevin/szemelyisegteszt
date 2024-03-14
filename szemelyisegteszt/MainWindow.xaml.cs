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

namespace szemelyisegteszt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = "nem töltötte ki";
            // Neved (TextBox)
            string neved = string.IsNullOrEmpty(txbAlias.Text) ? szoveg : txbAlias.Text;

            // E-mail címed (TextBox)
            string email = string.IsNullOrEmpty(txbEMail.Text) ? szoveg : txbEMail.Text;

            // Szabadidő
            string szabadido = szoveg;

            foreach (var radioButton in stackpanelSzabadido.Children.OfType<RadioButton>())
            {
                if (radioButton.IsChecked == true)
                {
                    szabadido = radioButton.Content.ToString();
                    break;
                }
            }

            // Film
            string film = szoveg;
            if (listBoxFilmek.SelectedItem != null)
            {
                var selectedListBoxItem = listBoxFilmek.SelectedItem;

                if (selectedListBoxItem is ListBoxItem listBoxItem)
                    film = listBoxItem.Content.ToString();
                else
                    film = selectedListBoxItem.ToString();
            }

            // Stressz
            string stressz = szoveg;

            var checkedElementStressz = wrapPanelStressz.Children
                .OfType<CheckBox>()
                .Where(cb => cb.IsChecked == true)
                .Select(cb => cb.Content)
                .ToList();

            if (checkedElementStressz.Count > 0)
            {
                stressz = string.Join(", ", checkedElementStressz);
            }

            // Stílus
            string stilus = szoveg;
            var checkedElementStilus = stackpanelStilus.Children
                .OfType<CheckBox>()
                .Where(cb => cb.IsChecked == true)
                .Select(cb => cb.Content)
                .ToList();

            if (checkedElementStilus.Count > 0)
            {
                stilus = string.Join(", ", checkedElementStilus);
            }

            // Környezet
            string kornyezet = szoveg;
            if (comboboxKorny.SelectedItem != null)
            {
                var selectedComboboxItem = comboboxKorny.SelectedItem;
                kornyezet = (selectedComboboxItem is ComboBoxItem comboBoxItem)
                    ? comboBoxItem.Content.ToString()
                    : kornyezet = selectedComboboxItem.ToString();
            }

            AnswersWindow values = new AnswersWindow(neved, email, szabadido, film, stressz, stilus, kornyezet);
            values.Show();
            this.Hide();
        }
    }
}