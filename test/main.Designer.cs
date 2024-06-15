namespace test
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Bingo = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "햄스터 퀴즈";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number.Location = new System.Drawing.Point(79, 109);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(39, 16);
            this.number.TabIndex = 1;
            this.number.Text = "학번";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num.Location = new System.Drawing.Point(124, 106);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(143, 26);
            this.num.TabIndex = 2;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(124, 162);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(143, 26);
            this.name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(79, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "이름";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Aqua;
            this.start.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start.Location = new System.Drawing.Point(124, 217);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(106, 37);
            this.start.TabIndex = 5;
            this.start.Text = "시작";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Bingo
            // 
            this.Bingo.AutoSize = true;
            this.Bingo.Location = new System.Drawing.Point(112, 312);
            this.Bingo.Name = "Bingo";
            this.Bingo.Size = new System.Drawing.Size(57, 12);
            this.Bingo.TabIndex = 6;
            this.Bingo.Text = "맞은 개수";
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Location = new System.Drawing.Point(112, 349);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(57, 12);
            this.wrong.TabIndex = 7;
            this.wrong.Text = "틀린 개수";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(140, 385);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(29, 12);
            this.score.TabIndex = 8;
            this.score.Text = "총점";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.score);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.Bingo);
            this.Controls.Add(this.start);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label Bingo;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Label score;
    }
}