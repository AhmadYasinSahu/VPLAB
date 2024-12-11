using System.Windows;
using System.Windows.Controls;

namespace WPFComboBoxControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                textBox.Text = selectedItem.Content.ToString();
            }
        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedItem is ComboBoxItem selectedItem)
            {
                textBox1.Text = selectedItem.Content.ToString();
            }
            else if (comboBox1.Text != string.Empty)
            {
                textBox1.Text = comboBox1.Text; // For editable ComboBox
            }
        }
    }
}