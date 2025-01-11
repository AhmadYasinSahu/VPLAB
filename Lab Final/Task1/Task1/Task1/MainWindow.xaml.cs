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
using System.Data.SqlClient;
using System.Data;
using System.Xaml;
using System.ComponentModel;
//using System.Windows.Controls;
namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            load();
        }

       SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V2IGCF7;Initial Catalog=StudentSRecord;Integrated Security=True;");

        public void clear()
        {
            name_txt.Clear();
            grade_txt.Clear();
            subject_txt.Clear();
            marks_txt.Clear();
            attendance_txt.Clear();
            id_txt.Clear();
        }
        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            clear();
      }
        public void load()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentList",con);
            DataTable dt = new DataTable();
            
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid.ItemsSource = dt.DefaultView;


        }

        public bool isValid()
        {
            if (name_txt.Text == string.Empty)
            {
                MessageBox.Show("Name is required.", " Failed", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            if (grade_txt.Text == string.Empty)
            {
                MessageBox.Show("Grade is required.", " Failed", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            if (subject_txt.Text == string.Empty)
            {
                MessageBox.Show("Subject is required.", " Failed", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            if (marks_txt.Text == string.Empty)
            {
                MessageBox.Show("Name is required.", " Failed", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            if (attendance_txt.Text == string.Empty)
            {
                MessageBox.Show("Name is required.", " Failed", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            return true;
        }

        private void insert_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("insert into StudentList values (@Name,@Grade,@Subject,@Marks,@AttendancePercentage)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                    cmd.Parameters.AddWithValue("@Grade", grade_txt.Text);
                    cmd.Parameters.AddWithValue("@Subject", subject_txt.Text);
                    cmd.Parameters.AddWithValue("@Marks", marks_txt.Text);
                    cmd.Parameters.AddWithValue("@AttendancePercentage", attendance_txt.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    load();
                    MessageBox.Show("Successfully inserted", "Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clear();
                load();
                con.Close();
            }
        }



    }
}
