using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoBaoAn_CCN04B
{
    public partial class TimKiem : System.Web.UI.Page
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=BAOAN\SQLEXPRESS;Initial Catalog=QL_SINHVIEN;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        public void Hienthi()
        {
            try
            {
                string chuoiSQL = "SELECT * FROM tbl_monhoc";
                SqlDataAdapter sqlData = new SqlDataAdapter(chuoiSQL, cn);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                gdvMonhoc.DataSource = table;
                gdvMonhoc.DataBind();
            }
            catch (Exception)
            {
                lblLoi.Text = "Lỗi kết nối";
            }

        }

        protected void btnTimMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMamonhoc.Text == "")
                {
                    Hienthi();
                }
                else
                {
                    string chuoiSQL = "SELECT * FROM tbl_monhoc where MaMH = N'" + txtMamonhoc.Text + "'";
                    SqlDataAdapter sqlData = new SqlDataAdapter(chuoiSQL, cn);
                    DataTable table = new DataTable();
                    sqlData.Fill(table);
                    gdvMonhoc.DataSource = table;
                    gdvMonhoc.DataBind();
                    txtMamonhoc.Text = "";
                }

            }
            catch (Exception)
            {
                lblLoi.Text = "Không tìm thấy kết quả";
            }
        }

        protected void btnTimMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenmonhoc.Text == "")
                {
                    Hienthi();
                }
                else
                {
                    string chuoiSQL = "SELECT * FROM tbl_monhoc where TenMH = N'" + txtTenmonhoc.Text + "'";
                    SqlDataAdapter sqlData = new SqlDataAdapter(chuoiSQL, cn);
                    DataTable table = new DataTable();
                    sqlData.Fill(table);
                    gdvMonhoc.DataSource = table;
                    gdvMonhoc.DataBind();
                    txtTenmonhoc.Text = "";
                }

            }
            catch (Exception ex)
            {
                lblLoi.Text = "Không tìm thấy kết quả";
            }
        }
    }
}