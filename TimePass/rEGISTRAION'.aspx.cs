using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimePass
{
    public partial class rEGISTRAION_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-MSFKHGD;Initial Catalog=employee;Integrated Security=true;";
            SqlConnection scon = new SqlConnection(connection);
            scon.Open();
            SqlCommand scmd = new SqlCommand("select dname from dept", scon);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            sda.Fill(dt);

            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "dname";
            DropDownList1.DataBind();

            scon.Close();
            bindgrid();

        }


        public void bindgrid()
        {
            string connection = "Data Source=DESKTOP-MSFKHGD;Initial Catalog=employee;Integrated Security=true;";
            SqlConnection scon = new SqlConnection(connection);
            scon.Open();
            SqlCommand scmd = new SqlCommand("select * from dept", scon);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            sda.Fill(dt);

            Gridview1.DataSource = dt;
            Gridview1.DataBind();

            scon.Close();
        }

        protected void insert(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-MSFKHGD;Initial Catalog=employee;Integrated Security=true;";
            SqlConnection scon = new SqlConnection(connection);
            scon.Open();
            SqlCommand scmd = new SqlCommand("insert into dept values(12,@name,@location)",scon);
            scmd.Parameters.Add("@name", TextBox1.Text);
            scmd.Parameters.Add("@location", TextBox2.Text);
            scmd.ExecuteNonQuery();
            scon.Close();

        }



    }
}