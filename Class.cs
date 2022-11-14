using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Calender
{
    internal class Class
    {

    }
    class DBHandler
    {

        /*
        CREATE TABLE Date(
        Headline VARCHAR(50), 
        Note VARCHAR(8000), 
        dato DATE
        );
        */

        public void Submit(TextBox Headline, TextBox Note, DateTimePicker calender)
        {
            //MessageBox.Show($"{calender.Value} | {calender.Text}");
            string login = "server = 192.168.16.178; uid = Sebastian; pwd = 123Abcd123; DATABASE = Calender;";
            SqlConnection conn = new SqlConnection(login);
            conn.Open();

            SqlCommand cmd = new SqlCommand($"INSERT INTO Date (Headline, Note, dato) VALUES ('{Headline.Text}', '{Note.Text}', '{calender.Text}');", conn);
            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show($"Added to calender: {rows}");
            cmd.Cancel();
            conn.Close();
        }

        public void Delete(ListBox NoteList, List<string> HL)
        {
            string login = "server = 192.168.16.178; uid = Sebastian; pwd = 123Abcd123; DATABASE = Calender;";
            SqlConnection conn = new SqlConnection(login);
            conn.Open();

            SqlCommand cmd = new SqlCommand($"DELETE FROM Date WHERE Headline = '{HL[NoteList.SelectedIndex]}'", conn);
            NoteList.Items.RemoveAt(NoteList.SelectedIndex);
            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show($"Removed from calender: {rows}");
            cmd.Cancel();
            conn.Close();
        }
    }
}
