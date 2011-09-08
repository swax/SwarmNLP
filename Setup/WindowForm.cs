using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwarmNLP
{
    public partial class WindowForm : Form
    {
        MainForm Main;

        public WindowForm(MainForm main)
        {
            InitializeComponent();

            Main = main;
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {
            ResetView();
        }

        internal void ResetView()
        {
            RangeList.Items.Clear();

            for (int i = 0; i < Main.Config.Dimensions; i++)
                RangeList.Items.Add(new ListViewItem(new string[] { "x" + ((int)(i + 1)).ToString(), Main.Config.winMin[i].ToString(), Main.Config.winMax[i].ToString() }));

            ScaleBox.Text = Main.Config.Scaling.ToString();
        }

        ListViewItem SelectedItem;

        private void RangeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RangeList.SelectedItems.Count < 1)
                return;

            SelectedItem = RangeList.SelectedItems[0];

            MinBox.Text = SelectedItem.SubItems[1].Text;
            MaxBox.Text = SelectedItem.SubItems[2].Text;
        }

        private void MinBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedItem != null)
                SelectedItem.SubItems[1].Text = MinBox.Text;
        }

        private void MaxBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedItem != null)
                SelectedItem.SubItems[2].Text = MaxBox.Text;
        }



        private void SetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RangeList.Items.Count; i++)
            {
                ListViewItem item = RangeList.Items[i];

                if (!float.TryParse(item.SubItems[1].Text, out Main.Config.winMin[i]))
                {
                    MessageBox.Show("Error parsing min " + item.SubItems[1].Text);
                    return;
                }

                if (!float.TryParse(item.SubItems[2].Text, out Main.Config.winMax[i]))
                {
                    MessageBox.Show("Error parsing max " + item.SubItems[2].Text);
                    return;
                }
            }

            int.TryParse(ScaleBox.Text, out Main.Config.Scaling);


            Main.RefreshEvent.Set();
        }
    }
}