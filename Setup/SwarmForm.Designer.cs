namespace SwarmNLP
{
    partial class SwarmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwarmForm));
            this.SetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InertiaBox = new System.Windows.Forms.TextBox();
            this.GlobalBox = new System.Windows.Forms.TextBox();
            this.PersonalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FlyBox = new System.Windows.Forms.NumericUpDown();
            this.Repulse = new System.Windows.Forms.CheckBox();
            this.BugSizeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SolutionsKeptBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SetButton
            // 
            this.SetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetButton.Location = new System.Drawing.Point(213, 265);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Swarm Size";
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(80, 12);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(44, 20);
            this.SizeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Global Optimal Influence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inertia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personal Optimal Influence";
            // 
            // InertiaBox
            // 
            this.InertiaBox.Location = new System.Drawing.Point(80, 38);
            this.InertiaBox.Name = "InertiaBox";
            this.InertiaBox.Size = new System.Drawing.Size(44, 20);
            this.InertiaBox.TabIndex = 5;
            // 
            // GlobalBox
            // 
            this.GlobalBox.Location = new System.Drawing.Point(152, 73);
            this.GlobalBox.Name = "GlobalBox";
            this.GlobalBox.Size = new System.Drawing.Size(44, 20);
            this.GlobalBox.TabIndex = 7;
            // 
            // PersonalBox
            // 
            this.PersonalBox.Location = new System.Drawing.Point(152, 100);
            this.PersonalBox.Name = "PersonalBox";
            this.PersonalBox.Size = new System.Drawing.Size(44, 20);
            this.PersonalBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time particle flys before changing course";
            // 
            // FlyBox
            // 
            this.FlyBox.Location = new System.Drawing.Point(219, 159);
            this.FlyBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FlyBox.Name = "FlyBox";
            this.FlyBox.Size = new System.Drawing.Size(46, 20);
            this.FlyBox.TabIndex = 10;
            // 
            // Repulse
            // 
            this.Repulse.AutoSize = true;
            this.Repulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repulse.Location = new System.Drawing.Point(16, 126);
            this.Repulse.Name = "Repulse";
            this.Repulse.Size = new System.Drawing.Size(225, 17);
            this.Repulse.TabIndex = 11;
            this.Repulse.Text = "Repulsion - helps keep particles distanced";
            this.Repulse.UseVisualStyleBackColor = true;
            // 
            // BugSizeBox
            // 
            this.BugSizeBox.Location = new System.Drawing.Point(68, 189);
            this.BugSizeBox.Name = "BugSizeBox";
            this.BugSizeBox.Size = new System.Drawing.Size(44, 20);
            this.BugSizeBox.TabIndex = 13;
            this.BugSizeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bug Size";
            // 
            // SolutionsKeptBox
            // 
            this.SolutionsKeptBox.Location = new System.Drawing.Point(147, 220);
            this.SolutionsKeptBox.Name = "SolutionsKeptBox";
            this.SolutionsKeptBox.Size = new System.Drawing.Size(44, 20);
            this.SolutionsKeptBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max # of solutions to kept";
            // 
            // SwarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.SolutionsKeptBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BugSizeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Repulse);
            this.Controls.Add(this.FlyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PersonalBox);
            this.Controls.Add(this.GlobalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InertiaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SwarmForm";
            this.Text = "Swarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SwarmForm_FormClosing);
            this.Load += new System.EventHandler(this.SwarmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InertiaBox;
        private System.Windows.Forms.TextBox GlobalBox;
        private System.Windows.Forms.TextBox PersonalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown FlyBox;
        private System.Windows.Forms.CheckBox Repulse;
        private System.Windows.Forms.TextBox BugSizeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SolutionsKeptBox;
        private System.Windows.Forms.Label label7;
    }
}