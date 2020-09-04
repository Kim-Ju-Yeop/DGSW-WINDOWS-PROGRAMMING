namespace register
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idOverlapping = new System.Windows.Forms.Label();
            this.pwTextbox = new System.Windows.Forms.TextBox();
            this.pwTexbox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pwMatching = new System.Windows.Forms.Label();
            this.generalCheckBox = new System.Windows.Forms.ComboBox();
            this.snsCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::register.Properties.Resources._1280px_Naver_Logotype_svg;
            this.pictureBox1.Location = new System.Drawing.Point(136, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(45, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "비밀번호 확인 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(48, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "성별 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(48, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "SNS 수신동의 :";
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(213, 166);
            this.idTextbox.Multiline = true;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(424, 47);
            this.idTextbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(213, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "아이디 중복체크";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.checkIdOverlapping);
            // 
            // idOverlapping
            // 
            this.idOverlapping.AutoSize = true;
            this.idOverlapping.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idOverlapping.Location = new System.Drawing.Point(414, 246);
            this.idOverlapping.Name = "idOverlapping";
            this.idOverlapping.Size = new System.Drawing.Size(0, 21);
            this.idOverlapping.TabIndex = 9;
            // 
            // pwTextbox
            // 
            this.pwTextbox.Location = new System.Drawing.Point(213, 305);
            this.pwTextbox.Multiline = true;
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.Size = new System.Drawing.Size(424, 47);
            this.pwTextbox.TabIndex = 10;
            // 
            // pwTexbox2
            // 
            this.pwTexbox2.Location = new System.Drawing.Point(213, 369);
            this.pwTexbox2.Multiline = true;
            this.pwTexbox2.Name = "pwTexbox2";
            this.pwTexbox2.Size = new System.Drawing.Size(424, 47);
            this.pwTexbox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(213, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "비밀번호 일치 확인";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.checkMatchPw);
            // 
            // pwMatching
            // 
            this.pwMatching.AutoSize = true;
            this.pwMatching.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwMatching.Location = new System.Drawing.Point(424, 451);
            this.pwMatching.Name = "pwMatching";
            this.pwMatching.Size = new System.Drawing.Size(0, 21);
            this.pwMatching.TabIndex = 13;
            // 
            // generalCheckBox
            // 
            this.generalCheckBox.FormattingEnabled = true;
            this.generalCheckBox.Location = new System.Drawing.Point(213, 504);
            this.generalCheckBox.Name = "generalCheckBox";
            this.generalCheckBox.Size = new System.Drawing.Size(424, 20);
            this.generalCheckBox.TabIndex = 14;
            // 
            // snsCheckBox
            // 
            this.snsCheckBox.AutoSize = true;
            this.snsCheckBox.Location = new System.Drawing.Point(213, 556);
            this.snsCheckBox.Name = "snsCheckBox";
            this.snsCheckBox.Size = new System.Drawing.Size(52, 16);
            this.snsCheckBox.TabIndex = 15;
            this.snsCheckBox.Text = " 동의";
            this.snsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(49, 606);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(588, 91);
            this.button3.TabIndex = 16;
            this.button3.Text = "가입하기";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.clickRegister);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 739);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.snsCheckBox);
            this.Controls.Add(this.generalCheckBox);
            this.Controls.Add(this.pwMatching);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pwTexbox2);
            this.Controls.Add(this.pwTextbox);
            this.Controls.Add(this.idOverlapping);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idOverlapping;
        private System.Windows.Forms.TextBox pwTextbox;
        private System.Windows.Forms.TextBox pwTexbox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label pwMatching;
        private System.Windows.Forms.ComboBox generalCheckBox;
        private System.Windows.Forms.CheckBox snsCheckBox;
        private System.Windows.Forms.Button button3;
    }
}

