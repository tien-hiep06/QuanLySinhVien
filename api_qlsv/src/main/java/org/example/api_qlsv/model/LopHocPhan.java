package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "LopHocPhan", schema = "dbo")
public class LopHocPhan {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idLopHocPhan")
    private Integer id;

    @Column(name = "maLopHocPhan", unique = true)
    private String maLopHocPhan;

    @Column(name = "namHoc")
    private Integer namHoc;

    @Column(name = "hocKy")
    private Integer hocKy;

    @Column(name = "moTa", columnDefinition = "nvarchar(100)")
    private String moTa;

    @Column(name = "gioiHanSinhVien")
    private Float gioiHanSinhVien;

    @ManyToOne
    @JoinColumn(name = "idGiangVien")
    private GiangVien giangVien;

    @ManyToOne
    @JoinColumn(name = "idMonHoc")
    private MonHoc monHoc;
}
