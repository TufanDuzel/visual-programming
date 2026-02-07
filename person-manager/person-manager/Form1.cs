using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace person_manager
{
    public partial class Form1 : Form
    {
        string filePath = "person.json";

        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click; // Save
            button2.Click += button2_Click; // Load
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int age;

            if (!int.TryParse(textBox3.Text, out age) || age < 0)
            {
                MessageBox.Show("Age must be a non-negative number");
                return;
            }

            Person p = new Person();
            p.FirstName = textBox1.Text;
            p.LastName = textBox2.Text;
            p.Age = age;

            string json = JsonSerializer.Serialize(p);
            File.WriteAllText(filePath, json);

            MessageBox.Show("Saved successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File not found");
                return;
            }

            string json = File.ReadAllText(filePath);
            Person p = JsonSerializer.Deserialize<Person>(json);

            textBox1.Text = p.FirstName;
            textBox2.Text = p.LastName;
            textBox3.Text = p.Age.ToString();
        }
    }

    // MODEL
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
