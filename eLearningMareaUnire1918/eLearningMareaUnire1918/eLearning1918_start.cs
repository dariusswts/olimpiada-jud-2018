using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLearningMareaUnire1918
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email=txtEmail.Text;
            string parola=txtParola.Text;

            if (email == "elev@gmail.com" && parola == "12345")
            {
                eLearning1918_Elev f=new eLearning1918_Elev();
                f.Show();

            }
            else
            {
                MessageBox.Show("Eroare de autentificare!");
                txtEmail.Clear();
                txtParola.Clear();
            }

        }
    }
}
