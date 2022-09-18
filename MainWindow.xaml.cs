using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EksperymentowanieZKontrolkami
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string liczba = "Liczba: ";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = liczba+numberTextBox.Text;
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider)
            {
                number.Text = liczba + slider.Value.ToString("0");
            }
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
            number.Text =liczba+ radioButton.Content.ToString();   
            }
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = liczba + listBoxItem.Content.ToString();
            }
        }

        private void readonlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readonlyComboBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = liczba + listBoxItem.Content.ToString();
            }
        }

        private void editableComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                number.Text = liczba + comboBox.Text;
            }
        }

    }
}
