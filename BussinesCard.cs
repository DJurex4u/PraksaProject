using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHP_Business_Card_App
{
    class BussinesCard
    {
        private string firstName, lastName, company, position, phone, mail, baseColor, picturePath;
        public BussinesCard(string firstName, string lastName, string company, string position, string phone, string mail, string baseColor, string picturePath) {

            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
            this.position = position;
            this.phone = phone;
            this.mail = mail;
            this.baseColor = baseColor;
            this.picturePath = picturePath;
        }
        public string GetFirstName() {
            return this.firstName;
        }
        /*public string LastName { get; }  podsjetnik sebi: nikad više propertije nemoj koristiti jer potrošiš dva sata da skuzis sto nevalja
        public string Company { get; }
        public string Position { get; }
        public string Phone { get; }
        public string Mail { get; }
        public string BaseColor { get; }
        public string PicturePath { get; }
        */
        public string GetLastName() { return this.lastName; }
        public string GetCompany() { return this.company; }
        public string GetPosition() { return this.position; }
        public string GetPhone() { return this.phone; }
        public string GetMail() { return this.mail; }
        public string GetBaseColor() { return this.baseColor; }
        public string GetPicturePath() { return this.picturePath; }





    }
}
