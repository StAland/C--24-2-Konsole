using RPG_Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_GUI
{
    public partial class Charactererstellung : Form
    {
        public Character Player {  get; private set; }

        public Charactererstellung()
        {
            InitializeComponent();
        }

        public Charactererstellung(string defaultname)
        {
            InitializeComponent();
            txtName.Text = defaultname;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Player = new Character(txtName.Text, 10, 5, 2);
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
