namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.virgula = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.impartire = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.inmultire = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.egal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.virgula, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.b0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.impartire, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.b3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.b6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inmultire, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.b9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.egal, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.SystemColors.ControlDark;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.virgula.Location = new System.Drawing.Point(419, 348);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(202, 109);
            this.virgula.TabIndex = 14;
            this.virgula.Text = ".";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.punct_click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b0.Location = new System.Drawing.Point(211, 348);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(202, 109);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_click);
            // 
            // impartire
            // 
            this.impartire.BackColor = System.Drawing.SystemColors.ControlDark;
            this.impartire.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.impartire.Location = new System.Drawing.Point(3, 348);
            this.impartire.Name = "impartire";
            this.impartire.Size = new System.Drawing.Size(202, 109);
            this.impartire.TabIndex = 12;
            this.impartire.Text = "/";
            this.impartire.UseVisualStyleBackColor = false;
            this.impartire.Click += new System.EventHandler(this.impartire_click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.plus.Location = new System.Drawing.Point(627, 233);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(202, 109);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b3.Location = new System.Drawing.Point(419, 233);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(202, 109);
            this.b3.TabIndex = 10;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b2.Location = new System.Drawing.Point(211, 233);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(202, 109);
            this.b2.TabIndex = 9;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b1.Location = new System.Drawing.Point(3, 233);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(202, 109);
            this.b1.TabIndex = 8;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.minus.Location = new System.Drawing.Point(627, 118);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(202, 109);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b6.Location = new System.Drawing.Point(419, 118);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(202, 109);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b5.Location = new System.Drawing.Point(211, 118);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(202, 109);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b4.Location = new System.Drawing.Point(3, 118);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(202, 109);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_click);
            // 
            // inmultire
            // 
            this.inmultire.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inmultire.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.inmultire.Location = new System.Drawing.Point(627, 3);
            this.inmultire.Name = "inmultire";
            this.inmultire.Size = new System.Drawing.Size(202, 109);
            this.inmultire.TabIndex = 3;
            this.inmultire.Text = "*";
            this.inmultire.UseVisualStyleBackColor = false;
            this.inmultire.Click += new System.EventHandler(this.inmultit_click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b9.Location = new System.Drawing.Point(419, 3);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(202, 109);
            this.b9.TabIndex = 2;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.b8.Location = new System.Drawing.Point(211, 3);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(202, 109);
            this.b8.TabIndex = 1;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(3, 3);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(202, 109);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_click);
            // 
            // egal
            // 
            this.egal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.egal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.egal.Location = new System.Drawing.Point(627, 348);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(202, 109);
            this.egal.TabIndex = 15;
            this.egal.Text = "=";
            this.egal.UseVisualStyleBackColor = false;
            this.egal.Click += new System.EventHandler(this.egal_click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 469);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 78);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 67);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.Location = new System.Drawing.Point(627, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "DEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.del_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 546);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button impartire;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button inmultire;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

