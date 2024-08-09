
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace CRUD_students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Lay ra ma sinh vien can xoa
        string maSV_d = "";

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            //Fill du lieu listview sang control thong tin
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            txtMaSV.Text = maSV_d = lvi.SubItems[0].Text;
            txtTenSV.Text = lvi.SubItems[1].Text;
            string gioiTinh = lvi.SubItems[2].Text;
            if (gioiTinh == "Nam")
            {
                cbGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbGioiTinh.SelectedIndex = 1;
            }
            string[] dt = lvi.SubItems[3].Text.Split('/');
            dtpNgaySinh.Value = new DateTime(Int32.Parse(dt[2]), Int32.Parse(dt[0]), Int32.Parse(dt[1]));
            txtNoiSinh.Text = lvi.SubItems[4].Text;
            txtMaKhoa.Text = lvi.SubItems[5].Text;
            txtHocBong.Text = lvi.SubItems[6].Text;
        }
        //Chuoi ket noi
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\CRUD_students\CRUD_students\QuanLySinhVien.mdf;Integrated Security=True";

        //Doi tuong ket noi
        SqlConnection sqlCon = null;

        //Ham mo ket noi
        private void MoKetNoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }

        //Ham dong ket noi
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        //Khai bao ham hien thi danh sach sinh vien
        private void HienThiDanhSachSinhVien()
        {
            MoKetNoi();

            //Doi tuong thuc thi truy van
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiDanhSachSinhVien";

            //Gan vao ket noi
            sqlCmd.Connection = sqlCon;

            //Thuc thi truy van
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                //Doc du lieu tu trong co so du lieu
                string maSV = reader.GetString(0);
                string tenSV = reader.GetString(1);
                string gioiTinh = reader.GetString(2);
                string ngaySinh = reader.GetDateTime(3).ToString("MM/dd/yyyy");
                string noiSinh = reader.GetString(4);
                string maKhoa = reader.GetString(5);
                float hocBong = reader.GetFloat(6);

                //Tao mot dong du lieu moi tren list view
                ListViewItem lvi = new ListViewItem(maSV);
                lvi.SubItems.Add(tenSV);
                lvi.SubItems.Add(gioiTinh);
                lvi.SubItems.Add(ngaySinh);
                lvi.SubItems.Add(noiSinh);
                lvi.SubItems.Add(maKhoa);
                lvi.SubItems.Add(hocBong.ToString());

                //Gan dong dl len list view
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }

        //Ham vo hieu hoa thong tin chi tiet
        private void DisableSV()
        {
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            cbGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtMaKhoa.Enabled = false;
            txtHocBong.Enabled = false;
        }

        //Ham tim kiem theo ma sv
        private void TimKiemTheoMa(string tkMa)
        {
            MoKetNoi();

            //Doi tuong thuc thi truy van
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TimKiemTheoMaSV";

            //Dinh nghia paramter
            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = tkMa;
            sqlCmd.Parameters.Add(parMa);

            //Gan vao ket noi
            sqlCmd.Connection = sqlCon;

            //Thuc thi truy van
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            if (reader.Read())
            {
                //Doc du lieu sinh vien tu CSDL //code giong ham HienThiDanhSachSinhVien
                string maSV = reader.GetString(0);
                string tenSV = reader.GetString(1);
                string gioiTinh = reader.GetString(2);
                string ngaySinh = reader.GetDateTime(3).ToString("MM/dd/yyyy");
                string noiSinh = reader.GetString(4);
                string maKhoa = reader.GetString(5);
                float hocBong = reader.GetFloat(6);

                //Tao mot dong du lieu moi tren list view
                ListViewItem lvi = new ListViewItem(maSV);
                lvi.SubItems.Add(tenSV);
                lvi.SubItems.Add(gioiTinh);
                lvi.SubItems.Add(ngaySinh);
                lvi.SubItems.Add(noiSinh);
                lvi.SubItems.Add(maKhoa);
                lvi.SubItems.Add(hocBong.ToString());

                //Gan dong dl len list view
                lsvDanhSach.Items.Add(lvi);
            }

            reader.Close();
        }

        //Function find name student
        private void TimKiemTheoTen(string tkTen)
        {
            MoKetNoi();

            //Doi tuong thuc thi truy van
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "TimKiemTheoTenSV";

            //Dinh nghia paramter
            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = tkTen;
            sqlCmd.Parameters.Add(parTen);

            //Gan vao ket noi
            sqlCmd.Connection = sqlCon;
            //Thuc thi truy van
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                //Doc du lieu sinh vien tu CSDL //code giong ham HienThiDanhSachSinhVien
                string maSV = reader.GetString(0);
                string tenSV = reader.GetString(1);
                string gioiTinh = reader.GetString(2);
                string ngaySinh = reader.GetDateTime(3).ToString("MM/dd/yyyy");
                string noiSinh = reader.GetString(4);
                string maKhoa = reader.GetString(5);
                float hocBong = reader.GetFloat(6);

                //Tao mot dong du lieu moi tren list view
                ListViewItem lvi = new ListViewItem(maSV);
                lvi.SubItems.Add(tenSV);
                lvi.SubItems.Add(gioiTinh);
                lvi.SubItems.Add(ngaySinh);
                lvi.SubItems.Add(noiSinh);
                lvi.SubItems.Add(maKhoa);
                lvi.SubItems.Add(hocBong.ToString());

                //Gan dong dl len list view
                lsvDanhSach.Items.Add(lvi);
            }

            reader.Close();

        }

        //Function delete student
        private void XoaSinhVien(string maSV_d)
        {
            MoKetNoi();

            //Doi tuong thuc thi truy van
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "XoaSV";

            //Dinh nghia paramter
            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
            parMa.Value = maSV_d;
            sqlCmd.Parameters.Add(parMa);

            //Gan vao ket noi
            sqlCmd.Connection = sqlCon;

            //truy van database
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Deleted student succes!");
                HienThiDanhSachSinhVien();
            }
            else
            {
                MessageBox.Show("Delete student faild!");
                HienThiDanhSachSinhVien();
            }

        }

        //Function unhidde information detail
        private void EnableSV()
        {
            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;
            cbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtMaKhoa.Enabled = true;
            txtHocBong.Enabled = true;
        }

        //Function delete data
        private void DeleteControlSV()
        {
            txtMaSV.Text = txtTenSV.Text = txtNoiSinh.Text = txtMaKhoa.Text = txtHocBong.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Goi den ham hien thi danh sach
            HienThiDanhSachSinhVien();

            //Goi den ham vo hieu hoa thong tin chi tiet
            DisableSV();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nu");
            cbGioiTinh.SelectedIndex = 0;

        }
        private void Groupbox3_Enter(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you want to the out?", "Hop Thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radMaSV.Checked == true)
            {
                string tkMa = txtTKMaSV.Text.Trim();
                if (tkMa == "")
                {
                    MessageBox.Show("Id student not found!");
                    txtTKMaSV.Focus();
                }
                else
                {
                    TimKiemTheoMa(tkMa);
                }
            }
            else if (radTenSV.Checked == true)
            {
                string tkTen = txtTKTenSV.Text.Trim();
                if (tkTen == "")
                {
                    MessageBox.Show("Name student not found!");
                    txtTKTenSV.Focus();
                }
                else
                {
                    TimKiemTheoTen(tkTen);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableSV();
            cn = 2;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

        }

        private void txtTKMaSV_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void Groupbox3(object sender, EventArgs e)
        {

        } */

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableSV();

            cn = 1;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Lay du lieu tu CSDL
            if (cn == 1)
            {
                string ma = txtMaSV.Text.Trim();
                string ten = txtTenSV.Text.Trim();
                string gioiTinh = "";
                if (cbGioiTinh.SelectedIndex == 0)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nu";
                }
                string ngaySinh = dtpNgaySinh.Value.Year + "/" + dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day;
                string noiSinh = txtNoiSinh.Text.Trim();
                string maKhoa = txtMaKhoa.Text.Trim();
                string hocBong = txtHocBong.Text.Trim();

                MoKetNoi();

                //Doi tuong thuc thi truy van
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "ThemSinhVien";

                //Dinh nghia parameter
                SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
                SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
                SqlParameter parGioiTinh = new SqlParameter("@gioiTinh", SqlDbType.NVarChar);
                SqlParameter parNgaySinh = new SqlParameter("@ngaySinh", SqlDbType.DateTime);
                SqlParameter parNoiSinh = new SqlParameter("@noiSinh", SqlDbType.NVarChar);
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", SqlDbType.VarChar);
                SqlParameter parHocBong = new SqlParameter("@hocBong", SqlDbType.Real);

                parMa.Value = ma;
                parTen.Value = ten;
                parGioiTinh.Value = gioiTinh;
                parNgaySinh.Value = ngaySinh;
                parNoiSinh.Value = noiSinh;
                parMaKhoa.Value = maKhoa;
                parHocBong.Value = hocBong;

                sqlCmd.Parameters.Add(parMa);
                sqlCmd.Parameters.Add(parTen);
                sqlCmd.Parameters.Add(parGioiTinh);
                sqlCmd.Parameters.Add(parNgaySinh);
                sqlCmd.Parameters.Add(parNoiSinh);
                sqlCmd.Parameters.Add(parMaKhoa);
                sqlCmd.Parameters.Add(parHocBong);

                // Gan vao ket noi
                sqlCmd.Connection = sqlCon;


                //Thuc thi truy van
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Insert student succes!");
                    HienThiDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Add student faild!");
                }
            }
            else if (cn == 2)
            {
                string ma = txtMaSV.Text.Trim();
                string ten = txtTenSV.Text.Trim();
                string gioiTinh = "";
                if (cbGioiTinh.SelectedIndex == 0)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nu";
                }
                string ngaySinh = dtpNgaySinh.Value.Year + "/" + dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day;
                string noiSinh = txtNoiSinh.Text.Trim();
                string maKhoa = txtMaKhoa.Text.Trim();
                string hocBong = txtHocBong.Text.Trim();

                MoKetNoi();

                //Doi tuong thuc thi truy van
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "ChinhSuaSinhVien";

                //Dinh nghia parameter
                SqlParameter parMa = new SqlParameter("@ma", SqlDbType.VarChar);
                SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
                SqlParameter parGioiTinh = new SqlParameter("@gioiTinh", SqlDbType.NVarChar);
                SqlParameter parNgaySinh = new SqlParameter("@ngaySinh", SqlDbType.DateTime);
                SqlParameter parNoiSinh = new SqlParameter("@noiSinh", SqlDbType.NVarChar);
                SqlParameter parMaKhoa = new SqlParameter("@maKhoa", SqlDbType.VarChar);
                SqlParameter parHocBong = new SqlParameter("@hocBong", SqlDbType.Real);

                parMa.Value = ma;
                parTen.Value = ten;
                parGioiTinh.Value = gioiTinh;
                parNgaySinh.Value = ngaySinh;
                parNoiSinh.Value = noiSinh;
                parMaKhoa.Value = maKhoa;
                parHocBong.Value = hocBong;

                sqlCmd.Parameters.Add(parMa);
                sqlCmd.Parameters.Add(parTen);
                sqlCmd.Parameters.Add(parGioiTinh);
                sqlCmd.Parameters.Add(parNgaySinh);
                sqlCmd.Parameters.Add(parNoiSinh);
                sqlCmd.Parameters.Add(parMaKhoa);
                sqlCmd.Parameters.Add(parHocBong);

                // Gan vao ket noi
                sqlCmd.Connection = sqlCon;


                //Thuc thi truy van
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Insert information student succes!");
                    HienThiDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Add information student faild!");
                }
            }
        }

        //Bien kiem tra dang thuc hien chuc nang gi
        int cn = 0;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DeleteControlSV();

            DisableSV();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really delete student?","Box",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                XoaSinhVien(maSV_d);
                btnXoa.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }
    }
}
