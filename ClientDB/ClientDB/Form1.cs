using System;
using System.Windows.Forms;

namespace ClientDB
{
    public partial class Form1 : Form
    {
        private ClientDB CDB;
        public Form1()
        {
            InitializeComponent();
            CDB = new ClientDB("Do Nothing Pty Ltd");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CDB.AddClient(tbName.Text))
            {
                MessageBox.Show("cannot add this client");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!CDB.RemoveClient(tbName.Text))
            {
                MessageBox.Show("Cannot remove this client!");
            }
        }

        private void btnIsAClient_Click(object sender, EventArgs e)
        {
            if
            (CDB.IsAClient(tbName.Text))
            {
                MessageBox.Show("Our client!");
            }
            else
            {
                MessageBox.Show("Not our client!");
            }

        }
    }
}
