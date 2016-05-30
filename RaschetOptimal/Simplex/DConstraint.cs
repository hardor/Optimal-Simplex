using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualSimplexGUI.Simplex
{
    // Class for Constraint object
    public class DConstraint
    {
        // store here coefficients of contraint
        private double[] coefficients;
        // sign of constraint
        private int equations;
        // right side
        private double rhs;

        // Constructor
        public DConstraint(double[] coefficients, int equations, double rhs)
        {
            this.coefficients = coefficients;
            this.equations = equations;
            this.rhs = rhs;
        }
        // Getters and setters
        public double[] getCoefficients()
        {
            return coefficients;
        }

        public int getEquations()
        {
            return equations;
        }

        public double getRHS()
        {
            return rhs;
        }
    }
}
