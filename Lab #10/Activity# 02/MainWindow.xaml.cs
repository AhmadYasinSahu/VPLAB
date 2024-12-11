using System.Windows;
using System.Windows.Controls;

namespace WPFCheckBoxControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null)
            {
                if (cb.IsChecked == true)
                {
                    if (cb.Name == "checkBox1")
                        textBox1.Text = "Two States CheckBox is checked.";
                    else
                        textBox2.Text = "Three States CheckBox is checked.";
                }
            }
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null)
            {
                if (cb.IsChecked == false)
                {
                    if (cb.Name == "checkBox1")
                        textBox1.Text = "Two States CheckBox is unchecked.";
                    else
                        textBox2.Text = "Three States CheckBox is unchecked.";
                }
            }
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null && cb.IsThreeState && cb.IsChecked == null)
            {
                textBox2.Text = "Three States CheckBox is in indeterminate state.";
            }
        }
    }
}