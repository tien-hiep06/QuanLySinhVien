package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "SinhVien", schema = "dbo")
public class SinhVien {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idSinhVien")
    private Integer id;

    @Column(name = "maSinhVien", unique = true)
    private String maSinhVien;

    @Column(name = "hotenSinhVien", columnDefinition = "nvarchar(100)")
    private String hoTen;

    @Column(name = "ngaySinh")
    private java.sql.Date ngaySinh;

    @Column(name = "gioiTinh", columnDefinition = "nvarchar(5)")
    private String gioiTinh;

    @Column(name = "namNhapHoc")
    private Integer namNhapHoc;

    @ManyToOne
    @JoinColumn(name = "idLop")
    private Lop lop;
}
