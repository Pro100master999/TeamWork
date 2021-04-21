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
    public partial class Изменить_данные : Form
    {
        public Model1 db { get; set; }
        public Avtom av { get; set; }



        public Изменить_данные()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Изменить_данные frm = new Изменить_данные();
            av.Owner = textBox2.Text;
            av.Marka = textBox3.Text;
            av.Age = Convert.ToInt32(textBox4.Text);
            try
            {
                // сохраняем изменения, сделанные в объектах коллекции в БД
                
                db.SaveChanges();
                MessageBox.Show("Данные изменены");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void Изменить_данные_Load(object sender, EventArgs e)
        {
            //auto.Owner = textBox2.Text;
            //textBox1.Text = auto.Nomer.ToString();
            //textBox2.Text = auto.Owner;
            //textBox3.Text = auto.Marka;
            //textBox4.Text = auto.Age.ToString();
        }
    }
}
