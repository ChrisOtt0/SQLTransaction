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

namespace SQL_transaktion_Forms
{
    public partial class Form1 : Form
    {
        static string myConnString = @"Server=DESKTOP-8RTAUTT;Database=Fly;Trusted_Connection=True";
        static SqlConnection conn = new SqlConnection(myConnString);

        public Form1()
        {
            InitializeComponent();
            try { conn.Open(); } catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void UncommitedButton_Click(object sender, EventArgs e)
        {
            try
            {
                int flightNo = Convert.ToInt32(FlyNummerComboBox.Text);
                string sqlString = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "BEGIN TRANSACTION";
                cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "SELECT seatsFree FROM FlightSeats WHERE flightNo = " + flightNo;
                cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                FreeSeatsTextbox.Text = reader.GetInt32(0).ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerializableButton_Click(object sender, EventArgs e)
        {
            try
            {
                int flightNo = Convert.ToInt32(FlyNummerComboBox.Text);
                string sqlString = "SET TRANSACTION ISOLATION LEVEL SERIALIZABLE";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "BEGIN TRANSACTION";
                cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            
                sqlString = "SELECT seatsFree FROM FlightSeats WHERE flightNo = " + flightNo;
                cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                FreeSeatsTextbox.Text = reader.GetInt32(0).ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int flightNo = Convert.ToInt32(FlyNummerComboBox.Text);
                int seats = Convert.ToInt32(ReserveTextbox.Text);
                string sqlString = "UPDATE FlightSeats SET seatsFree = seatsFree - " + seats;
                sqlString += " WHERE flightNo = " + flightNo;
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int flightNo = Convert.ToInt32(FlyNummerComboBox.Text);
                string sqlString = "COMMIT";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "SELECT seatsFree FROM FlightSeats WHERE flightNo = " + flightNo;
                cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                FeedbackTextbox.Text = reader.GetInt32(0).ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rollbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                int flightNo = Convert.ToInt32(FlyNummerComboBox.Text);
                string sqlString = "ROLLBACK";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "SELECT seatsFree FROM FlightSeats WHERE flightNo = " + flightNo;
                cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                FeedbackTextbox.Text = reader.GetInt32(0).ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
