using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace SkypeHistoryEditor
{
    public partial class Form1 : Form
    {
        private ConversationEntity[] conversations;
        private DataProvider dataProvider;
        public Form1()
        {
            InitializeComponent();
            dataProvider = new DataProvider();
            conversations = dataProvider.getConversations();
            comboBox1.DataSource = conversations;
            comboBox1.DisplayMember = "displayname";
            comboBox1.ValueMember = "displayname";
        }
        protected override void OnLoad(EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataProvider.getMessages("Юрий")[0].body_xml);
        }
        void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = dataProvider.getMessages((sender as ComboBox).SelectedValue.ToString());
        }
    }
}
