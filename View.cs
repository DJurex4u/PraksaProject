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
        }

        private void BackToForm1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
            this.Close();
            
        }

        private void CreatedCardsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            int number = createdCardsComboBox.SelectedIndex;

            List<BussinesCard> createdCardObjectList;
            
                createdCardObjectList = Cards.GetBussinesCardsObjectList();
            BussinesCard card = createdCardObjectList[number];
            label7.Text = card.GetFirstName();
            label8.Text = card.GetLastName();
            label9.Text = card.GetCompany();
            label10.Text = card.GetPosition();
            label11.Text = card.GetPhone();
            label12.Text = card.GetMail();
            label13.Text = card.GetBaseColor();
            //label8.Text = card.GetPicturePath();
            string imageLocation = card.GetPicturePath();

            pictureBox.ImageLocation = imageLocation;
            


        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            List<string> createdCards = Cards.GetListOfCreated();
            foreach (string firstLastName in createdCards) {                
                createdCardsComboBox.Items.Add(firstLastName);
            }
            generateButton.Hide();
        }

        private void View_Load(object sender, EventArgs e) {

        }

        private void Label7_Click(object sender, EventArgs e) {

        }
    }
}

