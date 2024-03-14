using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace szemelyisegteszt
{
    /// <summary>
    /// Interaction logic for AnswersWindow.xaml
    /// </summary>
    public partial class AnswersWindow : Window
    {
        public AnswersWindow()
        {
            InitializeComponent();
        }
        public AnswersWindow(string neved, string email, string szabadido, string film, string stressz, string stilus, string kornyezet)
        {
            InitializeComponent();
            lblNev.Content = neved;
            lblEmail.Content = email;
            lblSzabadIdo.Content = szabadido;
            lblFilmek.Content = film;
            lblStressz.Content = stressz;
            lblKomm.Content = stilus;
            lblKorny.Content = kornyezet;
        }
    }
}
