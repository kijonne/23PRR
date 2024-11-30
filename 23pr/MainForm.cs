using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23pr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Добро пожаловать\n{DateTime.Now}", "Приветствие");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть форму?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void buttonTaskThree_Click(object sender, EventArgs e)
        {
            Ex3 ex3 = new Ex3();
            ex3.ShowDialog();
        }

        private void buttonTaskFour_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
        }

        private void buttonTaskTwo_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.ShowDialog();
        }
    }
}
