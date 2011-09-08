using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Evaluator;

namespace SwarmNLP
{
    public partial class ProblemForm : Form
    {
        MainForm Main; 

        public ProblemForm(MainForm main)
        {
            InitializeComponent();

            Main = main;
        }

        private void ProblemForm_Load(object sender, EventArgs e)
        {
            ResetView();
           
        }

        internal void ResetView()
        {
            DimensionBox.Value = Main.Config.Dimensions;

            FunctionList.Items.Clear();
            foreach (string function in Main.Config.FunctionEqs)
                FunctionList.Items.Add(function);

            ConstraintsList.Items.Clear();
            foreach (string constraint in Main.Config.ConstraintEqs)
                ConstraintsList.Items.Add(constraint);

            TimeCheckBox.Checked = Main.Config.TimeUsed;
            TimeBox.Text = Main.Config.TimeInc.ToString();
        }


        private void ProblemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void FunctionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void AddFunctionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputFunction getFunc = new InputFunction(Main, (int)DimensionBox.Value, true, "");

            getFunc.ShowDialog();

            if (getFunc.ResultFunction != null)
                FunctionList.Items.Add(getFunc.GetFunctionText());
        }

        private void FunctionList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditFunctionLink_LinkClicked(null, null);
        }

        private void EditFunctionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FunctionList.SelectedItem == null)
                return;

            int index = FunctionList.SelectedIndex;

            InputFunction getFunc = new InputFunction(Main, (int)DimensionBox.Value, true, (string)FunctionList.SelectedItem);

            getFunc.ShowDialog();

            if (getFunc.ResultFunction != null)
            {
                FunctionList.Items.RemoveAt(index);

                FunctionList.Items.Insert(index, getFunc.GetFunctionText());
            }
        }

        private void RemoveFunctionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FunctionList.SelectedItem != null)
                FunctionList.Items.Remove(FunctionList.SelectedItem);
        }

        private void AddLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputFunction getFunc = new InputFunction(Main, (int)DimensionBox.Value, false, "");

            getFunc.ShowDialog();

            if (getFunc.ResultFunction != null)
                ConstraintsList.Items.Add( getFunc.FunctionBox.Text);
        }

        private void ConstraintsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditLink_LinkClicked(null, null);
        }

        private void EditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConstraintsList.SelectedItem == null)
                return;

            int index = ConstraintsList.SelectedIndex;

            InputFunction getFunc = new InputFunction(Main, (int)DimensionBox.Value, false, (string)ConstraintsList.SelectedItem);

            getFunc.ShowDialog();

            if (getFunc.ResultFunction != null)
            {
                ConstraintsList.Items.RemoveAt(index);
                ConstraintsList.Items.Insert(index, getFunc.FunctionBox.Text);
            }
        }

        private void RemoveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ConstraintsList.SelectedItem != null)
                ConstraintsList.Items.Remove(ConstraintsList.SelectedItem);
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SetButton.Text = "Working";
            SetButton.Enabled = false;

            if (Main.Play)
            {
                Main.PlayButton_Click(null, null);
                Thread.Sleep(500);
            }

            int dimensions = (int)DimensionBox.Value;

            try
            {
                if (dimensions < 1)
                {
                    MessageBox.Show("There must be at least one dimension");
                    return;
                }

                float[] testInput = new float[dimensions];

                foreach (string item in FunctionList.Items)
                {
                    string function = item.Substring(10);

                    MethodResults func = Main.CompileFunction(function, dimensions);
                    float result = (float)func.Invoke(testInput, 0f);
                }

                foreach (string constraint in ConstraintsList.Items)
                {
                    MethodResults consts = Main.CompileConstraint(constraint, dimensions);
                    bool good = (bool)consts.Invoke(testInput, 0f);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Function or Constraint has more variabls than allowed by the specified # of dimensions");
                SetButton.Text = "Set";
                SetButton.Enabled = true;
                return;
            }


            if (dimensions != Main.Config.Dimensions || 
                Main.BestGlobalValue.Length != FunctionList.Items.Count)
            {
                Main.Config.Dimensions = dimensions;

                Main.ResetDimensions(FunctionList.Items.Count);
            }

            Main.Config.FunctionEqs.Clear();
            foreach (string function in FunctionList.Items)
                Main.Config.FunctionEqs.Add(function);

            Main.Config.ConstraintEqs.Clear();
            foreach (string constraint in ConstraintsList.Items)
                Main.Config.ConstraintEqs.Add(constraint);

            Main.CompileProblem();




            float.TryParse(TimeBox.Text, out Main.Config.TimeInc);
            Main.Config.TimeUsed = TimeCheckBox.Checked;

            Main.RefreshAxisCombos();
            Main.RefreshEvent.Set();

            Main.Window.ResetView();

            SetButton.Text = "Set";
            SetButton.Enabled = true;
        }
    }
}