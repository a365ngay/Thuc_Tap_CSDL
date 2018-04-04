using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace BUS
{
    public class QLCode
    {
        QLDuLieuDataContext db = new QLDuLieuDataContext();

        public string check_login(string name, string pass)
        {
            string sotk = "0";
            int taikhoan = (from tk in db.TaiKhoans
                            where tk.Name == name && tk.Pass == pass
                            select tk).Count();
            TaiKhoan tk1 = db.TaiKhoans.Single(a => a.Name == name);
            sotk = tk1.ID;
            return sotk;
        }
        public object edit_tk_pass(string name, string pass)
        {
            TaiKhoan tk = db.TaiKhoans.Single(a => a.Name == name);
            tk.Pass = pass;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 1;
        }
        public object get_user()
        {
            var user = from a in db.TaiKhoans
                       from b in db.Using1s
                       where a.ID == b.ID.ToString()
                       select new
                       {
                           Name = a.Name,
                           Pass = a.Pass,
                           Quyen = b.Quyen
                       };
            return user;
        }
        public object edit_user(string name, string pass, string quyen)
        {
            Using1 us = db.Using1s.Single(a => a.Quyen == quyen);
            string x = us.ID.ToString();
            TaiKhoan tk = db.TaiKhoans.Single(a => a.Name == name);
            tk.ID = x;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 1;
        }
        public object delete_user(string name)
        {
            var tk = from x in db.TaiKhoans
                     where x.Name == name
                     select x;
            db.TaiKhoans.DeleteAllOnSubmit(tk);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 1;
        }
        //Nhân viên
        public object get_nv()
        {
            var nv = from a in db.view_nvs
                     select a;
            return nv;
        }
        public int add_nv(string ma, string ten, string ns, string gt, string socmt, string sodt, string qq, string cv, string l, string maks)
        {
            var x = db.them_nv(ma, ten, Convert.ToDateTime(ns), gt, socmt, sodt, qq, cv, Convert.ToInt32(l), maks);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại mã nhân viên, mã quản lý!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object edit_nv(string ma1, string ma, string ten, string ns, string gt, string socmt, string sodt, string qq, string cv, string l, string maks)
        {
            var x = db.sua_nv(ma1, ma, ten, Convert.ToDateTime(ns), gt, socmt, sodt, qq, cv, Convert.ToInt32(l), maks);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại mã khách sạn, mã quản lý!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object delete_nv(string manv)
        {
            var x = db.xoa_nv(manv);
            if(x == 0)
            {
                MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object search_nv(string giatri)
        {
            var nv = from a in db.view_nvs
                     select new {MaNV = a.MaNV, TenNV = a.TenNV,
                         NgaySinh = a.NgaySinh,
                         Gioitinh = a.Gioitinh,
                         SoCMT = a.SoCMT,
                         SoDT = a.SoDT,
                         QueQuan = a.QueQuan,
                         ChucVu = a.ChucVu,
                         Luong = a.Luong,
                         MaKS = a.MaKS
                     } into tknv where tknv.NgaySinh.ToString().Contains(giatri) || tknv.TenNV.Contains(giatri)
                       || tknv.Gioitinh.Contains(giatri) || tknv.SoDT.Contains(giatri) || tknv.SoCMT.Contains(giatri) || tknv.QueQuan.Contains(giatri)
                       || tknv.ChucVu.Contains(giatri) || tknv.Luong.ToString().Contains(giatri) || tknv.MaKS.Contains(giatri)
                       select tknv;
            return nv;
        }
        public object search_nv(string giatri1, string giatri2)
        {
            var nv = from a in db.view_nvs
                     select new
                     {
                         MaNV = a.MaNV,
                         TenNV = a.TenNV,
                         NgaySinh = a.NgaySinh,
                         Gioitinh = a.Gioitinh,
                         SoCMT = a.SoCMT,
                         SoDT = a.SoDT,
                         QueQuan = a.QueQuan,
                         ChucVu = a.ChucVu,
                         Luong = a.Luong,
                         MaKS = a.MaKS
                     } into tknv
                     where tknv.Gioitinh.Contains(giatri1) && tknv.ChucVu.Contains(giatri2) || tknv.Gioitinh.Contains(giatri1) && tknv.MaKS.Contains(giatri2)
                     || tknv.MaKS.Contains(giatri1) && tknv.ChucVu.Contains(giatri2)
                     select tknv;
            return nv;
        }
        public object search_nv(string giatri1, string giatri2, string giatri3)
        {
            var nv = from a in db.view_nvs
                     select new
                     {
                         MaNV = a.MaNV,
                         TenNV = a.TenNV,
                         NgaySinh = a.NgaySinh,
                         Gioitinh = a.Gioitinh,
                         SoCMT = a.SoCMT,
                         SoDT = a.SoDT,
                         QueQuan = a.QueQuan,
                         ChucVu = a.ChucVu,
                         Luong = a.Luong,
                         MaKS = a.MaKS
                     } into tknv
                     where tknv.Gioitinh.Contains(giatri1) && tknv.ChucVu.Contains(giatri2) && tknv.MaKS.Contains(giatri3)
                     select tknv;
            return nv;
        }
        //Khách sạn
        public object get_ks()
        {
            var ks = from b in db.view_ks
                     select b;
            return ks;
        }
        public int add_ks(string ma, string ten, string diachi, string maql)
        {
            var x = db.them_ks(ma, ten, diachi, maql);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại mã khách sạn, mã quản lý!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public int edit_ks(string ma1, string ma, string ten, string diachi, string maql)
        {
            var x = db.sua_ks(ma1, ma, ten, diachi, maql);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại mã khách sạn, mã quản lý!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object delete_ks(string ma)
        {
            var ks = db.xoa_ks(ma);
            if (ks == 0)
            {
                MessageBox.Show("Khách sạn không tồn tại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return ks;
        }
        public object search_ks(string giatri)
        {
            var ks = from a in db.view_ks
                     select new
                     {
                         MaKhachSan = a.MaKhachSan,
                         TenKhachSan = a.TenKhachSan,
                         DiaChi = a.DiaChi,
                         MaNQL = a.MaNQL
                     } into tkks
                     where tkks.MaKhachSan.Contains(giatri) || tkks.TenKhachSan.Contains(giatri) || tkks.DiaChi.Contains(giatri)
                        || tkks.MaNQL.Contains(giatri) 
                     select tkks;
            return ks;
        }
        public object get_ttks()
        {
            var ks = from b in db.view_ttks
                     select b;
            return ks;
        }
        public object search_ttks(string giatri)
        {
            var ks = from b in db.view_ttks
                     where b.TenKhachSan.Contains(giatri) || b.DiaChi.Contains(giatri) || b.TenNV.Contains(giatri) || b.SoDT.Contains(giatri)
                     select b;
            return ks;
        }
        //Phòng
        public object get_phong()
        {
            var phong = from b in db.view_phongs
                     select b;
            return phong;
        }
        public int add_phong(string ten, string loai, string gia, string maks)
        {
            var phong = db.them_phong(ten, loai, Convert.ToInt32(gia), maks);
            if (phong == 0)
            {
                MessageBox.Show("Kiểm tra lại thông tin phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return phong;
        }
        public int edit_phong(string ten1, string ten, string loai, string gia, string maks)
        {
            var phong = db.sua_phong(ten1, ten, loai, Convert.ToInt32(gia), maks);
            if (phong == 0)
            {
                MessageBox.Show("Kiểm tra lại tên phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return phong;
        }
        public object delete_phong(string ten)
        {
            var phong = db.xoa_phong(ten);
            if (phong == 0)
            {
                MessageBox.Show("Kiểm tra lại tên phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return phong;
        }
        public int edit_loai_phong(string loai1, string loai, string gia)
        {
            var x = db.sua_loai_phong(loai1, loai, Convert.ToInt32(gia));
            return 1;
        }
        public object search_phong(string giatri)
        {
            var p = from a in db.view_phongs
                     select new
                     {
                         TenPhong = a.TenPhong,
                         LoaiPhong = a.LoaiPhong,
                         GiaPhong = a.GiaPhong
                     } into tkks
                     where tkks.TenPhong.Contains(giatri) || tkks.LoaiPhong.Contains(giatri) || tkks.GiaPhong.ToString().Contains(giatri)
                     select tkks;
            return p;
        }
        public object get_ttphong()
        {
            var ttp = from x in db.view_tinhtrangps
                      select x;
            return ttp;
        }
        public int edit_ttphong(string ten, string ttp)
        {
            var x = db.sua_ttp(ten, ttp);
            return x;
        }
        public object search_ttphong(string giatri)
        {
            var p = from a in db.view_tinhtrangps
                    select new
                    {
                        TenPhong = a.TenPhong,
                        TinhTrangPhong = a.TinhTrangPhong
                    } into tkks
                    where tkks.TenPhong.Contains(giatri) || tkks.TinhTrangPhong.Contains(giatri)
                    select tkks;
            return p;
        }
        //Khách hàng
        public object get_kh()
        {
            var kh = from b in db.view_khachhangs
                        select b;
            return kh;
        }
        public int add_kh(string ma, string ten, string ns, string gt, string cmt, string sdt, string diachi)
        {
            var x = db.them_kh(ma, ten, Convert.ToDateTime(ns), gt, cmt, sdt, diachi);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại khách hàng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public int edit_kh(string ma1, string ma, string ten, string ns, string gt, string cmt, string sdt, string diachi)
        {
            var x = db.sua_kh(ma1, ma, ten, Convert.ToDateTime(ns), gt, cmt, sdt, diachi);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại khách hàng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object delete_kh(string ma)
        {
            var x = db.xoa_kh(ma);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại khách hàng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object search_kh(string giatri)
        {
            var kh = from a in db.view_khachhangs
                    select new
                    {
                        MaKH = a.MaKH,
                        TenKH = a.TenKH,
                        NgaySinh = a.NgaySinh,
                        DiaChi = a.DiaChi,
                        SoCMT = a.SoCMT,
                        SoDT = a.SoDT,
                    } into tkks
                    where tkks.MaKH.Contains(giatri) || tkks.TenKH.Contains(giatri) || tkks.NgaySinh.ToString().Contains(giatri) || tkks.DiaChi.Contains(giatri)
                    || tkks.SoCMT.Contains(giatri) || tkks.SoDT.Contains(giatri)
                     select tkks;
            return kh;
        }
        //Dịch vụ
        public object get_dv()
        {
            var dv = from b in db.view_dvs
                     select b;
            return dv;
        }
        public int add_dv(string ma, string ten, string gia, string loai)
        {
            var x = db.them_dv(ma, ten, Convert.ToInt32(gia), loai);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public int edit_dv(string ma1, string ma, string ten, string gia, string loai)
        {
            var x = db.sua_dv(ma1, ma, ten, Convert.ToInt32(gia), loai);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object delete_dv(string ma)
        {
            var x = db.xoa_dv(ma);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object search_dv(string giatri)
        {
            var dv = from a in db.view_dvs
                     select new
                     {
                         MaDV = a.MaDV,
                         TenDV = a.TenDV,
                         GiaDV = a.GiaDV
                     } into tkks
                     where tkks.MaDV.Contains(giatri) || tkks.TenDV.Contains(giatri) || tkks.GiaDV.ToString().Contains(giatri)
                     select tkks;
            return dv;
        }
        public object search_dv(string giatri1, string giatri2)
        {
            var dv = from a in db.view_dvs
                     select new
                     {
                         MaDV = a.MaDV,
                         TenDV = a.TenDV,
                         GiaDV = a.GiaDV
                     } into tkks
                     where tkks.GiaDV >= Convert.ToInt32(giatri1) && tkks.GiaDV <= Convert.ToInt32(giatri2)
                     select tkks;
            return dv;
        }
        public object get_sddv()
        {
            var dv = from b in db.view_sddvs
                     select b;
            return dv;
        }
        public int add_sddv(string mahd, string makh, string tendv, string sl, string tien, string tennv, string ngay)
        {
            var x = db.them_sddv(mahd, makh, tendv, Convert.ToInt32(sl), Convert.ToInt32(tien), tennv, Convert.ToDateTime(ngay));
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public int sua_sddv(string mahd, string makh,string tendvbd, string tendv, string sl, string tien, string tennv, string ngay)
        {
            var x = db.sua_sddv(mahd, makh, tendvbd, tendv, Convert.ToInt32(sl), Convert.ToInt32(tien), tennv, Convert.ToDateTime(ngay));
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
        public object huy_dv(string mahd, string madv)
        {
            var x = db.huy_dv(mahd, madv);
            if (x == 0)
            {
                MessageBox.Show("Kiểm tra lại dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã hủy thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
            return x;
        }
    }
}
