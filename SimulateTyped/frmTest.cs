using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulateTyped
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            radioButton2.Checked = true;
            numericUpDown1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com sucesso", "simulando");
        }
    }
}

/*
    code tested:

    First Name◘youremail@gmail.com◘02→05→1996◘→←◘ ◘↑↑↑↑↑↑↑↑↑↑◘↓↓↓◘Mwen◄◄◄ensagem de teste está◄a mensage←←←←←←←←←←←←←←→,→→→→→→→→→→→→→→→→m não é de utilizade nenhuma. Obrigado!◘◘▼     
 */
