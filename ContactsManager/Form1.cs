using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager
{
    public partial class Form1 : Form
    {
        private readonly string path = @"C:\Users\" + Environment.UserName + @"\Desktop\Contacts.txt";
        public Form1()
        {
            InitializeComponent();
            writeContacts();
            addContactsToListBox();
        }
        private void writeContacts()
        {
            string s ="sunil" + "\n" +"1234567890" + "\n" +
                      "balu" + "\n" + "9936161519" + "\n" +
                     "vinay" + "\n"+ "9494937474" + "\n" +
                     "Nanda" + "\n"+ "9876543210" + "\n"+
                     "sunil" + "\n" + "1234567890" + "\n";
            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Desktop\Contacts.txt",s);
        }
        private void addContactsToListBox()
        {
            StreamReader sr = new StreamReader(path);
            string[] s = new string[100];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = sr.ReadLine();
                contactsList.Items.Add(s[i] + "\n");
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path);
            bool found = false;
            int count = 0;
            string[] s = new string[100];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = sr.ReadLine();
            }
            if(searchTextBox.Text!="")
            {
                contactsList.Items.Clear();
                for (int i = 0; i < s.Length; i = i + 2)
                {
                    try
                    {
                        if (searchTextBox.Text.ToLower().Equals(s[i]))
                        {
                            searchTextBox.BackColor = Color.White;
                            contactsList.Items.Add(s[i] + " : " + s[i + 1] + "\n");
                        }
                        if (s[i].Contains(searchTextBox.Text.ToLower().ToString()))
                        {
                            found = true;
                            count++;
                        }
                        else
                        {
                            found = false;
                            continue;
                        }
                    }
                    catch(Exception ex)
                    {}

                    if (found && count == 1)
                    {
                        if(found && !duplicateSearch(s, searchTextBox.Text))
                        {
                            contactsList.Items.Clear();
                            contactsList.ForeColor = Color.Black;
                            contactsList.Items.Add(s[i] + " : " + s[i + 1] + "\n");
                            break;  
                        }
                        else if(found && duplicateSearch(s, searchTextBox.Text))
                        {
                            contactsList.Items.Add(s[i] + " : " + s[i + 1] + "\n");
                            contactsList.ForeColor = Color.BlueViolet;
                            MessageBox.Show("Duplicate contact found with name: "+ s[i], "Duplicate",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(searchTextBox.Text + " not found in contacts");
                        break;
                    }
                }
            }  
            else
            {
                searchTextBox.BackColor = Color.Red;
            }
        }
        private bool duplicateSearch(string[] s,string st)
        {
            int count = 0;
            for(int i=0;i<s.Length;i=i+2)
            {
                if (s[i] == st.ToString())
                    count++;
            }
            if (count > 1)
                return true;
            return false;
        }
    }
}
