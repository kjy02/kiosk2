using System;
using System.Windows.Forms;

namespace WindowsForms_키오스크
{
    public partial class Form2 : Form
    {
        private TextBox phoneNumberTextBox;

        
        private void InitializeComponent()
        {
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(50, 50);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.phoneNumberTextBox.TabIndex = 0;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(50, 100);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 30);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "확인";
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(150, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "취소";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "Form2";
            this.Text = "전화번호 입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            MessageBox.Show($"입력된 전화번호: {phoneNumber}", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Button okButton;
        private Button cancelButton;
    }
}
