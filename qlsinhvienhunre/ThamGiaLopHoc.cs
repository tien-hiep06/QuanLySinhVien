//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSinhVienHunre
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThamGiaLopHoc
    {
        public Nullable<double> diemSo { get; set; }
        public string diemChu { get; set; }
        public string maKetQua { get; set; }
        public int idLopHocPhan { get; set; }
        public int idSinhVien { get; set; }
    
        public virtual LopHocPhan LopHocPhan { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
