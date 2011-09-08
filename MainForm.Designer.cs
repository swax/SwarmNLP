namespace SwarmNLP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StopButton = new System.Windows.Forms.ToolStripButton();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ProblemButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SwarmButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.xAxisCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.yAxisCombo = new System.Windows.Forms.ToolStripComboBox();
            this.ObjLabel = new System.Windows.Forms.ToolStripLabel();
            this.ObjCombo = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.BestLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CursorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainDisplay = new SwarmNLP.DisplayPanel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StopButton,
            this.PlayButton,
            this.OpenButton,
            this.SaveButton,
            this.toolStripLabel3,
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.xAxisCombo,
            this.toolStripLabel4,
            this.yAxisCombo,
            this.ObjLabel,
            this.ObjCombo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(469, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StopButton
            // 
            this.StopButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StopButton.Image = global::SwarmNLP.Properties.Resources.Repeat;
            this.StopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(55, 22);
            this.StopButton.Text = "Reset";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.PlayButton.Image = global::SwarmNLP.Properties.Resources.Play;
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(49, 22);
            this.PlayButton.Text = "Play";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = global::SwarmNLP.Properties.Resources.open;
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(23, 22);
            this.OpenButton.Text = "toolStripButton1";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = global::SwarmNLP.Properties.Resources.save;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "toolStripButton2";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel3.Text = "   ";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProblemButton,
            this.WindowButton,
            this.SwarmButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(50, 22);
            this.toolStripDropDownButton1.Text = "Setup";
            // 
            // ProblemButton
            // 
            this.ProblemButton.Image = global::SwarmNLP.Properties.Resources.problem1;
            this.ProblemButton.Name = "ProblemButton";
            this.ProblemButton.Size = new System.Drawing.Size(119, 22);
            this.ProblemButton.Text = "Problem";
            this.ProblemButton.Click += new System.EventHandler(this.ProblemButton_Click);
            // 
            // WindowButton
            // 
            this.WindowButton.Image = global::SwarmNLP.Properties.Resources.Window1;
            this.WindowButton.Name = "WindowButton";
            this.WindowButton.Size = new System.Drawing.Size(119, 22);
            this.WindowButton.Text = "Window";
            this.WindowButton.Click += new System.EventHandler(this.WindowButton_Click);
            // 
            // SwarmButton
            // 
            this.SwarmButton.Image = global::SwarmNLP.Properties.Resources.bug1;
            this.SwarmButton.Name = "SwarmButton";
            this.SwarmButton.Size = new System.Drawing.Size(119, 22);
            this.SwarmButton.Text = "Swarm";
            this.SwarmButton.Click += new System.EventHandler(this.SwarmButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "      x";
            // 
            // xAxisCombo
            // 
            this.xAxisCombo.AutoSize = false;
            this.xAxisCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xAxisCombo.Name = "xAxisCombo";
            this.xAxisCombo.Size = new System.Drawing.Size(40, 23);
            this.xAxisCombo.SelectedIndexChanged += new System.EventHandler(this.xAxisCombo_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(26, 22);
            this.toolStripLabel4.Text = "    y";
            // 
            // yAxisCombo
            // 
            this.yAxisCombo.AutoSize = false;
            this.yAxisCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yAxisCombo.Name = "yAxisCombo";
            this.yAxisCombo.Size = new System.Drawing.Size(40, 23);
            this.yAxisCombo.SelectedIndexChanged += new System.EventHandler(this.yAxisCombo_SelectedIndexChanged);
            // 
            // ObjLabel
            // 
            this.ObjLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjLabel.Name = "ObjLabel";
            this.ObjLabel.Size = new System.Drawing.Size(37, 22);
            this.ObjLabel.Text = "    obj";
            // 
            // ObjCombo
            // 
            this.ObjCombo.AutoSize = false;
            this.ObjCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjCombo.Name = "ObjCombo";
            this.ObjCombo.Size = new System.Drawing.Size(40, 23);
            this.ObjCombo.SelectedIndexChanged += new System.EventHandler(this.ObjCombo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BestLabel,
            this.CursorLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(469, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // BestLabel
            // 
            this.BestLabel.Name = "BestLabel";
            this.BestLabel.Size = new System.Drawing.Size(409, 17);
            this.BestLabel.Spring = true;
            this.BestLabel.Text = "Optimal:";
            this.BestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CursorLabel
            // 
            this.CursorLabel.Name = "CursorLabel";
            this.CursorLabel.Size = new System.Drawing.Size(45, 17);
            this.CursorLabel.Text = "Cursor:";
            this.CursorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainDisplay
            // 
            this.MainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDisplay.Location = new System.Drawing.Point(0, 25);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(469, 347);
            this.MainDisplay.TabIndex = 2;
            this.MainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDisplay_Paint);
            this.MainDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainDisplay_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 394);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Swarm NLP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StopButton;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DisplayPanel MainDisplay;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ProblemButton;
        private System.Windows.Forms.ToolStripMenuItem WindowButton;
        private System.Windows.Forms.ToolStripMenuItem SwarmButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox xAxisCombo;
        private System.Windows.Forms.ToolStripLabel ObjLabel;
        private System.Windows.Forms.ToolStripComboBox yAxisCombo;
        private System.Windows.Forms.ToolStripStatusLabel BestLabel;
        private System.Windows.Forms.ToolStripStatusLabel CursorLabel;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox ObjCombo;
    }
}

