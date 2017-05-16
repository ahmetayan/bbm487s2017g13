using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Payment : Form
    {
        private int id;
        private int book_id;

        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        public Payment(int id, int book_id)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.book_id = book_id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                conn.Open();
                SqlCommand delete = new SqlCommand("delete from Rent where bookID=@p1", conn);
                delete.Parameters.AddWithValue("@p1", book_id);
                delete.ExecuteNonQuery();


                SqlDataAdapter stockControl = new SqlDataAdapter("Select stock from Books where bookID =" + book_id, conn);
                DataSet dsStock = new DataSet();
                stockControl.Fill(dsStock);
                int stock = Convert.ToInt32(dsStock.Tables[0].Rows[0][0]);



                SqlCommand update = new SqlCommand("update [Books] set stock=@p2 where bookID=@p1", conn);
                update.Parameters.AddWithValue("@p1", book_id);
                update.Parameters.AddWithValue("@p2", stock + 1);
                update.ExecuteNonQuery();
                MessageBox.Show("You have succesfully returned the book!");
                conn.Close();

                this.Close();
                UserMain uM = new UserMain(id);
                uM.Show();
            }
            else
            {
                MessageBox.Show("Please Enter your full creadit Card informaitons!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.TextLength.ToString());
            this.Close();
        }
    }
}
