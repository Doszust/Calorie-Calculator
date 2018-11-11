//Author Dylan Oszust
//Calorie Calculator (Windows Forms)
//
//This will show the users history

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculatorWindows
{
    public partial class HistoryScreen : Form
    {
        public HistoryScreen()
        {
            InitializeComponent();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDBDataSet);

        }

        private void HistoryScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.userDBDataSet.History);

        }
    }
}
