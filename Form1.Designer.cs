namespace Projekt2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pointX_textBox = new System.Windows.Forms.TextBox();
            this.pointY_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.popul_size_textbox = new System.Windows.Forms.TextBox();
            this.max_iter_textbox = new System.Windows.Forms.TextBox();
            this.mut_rate_textBox = new System.Windows.Forms.TextBox();
            this.cross_rate_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selection_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pointsArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.best1 = new System.Windows.Forms.TextBox();
            this.bestX = new System.Windows.Forms.TextBox();
            this.bestY = new System.Windows.Forms.TextBox();
            this.Diameter1 = new System.Windows.Forms.TextBox();
            this.drawer = new PointAndCircleDrawer();
            this.SuspendLayout();
            // 
            // pointX_textBox
            // 
            this.pointX_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pointX_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pointX_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointX_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pointX_textBox.Location = new System.Drawing.Point(69, 264);
            this.pointX_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.pointX_textBox.Multiline = true;
            this.pointX_textBox.Name = "pointX_textBox";
            this.pointX_textBox.Size = new System.Drawing.Size(49, 22);
            this.pointX_textBox.TabIndex = 1;
            // 
            // pointY_textBox
            // 
            this.pointY_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pointY_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pointY_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointY_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pointY_textBox.Location = new System.Drawing.Point(13, 264);
            this.pointY_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.pointY_textBox.Multiline = true;
            this.pointY_textBox.Name = "pointY_textBox";
            this.pointY_textBox.Size = new System.Drawing.Size(50, 22);
            this.pointY_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(10, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(66, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.Location = new System.Drawing.Point(13, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add new point";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // popul_size_textbox
            // 
            this.popul_size_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.popul_size_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.popul_size_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popul_size_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.popul_size_textbox.Location = new System.Drawing.Point(13, 105);
            this.popul_size_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.popul_size_textbox.Multiline = true;
            this.popul_size_textbox.Name = "popul_size_textbox";
            this.popul_size_textbox.Size = new System.Drawing.Size(105, 22);
            this.popul_size_textbox.TabIndex = 7;
            // 
            // max_iter_textbox
            // 
            this.max_iter_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.max_iter_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_iter_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.max_iter_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.max_iter_textbox.Location = new System.Drawing.Point(12, 66);
            this.max_iter_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.max_iter_textbox.Multiline = true;
            this.max_iter_textbox.Name = "max_iter_textbox";
            this.max_iter_textbox.Size = new System.Drawing.Size(105, 22);
            this.max_iter_textbox.TabIndex = 8;
            // 
            // mut_rate_textBox
            // 
            this.mut_rate_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.mut_rate_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mut_rate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mut_rate_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mut_rate_textBox.Location = new System.Drawing.Point(13, 30);
            this.mut_rate_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.mut_rate_textBox.Multiline = true;
            this.mut_rate_textBox.Name = "mut_rate_textBox";
            this.mut_rate_textBox.Size = new System.Drawing.Size(105, 22);
            this.mut_rate_textBox.TabIndex = 9;
            // 
            // cross_rate_textBox
            // 
            this.cross_rate_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cross_rate_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cross_rate_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cross_rate_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cross_rate_textBox.Location = new System.Drawing.Point(14, 146);
            this.cross_rate_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.cross_rate_textBox.Multiline = true;
            this.cross_rate_textBox.Name = "cross_rate_textBox";
            this.cross_rate_textBox.Size = new System.Drawing.Size(104, 22);
            this.cross_rate_textBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Population size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max iterations:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mutation rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label7.Location = new System.Drawing.Point(10, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Crossover rate:";
            // 
            // selection_comboBox
            // 
            this.selection_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.selection_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selection_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.selection_comboBox.FormattingEnabled = true;
            this.selection_comboBox.Items.AddRange(new object[] {
            "Elite",
            "Roulette",
            "Rank"});
            this.selection_comboBox.Location = new System.Drawing.Point(13, 222);
            this.selection_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selection_comboBox.Name = "selection_comboBox";
            this.selection_comboBox.Size = new System.Drawing.Size(105, 21);
            this.selection_comboBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label8.Location = new System.Drawing.Point(10, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Selection method:";
            // 
            // pointsArea
            // 
            this.pointsArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pointsArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pointsArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pointsArea.Location = new System.Drawing.Point(128, 11);
            this.pointsArea.Margin = new System.Windows.Forms.Padding(2);
            this.pointsArea.Multiline = true;
            this.pointsArea.Name = "pointsArea";
            this.pointsArea.Size = new System.Drawing.Size(225, 244);
            this.pointsArea.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(10, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Iterations counter:";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.iterationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iterationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iterationsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.iterationsTextBox.Location = new System.Drawing.Point(13, 185);
            this.iterationsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iterationsTextBox.Multiline = true;
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(104, 22);
            this.iterationsTextBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button2.Location = new System.Drawing.Point(13, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button3.Location = new System.Drawing.Point(69, 325);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 22);
            this.button3.TabIndex = 24;
            this.button3.Text = "Fill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // best1
            // 
            this.best1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.best1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.best1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.best1.ForeColor = System.Drawing.SystemColors.Info;
            this.best1.Location = new System.Drawing.Point(128, 291);
            this.best1.Multiline = true;
            this.best1.Name = "best1";
            this.best1.Size = new System.Drawing.Size(454, 25);
            this.best1.TabIndex = 25;
            this.best1.Text = "Radius: ";
            // 
            // bestX
            // 
            this.bestX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.bestX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bestX.ForeColor = System.Drawing.SystemColors.Info;
            this.bestX.Location = new System.Drawing.Point(128, 260);
            this.bestX.Multiline = true;
            this.bestX.Name = "bestX";
            this.bestX.Size = new System.Drawing.Size(223, 25);
            this.bestX.TabIndex = 26;
            this.bestX.Text = "X: ";
            // 
            // bestY
            // 
            this.bestY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.bestY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bestY.ForeColor = System.Drawing.SystemColors.Info;
            this.bestY.Location = new System.Drawing.Point(357, 260);
            this.bestY.Multiline = true;
            this.bestY.Name = "bestY";
            this.bestY.Size = new System.Drawing.Size(225, 25);
            this.bestY.TabIndex = 27;
            this.bestY.Text = "Y: ";
            // 
            // Diameter1
            // 
            this.Diameter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Diameter1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Diameter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Diameter1.ForeColor = System.Drawing.SystemColors.Info;
            this.Diameter1.Location = new System.Drawing.Point(128, 322);
            this.Diameter1.Multiline = true;
            this.Diameter1.Name = "Diameter1";
            this.Diameter1.Size = new System.Drawing.Size(454, 25);
            this.Diameter1.TabIndex = 28;
            this.Diameter1.Text = "Diameter: ";
            // 
            // drawer
            // 
            this.drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.drawer.ForeColor = System.Drawing.Color.Black;
            this.drawer.Location = new System.Drawing.Point(357, 11);
            this.drawer.Margin = new System.Windows.Forms.Padding(2);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(225, 244);
            this.drawer.TabIndex = 19;
            this.drawer.Text = "pointAndCircleDrawer1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(597, 363);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cross_rate_textBox);
            this.Controls.Add(this.Diameter1);
            this.Controls.Add(this.bestY);
            this.Controls.Add(this.bestX);
            this.Controls.Add(this.best1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pointsArea);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selection_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mut_rate_textBox);
            this.Controls.Add(this.max_iter_textbox);
            this.Controls.Add(this.popul_size_textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pointY_textBox);
            this.Controls.Add(this.pointX_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Projekt2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pointX_textBox;
        private System.Windows.Forms.TextBox pointY_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox popul_size_textbox;
        private System.Windows.Forms.TextBox max_iter_textbox;
        private System.Windows.Forms.TextBox mut_rate_textBox;
        private System.Windows.Forms.TextBox cross_rate_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selection_comboBox;
        private System.Windows.Forms.Label label8;
        private PointAndCircleDrawer drawer;
        private System.Windows.Forms.TextBox pointsArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox best1;
        private System.Windows.Forms.TextBox bestX;
        private System.Windows.Forms.TextBox bestY;
        private System.Windows.Forms.TextBox Diameter1;
    }
}

