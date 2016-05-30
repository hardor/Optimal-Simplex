using System;
using System.Collections;
using System.Windows.Forms;


namespace RaschetOptimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Engines". При необходимости она может быть перемещена или удалена.
            this.enginesTableAdapter.Fill(this.database1DataSet.Engines);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            int rowNumber;

            foreach (int lind in listBox1.SelectedIndices)
            {
                rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells[0].Value = database1DataSet.Tables[0].Rows[lind][1];
                dataGridView1.Rows[rowNumber].Cells[1].Value = database1DataSet.Tables[0].Rows[lind][2];
                dataGridView1.Rows[rowNumber].Cells[2].Value = database1DataSet.Tables[0].Rows[lind][3];
                dataGridView1.Rows[rowNumber].Cells[3].Value = database1DataSet.Tables[0].Rows[lind][4];
                dataGridView1.Rows[rowNumber].Cells[5].Value = 1;
                dataGridView1.Rows[rowNumber].Cells[8].Value = database1DataSet.Tables[0].Rows[lind][5];
            }

           setDataGrid();
        }

        private void setDataGrid()
        {
            int rowNumber = dataGridView1.Rows.Count;
            for (int i = 0; i < rowNumber; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = getDuration(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) * 100.0 / 6.0, Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value), (bool) dataGridView1.Rows[i].Cells[8].Value);
            }
            for (int i = 0; i < rowNumber; i++)
            {
                dataGridView1.Rows[i].Cells[6].Value = getNumEvacuated(Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value), Math.Floor(Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)), Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
            }

            double sum_ev = 0;
            for (int i = 0; i < rowNumber; i++)
            {
                sum_ev += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }

            try
            {
                dataGridView1.Rows[0].Cells[7].Value = sum_ev;
            }
            catch { }


        }

        private double getDuration(double Vps, double tpv, bool water)
        {
            if (water == true)
                return Math.Round((2 * Convert.ToDouble(numericUpDown2.Value) / Vps * (1.0 + 0.3 * Convert.ToDouble(numericUpDown3.Value)) + tpv) * Convert.ToDouble(numericUpDown5.Value) * Convert.ToDouble(numericUpDown6.Value) * Convert.ToDouble(numericUpDown7.Value) / 60.0, 3);
            else return Math.Round((2 * Convert.ToDouble(numericUpDown2.Value) / Vps + tpv) * Convert.ToDouble(numericUpDown5.Value) * Convert.ToDouble(numericUpDown6.Value) * Convert.ToDouble(numericUpDown7.Value) / 60.0, 3);
        }

        private int getNumEvacuated(double Ri, double Ni, int ki)
        {
            try
            {
                return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(numericUpDown4.Value) / Ri * Ni * ki));
            }
            catch
            {
                return 1;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn  &&
                e.RowIndex >= 0)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    setDataGrid();
                }
                catch (System.InvalidOperationException ex)
                {

                }
            }
        }



        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            setDataGrid();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 8)
                    setDataGrid();
            }
            catch
            {
            }
            

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            setDataGrid();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            bool isMinimize = true;

            int rowNumber = dataGridView1.Rows.Count;

            int Variables = rowNumber;
            int Constraints = rowNumber + 1;

            String[] engines =new String[Variables];
            
            

            int[] Bound = new int[Constraints];
            // ArrayList Items = new ArrayList();
            ArrayList right = new ArrayList();

            for (int i = 0; i < Variables; i++)
            {
                right.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                // Items.Add(dataGridView1.Rows[i].Cells[5].Value);
                Bound[i] = 0;
                engines[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }



            //дополнительное ограничение для количества эвакуируемых
            right.Add(Convert.ToInt32(numericUpDown1.Value));
            Bound[Bound.Length - 1] = -1;

            int[] rig = right.ToArray(typeof(Int32)) as int[];
            int[] targ = new int[Variables];
            for (int i = 0; i < Variables; i++)
            {
                targ[i] = 1;
            }

            //targ[Constraints - 1] = 0;

            int[][] constr = new int[Constraints][];


            for (int i = 0; i < Constraints - 1; i++)
            {
                int[] row_cons = new int[Variables];
                for (int j = 0; j < Variables; j++)
                {
                    row_cons[j] = (i == j) ? 1 : 0;
                }

                constr[i] = row_cons;

            }

            int[] row_cons1 = new int[Variables];

            for (int j = 0; j < Variables; j++)
            {
                row_cons1[j] = getNumEvacuated(Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value), Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value), 1);
            }
            constr[Constraints - 1] = row_cons1;

            Simplex SMPLX = new Simplex(Variables, Constraints, targ, constr, rig, Bound, isMinimize);
            SMPLX.calculate(engines);


        }
    }
}
