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
            // Neved (TextBox)
            string neved = string.IsNullOrEmpty(txbAlias.Text) ? "nem töltötte ki" : txbAlias.Text;

            // E-mail címed (TextBox)
            string email = string.IsNullOrEmpty(txbEMail.Text) ? "nem töltötte ki" : txbEMail.Text;

            // Szabdidő
            string szabadido = "nem töltötte ki";

            foreach (var radioButton in wrappanelSzabadido.Children.OfType<RadioButton>())
            {
                if (radioButton.IsChecked == true)
                {
                    szabadido = radioButton.Content.ToString();
                    break;
                }
            }

            txbAlias.Text = szabadido;

            // Film
            string film = string.Empty;
            if (listBoxFilmek.SelectedItem != null)
            {
                var selectedListBoxItem = listBoxFilmek.SelectedItem;

                if (selectedListBoxItem is ListBoxItem listBoxItem)
                    film = listBoxItem.Content.ToString();
                else
                    film = selectedListBoxItem.ToString();
            }
            else
            {
                film = "nem töltötte ki";
            }

            // Stressz
            string stressz = string.Empty;


            // Stílus
            string stilus = string.Empty;
            var checkedElementCount = stackpanelStilus.Children
                .OfType<CheckBox>()
                .Where(cb => cb.IsChecked == true)
                .Select(cb => cb.Content)
                .ToList();

            if (checkedElementCount.Count == 0)
            {
                stilus = "nem töltötte ki";
            }
            else
            {
                stilus = string.Join(", ", checkedElementCount);
            }

            // Környezet
            string kornyezet = string.Empty;
            if (comboboxKorny.SelectedItem != null)
            {
                var selectedComboboxItem = comboboxKorny.SelectedItem;
                if (selectedComboboxItem is ComboBoxItem comboBoxItem)
                    stressz = comboBoxItem.Content.ToString();
                else
                    stressz = selectedComboboxItem.ToString();
            }
        }

    }
}