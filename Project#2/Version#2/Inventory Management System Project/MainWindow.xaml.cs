using System.Windows;

namespace InventoryManagementSystem
{
    public partial class InventoryWindow : Window
    {
        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void FeatureList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Get the selected feature from the list
            var selectedItem = FeatureList.SelectedItem as System.Windows.Controls.ListBoxItem;
            if (selectedItem != null)
            {
                string featureName = selectedItem.Content.ToString();

                // Open the corresponding form based on the feature selected
                switch (featureName)
                {
                    case "Real-Time Stock Updates":
                        RealTimeStockUpdatesWindow stockWindow = new RealTimeStockUpdatesWindow();
                        stockWindow.Show();
                        break;

                    case "Product Registration":
                        ProductRegistrationWindow registrationWindow = new ProductRegistrationWindow();
                        registrationWindow.Show();
                        break;

                    case "Order Management":
                        OrderManagementWindow orderWindow = new OrderManagementWindow();
                        orderWindow.Show();
                        break;

                    case "Reporting and Analytics":
                        ReportingAnalyticsWindow reportingWindow = new ReportingAnalyticsWindow();
                        reportingWindow.Show();
                        break;

                    // Add more cases for other features
                    default:
                        MessageBox.Show("Feature not implemented yet.");
                        break;
                }
            }
        }
    }
}
