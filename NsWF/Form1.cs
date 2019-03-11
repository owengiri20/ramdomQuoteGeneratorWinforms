using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NsWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createJsonBtn_Click(object sender, EventArgs e) // coverts to Json
        {
            Person jPerson = new Person();

            jPerson.firstName = firstNameTxt.Text;
            jPerson.lastName = lastNameTxt.Text;
            jPerson.contact.Add("phone", phoneTxt.Text);
            jPerson.contact.Add("email", emailTxt.Text);

            foreach (string friend in friendListBox.Items)
            {
                jPerson.Friends.Add(friend);
            }

            string newJson = Newtonsoft.Json.JsonConvert.SerializeObject(jPerson);
            MessageBox.Show(newJson);
        }

        private void desirialiseBtn_Click(object sender, EventArgs e) // converts to person class
        {
            string Json = jsonTxt.Text;

            Person person = new Person();

            Newtonsoft.Json.JsonConvert.PopulateObject(Json, person);

            firstNameTxt.Text = person.firstName;
            lastNameTxt.Text = person.lastName;
            emailTxt.Text = person.contact["email"];
            phoneTxt.Text = person.contact["phone"];

            foreach (var friend in person.Friends)
            {
                friendListBox.Items.Add(friend);
            }

        }
    }
}
