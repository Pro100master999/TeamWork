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
    public partial class Form1 : Form
    {
        public Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Avtom". При необходимости она может быть перемещена или удалена.
            avtomBindingSource.DataSource = db.Avtom.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Переход на форму добавить данные
            Hide();
            Добавить_данные добавить = new Добавить_данные();
            добавить.db = db;
            добавить.ShowDialog();
            avtomBindingSource.DataSource = db.Avtom.ToList();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Изменить_данные изменить = new Изменить_данные();
            //Переход на форму изменить данные
            Hide();
            Avtom av = (Avtom)avtomBindingSource.Current;
            изменить.db = db;
            изменить.av = av;
            изменить.ShowDialog();
            avtomBindingSource.DataSource = db.Avtom.ToList();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Avtom av = (Avtom)avtomBindingSource.Current;
            db.Avtom.Remove(av);
            db.SaveChanges();
            avtomBindingSource.DataSource = db.Avtom.ToList();
            MessageBox.Show("Автомобилист удалён");
        }
    }
}
