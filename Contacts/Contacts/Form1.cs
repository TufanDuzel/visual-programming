using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Contacts
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact(textNS.Text, textPhone.Text, textEmail.Text);
            contacts.Add(newContact);
            UpdateContactList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listContacts.SelectedIndex >= 0)
            {
                Contact selectedContact = contacts[listContacts.SelectedIndex];
                selectedContact.Name = textNS.Text;
                selectedContact.Phone = textPhone.Text;
                selectedContact.Email = textEmail.Text;

                UpdateContactList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listContacts.SelectedIndex >= 0)
            {
                contacts.RemoveAt(listContacts.SelectedIndex);
                UpdateContactList();
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.",
                    "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listContacts.SelectedIndex >= 0)
            {
                Contact selectedContact = contacts[listContacts.SelectedIndex];
                textNS.Text = selectedContact.Name;
                textPhone.Text = selectedContact.Phone;
                textEmail.Text = selectedContact.Email;
            }
        }

        private void UpdateContactList()
        {
            listContacts.Items.Clear();
            foreach (Contact contact in contacts)
            {
                listContacts.Items.Add(contact.Name);
            }
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            textNS.Clear();
            textPhone.Clear();
            textEmail.Clear();
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
