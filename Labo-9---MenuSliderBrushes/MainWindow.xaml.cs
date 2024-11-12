using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_9___MenuSliderBrushes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeMenu_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bent u zeker dat u wel afsluiten?", "Afsluiten",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }

        }
        private void eersteGetal_Click(object sender, RoutedEventArgs e)
        {
            numberOneTextBox.Text = "2";
        }
        private void tweedeGetal_Click(object sender, RoutedEventArgs e)
        {
            numberTwoTextBox.Text = "2";
        }
        private void valueChanged_Tick(object sender, EventArgs e)
        {
            if (sender is Slider slider)
            {
                if (slider.Name == "schuifregelaarEen")
                {
                    numberOneTextBox.Text = slider.Value.ToString();
                }
                if (slider.Name == "schuifregelaarTwee")
                {
                    numberTwoTextBox.Text = slider.Value.ToString();
                }
            }
        }
        private void ookDeSliderBro(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Name == "numberOneTextBox" && double.TryParse(numberOneTextBox.Text, out double value1))
                {
                    schuifregelaarEen.Value = value1;
                }
                else if (textBox.Name == "numberTwoTextBox" && double.TryParse(numberTwoTextBox.Text, out double value2))
                {
                    schuifregelaarTwee.Value = value2;
                }

            }
        }
    }
}