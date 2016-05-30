using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DualSimplexGUI.Simplex;

namespace RaschetOptimal
{
    class Simplex
    {

        private int Variables { get; set; }
        private int Constraints { get; set; }
        private static int[] targetCoefficients;
        private static int[] right;
        private static int[] iBound;
        private static int[][] dConstraints;
        private static DConstraint[] constraints;

        public Simplex(int var, int constr, int[] tarCoeff, int[][] constrs, int[] righ, int[] Bound, bool isMinimize)
        {
            Variables = var;
            Constraints = constr;
            targetCoefficients = tarCoeff;
            dConstraints = constrs;
            right = righ;
            minimize = isMinimize;
            iBound = Bound;
        }


        private static double DELTA = 1e-5;
        private static DualSimplex ds;
        private static bool minimize;
        private static int status;

        public void calculate( String[] engine)
        {
            //Here we store coefficients of constraints
            constraints = new DConstraint[Constraints];

            for (int i = 0; i < Constraints; i++)
            {
                // Stores constraint values at given index
                double[] consValues = new double[Variables];

                // Take all fields and parse to double
                for (int j = 0; j < Variables; j++)
                {
                    consValues[j] = dConstraints[i][j];
                }
                // Represents sign of constraint

                int bound = PrimalSimplex.EQUAL_TO;
                if (iBound[i] == -1)        bound = PrimalSimplex.GREATER_THAN;
                else if (iBound[i] == 1) bound = PrimalSimplex.EQUAL_TO;
                else if (iBound[i] == 0) bound = PrimalSimplex.LESS_THAN;

                // Create object of DContraint passing arguments of variables, sign and right side, and store it to array
                constraints[i] = new DConstraint(consValues, bound, right[i]);
            }
            // Initilize Dual Simplex
            initDualSimplex();
            // Solve given problem
            solve();
            // Show result
            assertResult(engine);
        }
        private void initDualSimplex()
        {
            // Create object of DualSimplex
            ds = new DualSimplex();
            // Set objective function, also we pass mode of Simplex
            ds.setObjective(targetCoefficients, minimize);
            // Init array of constrains
            double[][] constraintArray = new double[constraints.Length][];
            for (int i = 0; i < constraints.Length; i++)
            {
                constraintArray[i] = new double[targetCoefficients.Length];
            }
            int[] equations = new int[constraints.Length];
            // Array of right sides of constraints
            double[] rhs = new double[constraints.Length];
            for (int i = 0; i < constraints.Length; ++i)
            {
                constraintArray[i] = constraints[i].getCoefficients();
                equations[i] = constraints[i].getEquations();
                rhs[i] = constraints[i].getRHS();
            }
            // Set parameters of dual simplex and initialize it
            ds.setConstraints(constraintArray, equations, rhs);
            ds.init();
        }
        // method for solving dual simplex
        private void solve()
        {
            // We iterate while we don't have right solution
            while ((status = ds.iterate()) == DualSimplex.CONTINUE) { }
        }

        // Show result
        private void assertResult(String[] engine)
        {
            // Get coefficients of objective function from simplex
            double[] targetCoefficientValues = ds.getCoefficients();
            // Get answer function
            string res = "Количество средств " + Math.Ceiling(ds.getObjectiveResult()) + "\n";
            // We do some formatting data here
            for (int i = 0; i < targetCoefficients.Length; ++i)
            {
                res = res + engine[i] +": " + Math.Ceiling(targetCoefficientValues[i]) + "\n";
            }
            // Show ResultForm with our result
            
            MessageBox.Show(res);

        }


    }
}

