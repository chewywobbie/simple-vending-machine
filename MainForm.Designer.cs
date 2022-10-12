namespace step1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.tbName3 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.tbColor1 = new System.Windows.Forms.TextBox();
            this.tbColor2 = new System.Windows.Forms.TextBox();
            this.tbColor3 = new System.Windows.Forms.TextBox();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnSelect3 = new System.Windows.Forms.Button();
            this.txRemainder = new System.Windows.Forms.TextBox();
            this.btnCharge = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "품명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "가격 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "색상 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(21, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "잔액 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(21, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "결과 :";
            // 
            // tbName1
            // 
            this.tbName1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbName1.Location = new System.Drawing.Point(103, 16);
            this.tbName1.Name = "tbName1";
            this.tbName1.ReadOnly = true;
            this.tbName1.Size = new System.Drawing.Size(72, 27);
            this.tbName1.TabIndex = 1;
            this.tbName1.Text = "콜라";
            this.tbName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName2
            // 
            this.tbName2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbName2.Location = new System.Drawing.Point(189, 16);
            this.tbName2.Name = "tbName2";
            this.tbName2.ReadOnly = true;
            this.tbName2.Size = new System.Drawing.Size(72, 27);
            this.tbName2.TabIndex = 1;
            this.tbName2.Text = "맥주";
            this.tbName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName3
            // 
            this.tbName3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbName3.Location = new System.Drawing.Point(277, 16);
            this.tbName3.Name = "tbName3";
            this.tbName3.ReadOnly = true;
            this.tbName3.Size = new System.Drawing.Size(72, 27);
            this.tbName3.TabIndex = 1;
            this.tbName3.Text = "삼다수";
            this.tbName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrice1.Location = new System.Drawing.Point(103, 49);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.ReadOnly = true;
            this.txtPrice1.Size = new System.Drawing.Size(72, 27);
            this.txtPrice1.TabIndex = 1;
            this.txtPrice1.Text = "1600";
            this.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrice2.Location = new System.Drawing.Point(189, 49);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.ReadOnly = true;
            this.txtPrice2.Size = new System.Drawing.Size(72, 27);
            this.txtPrice2.TabIndex = 1;
            this.txtPrice2.Text = "2500";
            this.txtPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice3
            // 
            this.txtPrice3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrice3.Location = new System.Drawing.Point(277, 49);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.ReadOnly = true;
            this.txtPrice3.Size = new System.Drawing.Size(72, 27);
            this.txtPrice3.TabIndex = 1;
            this.txtPrice3.Text = "600";
            this.txtPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColor1
            // 
            this.tbColor1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbColor1.Location = new System.Drawing.Point(103, 82);
            this.tbColor1.Name = "tbColor1";
            this.tbColor1.ReadOnly = true;
            this.tbColor1.Size = new System.Drawing.Size(72, 27);
            this.tbColor1.TabIndex = 1;
            this.tbColor1.Text = "검정";
            this.tbColor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColor2
            // 
            this.tbColor2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbColor2.Location = new System.Drawing.Point(189, 82);
            this.tbColor2.Name = "tbColor2";
            this.tbColor2.ReadOnly = true;
            this.tbColor2.Size = new System.Drawing.Size(72, 27);
            this.tbColor2.TabIndex = 1;
            this.tbColor2.Text = "노랑";
            this.tbColor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbColor3
            // 
            this.tbColor3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbColor3.Location = new System.Drawing.Point(277, 82);
            this.tbColor3.Name = "tbColor3";
            this.tbColor3.ReadOnly = true;
            this.tbColor3.Size = new System.Drawing.Size(72, 27);
            this.tbColor3.TabIndex = 1;
            this.tbColor3.Text = "투명";
            this.tbColor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelect1
            // 
            this.btnSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.btnSelect1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(138)))), ((int)(((byte)(84)))));
            this.btnSelect1.FlatAppearance.BorderSize = 3;
            this.btnSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect1.Location = new System.Drawing.Point(103, 119);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(72, 32);
            this.btnSelect1.TabIndex = 2;
            this.btnSelect1.Text = "선택";
            this.btnSelect1.UseVisualStyleBackColor = false;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect);
            // 
            // btnSelect2
            // 
            this.btnSelect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.btnSelect2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(138)))), ((int)(((byte)(84)))));
            this.btnSelect2.FlatAppearance.BorderSize = 3;
            this.btnSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect2.Location = new System.Drawing.Point(189, 119);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(72, 32);
            this.btnSelect2.TabIndex = 2;
            this.btnSelect2.Text = "선택";
            this.btnSelect2.UseVisualStyleBackColor = false;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect);
            // 
            // btnSelect3
            // 
            this.btnSelect3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.btnSelect3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(138)))), ((int)(((byte)(84)))));
            this.btnSelect3.FlatAppearance.BorderSize = 3;
            this.btnSelect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect3.Location = new System.Drawing.Point(277, 119);
            this.btnSelect3.Name = "btnSelect3";
            this.btnSelect3.Size = new System.Drawing.Size(72, 32);
            this.btnSelect3.TabIndex = 2;
            this.btnSelect3.Text = "선택";
            this.btnSelect3.UseVisualStyleBackColor = false;
            this.btnSelect3.Click += new System.EventHandler(this.btnSelect);
            // 
            // txRemainder
            // 
            this.txRemainder.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txRemainder.Location = new System.Drawing.Point(103, 189);
            this.txRemainder.Name = "txRemainder";
            this.txRemainder.ReadOnly = true;
            this.txRemainder.Size = new System.Drawing.Size(72, 27);
            this.txRemainder.TabIndex = 1;
            this.txRemainder.Text = "0";
            this.txRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCharge
            // 
            this.btnCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.btnCharge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(138)))), ((int)(((byte)(84)))));
            this.btnCharge.FlatAppearance.BorderSize = 3;
            this.btnCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharge.Location = new System.Drawing.Point(181, 186);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(72, 32);
            this.btnCharge.TabIndex = 2;
            this.btnCharge.Text = "충전";
            this.btnCharge.UseVisualStyleBackColor = false;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(138)))), ((int)(((byte)(84)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(259, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "비우기";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(103, 227);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 42;
            this.dgvResult.RowTemplate.Height = 27;
            this.dgvResult.Size = new System.Drawing.Size(307, 123);
            this.dgvResult.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(438, 370);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSelect3);
            this.Controls.Add(this.btnCharge);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect1);
            this.Controls.Add(this.tbColor3);
            this.Controls.Add(this.tbColor2);
            this.Controls.Add(this.txtPrice3);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txRemainder);
            this.Controls.Add(this.tbColor1);
            this.Controls.Add(this.tbName3);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.tbName1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.TextBox tbName3;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.TextBox tbColor1;
        private System.Windows.Forms.TextBox tbColor2;
        private System.Windows.Forms.TextBox tbColor3;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Button btnSelect3;
        private System.Windows.Forms.TextBox txRemainder;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

