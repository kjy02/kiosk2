using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_키오스크
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Close(); // 폼을 닫음
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close(); // 폼을 닫음
        }
    }
}