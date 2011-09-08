using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SwarmNLP
{

    [Serializable()]
    class Setup
    {
        // problem
        internal int Dimensions = 2;

        internal bool Maximization = true; //crit depreciate

        internal bool TimeUsed = false;
        internal float TimeInc = 0.0f;

        internal string FunctionEq; //crit depreciate

        internal List<string> FunctionEqs = new List<string>();
        internal List<string> ConstraintEqs = new List<string>();

        // window
        internal float[] winMax = new float[] { 10, 10 };
        internal float[] winMin = new float[] { -10, -10 };

        internal int Scaling = 1;

        // swarm
        internal int Entities = 30;
        internal int FlyTime = 8;

        internal float Inertia = 0.7f;
        internal float PersonalPref = 2;
        internal float GlobalPref = 2;

        internal bool Replusion = false;


        internal void FixLegacy()
        {
            if (FunctionEq == null)
                return;

            string function = Maximization ? "Maximize: " : "Minimize: ";

            function += FunctionEq;

            FunctionEqs = new List<string>();
            FunctionEqs.Add(function);

            FunctionEq = null;
        }
    }
}
