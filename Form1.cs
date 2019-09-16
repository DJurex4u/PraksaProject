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

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e) {
            //Nepotrebno
        }

        private void Button1_Click(object sender, EventArgs e) {
            string imageLocation = "";
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(.*png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    imageLocation = dialog.FileName;
                    picturePathTextBox.Text = imageLocation;
                }
            }
            catch (Exception) {
                MessageBox.Show("Selected file must be a picture");
            }
        }
    
        

        private void PicturePathTextBox_TextChanged(object sender, EventArgs e)
        {
            //Nepotrebno
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNameTextBox.Text) || String.IsNullOrEmpty(lastNameTextBox.Text) ||
                 String.IsNullOrEmpty(companyTextBox.Text) || String.IsNullOrEmpty(positionTextBox.Text) ||
                  String.IsNullOrEmpty(phoneTextBox.Text) || String.IsNullOrEmpty(mailTextBox.Text) ||
                  String.IsNullOrEmpty(baseColorTextBox.Text) || String.IsNullOrEmpty(picturePathTextBox.Text)) {
                MessageBox.Show("Fill blank spots, please.");
            }
            else {
                BussinesCard card = new BussinesCard(firstNameTextBox.Text, lastNameTextBox.Text, companyTextBox.Text, positionTextBox.Text,
                                                      phoneTextBox.Text, mailTextBox.Text, baseColorTextBox.Text, picturePathTextBox.Text);
                                

                MessageBox.Show("Card saved successfully!");            

                Cards.AddNewCard(card);                

                firstNameTextBox.Text = lastNameTextBox.Text = companyTextBox.Text = positionTextBox.Text = phoneTextBox.Text = mailTextBox.Text = baseColorTextBox.Text = picturePathTextBox.Text = "";                                           
                

            }
        }

        private void MadeCardButton_Click(object sender, EventArgs e) {
                       

            this.Hide();            
            View myView = new View();
            myView.ShowDialog();
            this.Close();
        }
    }
}
