using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwarmNLP
{
    public partial class SwarmForm : Form
    {
        MainForm Main;

        public SwarmForm(MainForm main)
        {
            InitializeComponent();

            Main = main;

            ResetView();
        }

        internal void ResetView()
        {
            SizeBox.Text = Main.Config.Entities.ToString();
            InertiaBox.Text = Main.Config.Inertia.ToString();
            GlobalBox.Text = Main.Config.GlobalPref.ToString();
            PersonalBox.Text = Main.Config.PersonalPref.ToString();
            FlyBox.Value = Main.Config.FlyTime;
            BugSizeBox.Text = Main.BugSize.ToString();
            SolutionsKeptBox.Text = Main.SolutionsKept.ToString();
            Repulse.Checked = Main.Config.Replusion;
        }

        private void SwarmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


        private void SwarmForm_Load(object sender, EventArgs e)
        {

        }

        private void SetButton_Click(object sender, EventArgs e)
        {

            int.TryParse(SizeBox.Text, out Main.Config.Entities);
            float.TryParse(InertiaBox.Text, out Main.Config.Inertia);
            float.TryParse(GlobalBox.Text, out Main.Config.GlobalPref);
            float.TryParse(PersonalBox.Text, out Main.Config.PersonalPref);
            Main.Config.FlyTime = (int)FlyBox.Value;
            Main.Config.Replusion = Repulse.Checked;


            int.TryParse(BugSizeBox.Text, out Main.BugSize);
            int.TryParse(SolutionsKeptBox.Text, out Main.SolutionsKept);

            Main.ProcessEvent.Set();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}