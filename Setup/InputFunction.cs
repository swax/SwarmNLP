using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Evaluator;

namespace SwarmNLP
{
    public partial class InputFunction : Form
    {
        MainForm Main;
        int Dims;
        bool SetFunction;
        internal MethodResults ResultFunction;

        public InputFunction(MainForm main, int dims, bool setFunction, string function)
        {
            InitializeComponent();

            Main = main;
            Dims = dims;
            SetFunction = setFunction;

            Text = setFunction ? "Set Function" : "Set Constraint";

            MinRadio.Visible = setFunction;
            MaxRadio.Visible = setFunction;

            if (setFunction)
            {
                //"Minimize: adfadsfasdf"
                if(function.StartsWith("Minimize"))
                    MinRadio.Checked = true;
                else
                    MaxRadio.Checked = true;

                if(function.Length > 10)
                    FunctionBox.Text = function.Substring(10);
            }
            else
                FunctionBox.Text = function;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ResultFunction = SetFunction ? Main.CompileFunction(FunctionBox.Text, Dims) : Main.CompileConstraint(FunctionBox.Text, Dims);

            if (ResultFunction == null)
                return;

            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string GetFunctionText()
        {
            string text = FunctionBox.Text;

            if (MinRadio.Checked)
                text = "Minimize: " + text;
            else
                text = "Maximize: " + text;

            return text;
        }
    }
}