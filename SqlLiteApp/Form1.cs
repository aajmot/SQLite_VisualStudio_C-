using Hyperboliq.Dialects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlLiteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(ConfigurationManager.AppSettings["conStr"]);
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO Messages(Message) VALUES('" + txtText.Text + "')";
                cmd.CommandType = CommandType.Text;
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Data inserted";
                }
                else
                {
                    lblMessage.ForeColor = Color.Blue;
                    lblMessage.Text = "Data insertion faild!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = ex.Message;
            }
        }
    }
}
