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
    public partial class CapNhat : System.Web.UI.Page
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=BAOAN\SQLEXPRESS;Initial Catalog=QL_SINHVIEN;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, cn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public void ThucThi(string caulenh)
        {
            SqlCommand cm = new SqlCommand(caulenh, cn);
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
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

        protected void btnThem_Click(object sender, EventArgs e)
        {
            txtMamonhoc.Text = "";
            txtTenmonhoc.Text = "";
            lblLoi.Text = "";
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {

            string chuoiSQL;
            if (txtMamonhoc.Text == "" || txtTenmonhoc.Text == "")
            {
                lblLoi.Text = "Vui lòng điền đầy đủ thông tin";
                return;
            }
            chuoiSQL = "SELECT * FROM tbl_monhoc WHERE MaMH=N'" + txtMamonhoc.Text.Trim() + "' OR TenMH=N'" + txtTenmonhoc.Text.Trim() + "'";
            if (CheckKey(chuoiSQL))
            {
                lblLoi.Text = "Môn học này đã tồn tại";
                txtMamonhoc.Focus();
            }
            else
            {
                chuoiSQL = "INSERT INTO tbl_monhoc values ('" + txtMamonhoc.Text + "',N'" + txtTenmonhoc.Text + "')";
                ThucThi(chuoiSQL);
                Hienthi();
                lblLoi.Text = "";
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMamonhoc.Text == "" || txtTenmonhoc.Text == "")
            {
                lblLoi.Text = "Vui lòng chọn đối tượng muốn xóa";
                return;
            }
            string chuoiSQL = "DELETE tbl_monhoc where MaMH='" + txtMamonhoc.Text + "'";
            ThucThi(chuoiSQL);
            Hienthi();
            txtMamonhoc.Text = "";
            txtTenmonhoc.Text = "";
            lblLoi.Text = "";
        }

        protected void gdvMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuoiSQL = "SELECT * FROM tbl_monhoc";
            SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int dong = gdvMonhoc.SelectedIndex;
            int trang = gdvMonhoc.PageIndex;
            txtMamonhoc.Text = dt.Rows[trang * 3 + dong][0].ToString();
            txtTenmonhoc.Text = dt.Rows[trang * 3 + dong][1].ToString();
        }

        protected void gdvMonhoc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvMonhoc.PageIndex = e.NewPageIndex;
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMamonhoc.Text == "" || txtTenmonhoc.Text == "")
            {
                lblLoi.Text = "Vui lòng chọn đối tượng muốn sửa";
                return;
            }
            string chuoiSQL = "UPDATE tbl_monhoc SET TenMH=N'" + txtTenmonhoc.Text + "'where MaMH = '" + txtMamonhoc.Text + "'";
            ThucThi(chuoiSQL);
            Hienthi();
            lblLoi.Text = "";
        }
    }
}