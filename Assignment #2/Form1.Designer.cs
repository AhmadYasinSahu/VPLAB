using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment__02_
{
    public partial class Form1 : Form
    {
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;

        //public Form1()
        //{
        //    InitializeComponent();
        //}

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.richTextBox1 = new RichTextBox();
            this.checkBox1 = new CheckBox();
            this.radioButton1 = new RadioButton();
            this.comboBox1 = new ComboBox();
            this.numericUpDown1 = new NumericUpDown();
            this.dateTimePicker1 = new DateTimePicker();
            this.monthCalendar1 = new MonthCalendar();
            this.pictureBox1 = new PictureBox();

            // Button
            this.button1.Text = "Show Message";
            this.button1.Location = new Point(20, 20);
            this.button1.Click += new EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);

            // Label
            this.label1.Text = "Click me";
            this.label1.Location = new Point(20, 60);
            this.label1.Click += new EventHandler(this.label1_Click);
            this.Controls.Add(this.label1);

            // TextBox
            this.textBox1.Location = new Point(20, 100);
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            this.Controls.Add(this.textBox1);

            // RichTextBox
            this.richTextBox1.Location = new Point(20, 140);
            this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
            this.Controls.Add(this.richTextBox1);

            // CheckBox
            this.checkBox1.Text = "Check me";
            this.checkBox1.Location = new Point(20, 180);
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            this.Controls.Add(this.checkBox1);

            // RadioButton
            this.radioButton1.Text = "Radio Option";
            this.radioButton1.Location = new Point(20, 220);
            this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
            this.Controls.Add(this.radioButton1);

            // ComboBox
            this.comboBox1.Location = new Point(20, 260);
            this.comboBox1.Items.AddRange(new object[] { "Option 1", "Option 2", "Option 3" });
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Controls.Add(this.comboBox1);

            // NumericUpDown
            this.numericUpDown1.Location = new Point(20, 300);
            this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
            this.Controls.Add(this.numericUpDown1);

            // DateTimePicker
            this.dateTimePicker1.Location = new Point(20, 340);
            this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
            this.Controls.Add(this.dateTimePicker1);

            // MonthCalendar
            this.monthCalendar1.Location = new Point(20, 380);
            this.monthCalendar1.DateSelected += new DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.Controls.Add(this.monthCalendar1);

            // PictureBox
            this.pictureBox1.Location = new Point(20, 580);
            this.pictureBox1.Size = new Size(100, 100);
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            this.Controls.Add(this.pictureBox1);

            // Form settings
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 700);
            this.Text = "Form1";
        }

        // Event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!", "My MessageBox");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Label text changed";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked ? "Checked" : "Unchecked");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked ? "Radio Button 1" : "Not Radio Button 1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox clicked");
        }
    }
}
