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
    public partial class Information : Form
    {
        private int id;
        private int book_id;

        public Information()
        {
            InitializeComponent();
        }

        public Information(int id, int book_id)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.book_id = book_id;
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        private void Information_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select r.rentDate,b.cost from Books b inner join Rent r on b.bookID=r.bookID inner join Users u on u.userID=r.userID where u.userID = " + id+" and b.bookID ="+book_id, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DateTime recDate = new DateTime();
            recDate = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
            double cost = Convert.ToDouble(ds.Tables[0].Rows[0][1]);           
            DateTime retDate = new DateTime();
            retDate =   Convert.ToDateTime(recDate.AddMonths(1));
            lblRet.Text = retDate.ToString();
            lblRec.Text = recDate.ToString();
            
             DateTime thisDay = DateTime.Today;
             if (thisDay <= retDate)
             {
                 lblDep.Text = "None";
                 //lblDep.Text = cost.ToString()+ " TL";
             }
             else
             {
                 lblDep.Text = (cost + 10.0).ToString()+" TL";
             }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
