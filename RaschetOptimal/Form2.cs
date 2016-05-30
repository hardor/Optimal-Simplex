using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaschetOptimal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void enginesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.enginesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet);
            }catch(Exception exc)
            {
                MessageBox.Show("Проверьте правильность данных");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Engines". При необходимости она может быть перемещена или удалена.
            this.enginesTableAdapter.Fill(this.database1DataSet.Engines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Engines". При необходимости она может быть перемещена или удалена.
            this.enginesTableAdapter.Fill(this.database1DataSet.Engines);

        }

        private void enginesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void enginesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.enginesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
