using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Tran_Nguyen_Nhat_Dung_229_sql
{
    public partial class Form1 : Form
    {
        //1. Khởi tạo dataset(new)
        QLSVV ql = new QLSVV();
        //2. Khởi tạo các dataAdapter(new )
        QLSVVTableAdapters.KHOATableAdapter dapkh = new QLSVVTableAdapters.KHOATableAdapter();
        QLSVVTableAdapters.SINHVIENTableAdapter dapsv = new QLSVVTableAdapters.SINHVIENTableAdapter();
        QLSVVTableAdapters.KETQUATableAdapter dapkq = new QLSVVTableAdapters.KETQUATableAdapter();
        //3. Khởi tạo bindingsoure
        BindingSource bd = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            //Tạo Sự kiện gán STT
            bd.CurrentChanged += Bd_CurrentChanged;
        }

        private void Bd_CurrentChanged(object sender, EventArgs e)
        {
            lblSTT.Text = bd.Position + 1 + "/" + bd.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //4.Tạo phương thức đọc dữ liệu
            DocDuLieu();
            //5.Tạo phương thức Khởi tạo combobox
            KhoiTaoCbo();
            //6.Tạo phương thức Liên kết điều khiển
            LienKetDieuKhien();
        }
        //7.Xử lý nút
        private void LienKetDieuKhien()
        {
            //1.Tạo vòng lặp foreach để liên kết đk
            foreach (Control ctrl in this.Controls)
            {
                //điều kiện để thực hiện buộc dữ liệu
                if (ctrl is TextBox && ctrl.Name != "txtTongDiem")
                {
                    //buộc dữ liệu
                    ctrl.DataBindings.Add("text", bd, ctrl.Name.Substring(3));

                }
                else if (ctrl is ComboBox)
                {
                    ctrl.DataBindings.Add("selectedvalue", bd, ctrl.Name.Substring(3));

                }
                else if (ctrl is CheckBox)
                {
                    ctrl.DataBindings.Add("checked", bd, ctrl.Name.Substring(3));
                }
                else if (ctrl is DateTimePicker)
                {
                    ctrl.DataBindings.Add("Value", bd, ctrl.Name.Substring(3));
                }

            }
            txtTongDiem.Text = Tongdiem("MaSV");
        }

        private string Tongdiem(string maSV)
        {
            double tongDiem = 0;
        }

        private void KhoiTaoCbo()
        {
            //5.1.Gán dislay cho cbo
            cboMaKH.DisplayMember = "TenKH";
            //5.2.Gán Value cho cbo
            cboMaKH.ValueMember = "MaKH";
            //5.3.Gán nguồn dữ liệu cho cbo(datasource)
            cboMaKH.DataSource = ql.KHOA;


        }

        private void DocDuLieu()
        {
            //4.1.Liên kết các dữ liệu từ database(dap) vào bindigsource(bd)
            dapkh.Fill(ql.KHOA);
            dapsv.Fill(ql.SINHVIEN);
            dapkq.Fill(ql.KETQUA);
            //4.2. Gán nguồn dữ liệu cho bindingsource
            bd.DataSource = ql;
            bd.DataMember = ql.SINHVIEN.TableName;

        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            bd.MoveNext();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bd.AddNew();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bd.MovePrevious();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            bd.CancelEdit();
        }
    }
}
