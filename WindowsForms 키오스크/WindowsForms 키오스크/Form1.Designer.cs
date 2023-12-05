using System;
using System.Windows.Forms;

namespace WindowsForms_키오스크
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        // 총 결제금액을 저장하는 변수
        private decimal totalAmount = 0;

       

        private void UpdateTotalAmountLabel()
        {
            // 레이블에 총 결제금액 업데이트
            TotalAmountLabel.Text = "총 결제금액: {totalAmount:C}원";
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            // 결제 버튼 클릭 시 이벤트 처리
            // 여기에 실제 결제 로직을 추가하면 됩니다.
            MessageBox.Show($"카드 또는 현금을 삽입해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 결제가 완료되면 총 결제금액 초기화
            totalAmount = 0;
            UpdateTotalAmountLabel();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            // 이전 버튼 클릭 시 이벤트 처리
            // 여기에 이전 화면으로 이동하는 로직을 추가하면 됩니다.
            MessageBox.Show("이전 화면으로 이동합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 키오스크 폼 초기화 메서드
        private void InitializeComponent()
        {
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalAmountLabel.Location = new System.Drawing.Point(169, 54);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(183, 25);
            this.TotalAmountLabel.TabIndex = 2;
            this.TotalAmountLabel.Text = "총 결제금액: 0.00원";
            // 
            // PaymentButton
            // 
            this.PaymentButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PaymentButton.Location = new System.Drawing.Point(334, 368);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(150, 40);
            this.PaymentButton.TabIndex = 1;
            this.PaymentButton.Text = "결제";
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PreviousButton.Location = new System.Drawing.Point(39, 364);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(150, 44);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "이전";
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(39, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "포인트 적립";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "포인트 적립을 원하는 경우 적립 버튼을 먼저 눌러주세요.";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(530, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.TotalAmountLabel);
            this.Name = "Form1";
            this.Text = "키오스크 애플리케이션";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button PreviousButton;
        private Button button1;
        private Label label1;
    }
}
