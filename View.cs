using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHP_Business_Card_App
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            //private List<string> FirstLastNameCreatedList;
            createdCardsComboBox.Items.Add("ehehlfjwha");
            createdCardsComboBox.Items.Add("ehehlfsdfsdfsdfdsfdswha");
        }

        private void BackToForm1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
            this.Close();
            
        }

        private void CreatedCardsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            

        }
    }
}
