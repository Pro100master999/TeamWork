using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomobils
{
    public partial class Добавить_данные : Form
    {
        public Model1 db { get; set; }
        public Добавить_данные()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не все данные строки заполнены");
            }
            Avtom auto = new Avtom();
            auto.Nomer = Convert.ToInt32(textBox1.Text);
            auto.Owner = textBox2.Text;
            auto.Marka = textBox3.Text;
            auto.Age = Convert.ToInt32(textBox4.Text);
            db.Avtom.Add(auto);
            db.SaveChanges();
            MessageBox.Show("Автомобилист добавлен");
        }
    }
}
