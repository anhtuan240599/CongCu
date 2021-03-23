using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongCu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Dang nhap thanh cong");
                Form2 fr = new Form2();
                fr.Show();
                
                
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }
        
         
    }
}
