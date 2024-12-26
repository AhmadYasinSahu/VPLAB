using System.Windows;
using System.Windows.Controls;

namespace InventoryManagementSystem
{
    public partial class InventoryWindow : Window
    {
        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void FeatureList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FeatureList.SelectedItem != null)
            {
                string selectedFeature = (FeatureList.SelectedItem as ListBoxItem)?.Content.ToString();
                DisplayFeatureDetails(selectedFeature);
            }
        }

        private void DisplayFeatureDetails(string feature)
        {
            switch (feature)
            {
                case "Real-Time Stock Updates":
                    FeatureTitle.Text = "Real-Time Stock Updates";
                    FeatureDetails.Text = "Automatically updates stock levels when sales, purchases, or returns occur, "
                                        + "ensuring accurate inventory tracking at all times.";
                    break;

                case "Multi-Location Support":
                    FeatureTitle.Text = "Multi-Location Support";
                    FeatureDetails.Text = "Track inventory seamlessly across multiple warehouses or store locations, "
                                        + "providing consolidated reports for effective management.";
                    break;

                case "Product Registration":
                    FeatureTitle.Text = "Product Registration";
                    FeatureDetails.Text = "Add, update, or remove product details including SKU, category, price, "
                                        + "and other essential information for comprehensive management.";
                    break;

                case "Barcode Integration":
                    FeatureTitle.Text = "Barcode Integration";
                    FeatureDetails.Text = "Easily generate and scan barcodes for quick product identification, "
                                        + "speeding up inventory processes.";
                    break;

                case "Order Management":
                    FeatureTitle.Text = "Order Management";
                    FeatureDetails.Text = "Create, track, and manage purchase and customer orders seamlessly, "
                                        + "while linking them to stock levels for automatic updates.";
                    break;

                case "Reporting and Analytics":
                    FeatureTitle.Text = "Reporting and Analytics";
                    FeatureDetails.Text = "Generate detailed reports on inventory levels, sales trends, and purchases "
                                        + "to aid in decision-making and strategic planning.";
                    break;

                case "Stock Control":
                    FeatureTitle.Text = "Stock Control";
                    FeatureDetails.Text = "Manage inventory in/out transactions effectively, track stock transfers "
                                        + "between locations, and monitor adjustments due to shrinkage.";
                    break;

                default:
                    FeatureTitle.Text = "Welcome to Inventory Management System";
                    FeatureDetails.Text = "Select a feature from the sidebar to view details.";
                    break;
            }
        }
    }
}
