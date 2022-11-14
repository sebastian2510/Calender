using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> HL = new List<string>();
        public List<string> NT = new List<string>();
        public List<string> CL = new List<string>();

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DBHandler db = new DBHandler();
            HL.Add(HeadTxt.Text);
            NT.Add(NoteTxt.Text);
            CL.Add(Calender.Text);
            ListPanel.Items.Add($"{CL[CL.Count - 1]} | {HL[HL.Count - 1]}");
            db.Submit(HeadTxt, NoteTxt, Calender);

            HeadTxt.Clear();
            NoteTxt.Clear();
            //MessageBox.Show($"{NoteTxt.MaxLength}");
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            HeadTxt.Text = HL[ListPanel.SelectedIndex];
            NoteTxt.Text = NT[ListPanel.SelectedIndex];
            Calender.Text = CL[ListPanel.SelectedIndex];
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{ListPanel.SelectedIndex} | {NT.Count}"); 30. December 2022
            DBHandler db = new DBHandler();
            db.Delete(ListPanel, HL);

            ListPanel.Items.Remove(NT[ListPanel.SelectedIndex + 1]);
            NT.RemoveAt(ListPanel.SelectedIndex + 1);
            HL.RemoveAt(ListPanel.SelectedIndex + 1);
            CL.RemoveAt(ListPanel.SelectedIndex + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBHandler db = new DBHandler();

            string login = "server = 192.168.16.178; uid = Sebastian; pwd = 123Abcd123; DATABASE = Calender;";
            SqlConnection conn = new SqlConnection(login);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Date", conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                HL.Add(rd.GetString(0));
                NT.Add(rd.GetString(1));
                CL.Add(rd.GetString(2));
            }
            cmd.Dispose();
            conn.Close();

            for (int i = 0; i < HL.Count; i++)
            {
                ListPanel.Items.Add($"{CL[i]} | {HL[i]}");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            HeadTxt.Clear();
            NoteTxt.Clear();
        }

        private void Calender_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
