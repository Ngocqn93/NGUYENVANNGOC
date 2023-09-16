namespace NGUYENVANNGOC.Models.DANHSACH
{
    public class ModelDanhSach
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int GIAMGIA { get; set; }
        public int TONGCONG { get; set; } 
        public int TamTinh { get; set; }
        public ModelDanhSach() { }
        public ModelDanhSach(string tenSanPham, int soLuong, int gia,int giamgia )
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
            GIAMGIA = SoLuong * DonGia * giamgia / 100;
            TONGCONG = TamTinh - GIAMGIA;
        }
    }
}
