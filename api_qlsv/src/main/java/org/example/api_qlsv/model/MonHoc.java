package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "MonHoc", schema = "dbo")
public class MonHoc {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idMonHoc")
    private Integer id;

    @Column(name = "maMonHoc", unique = true)
    private String maMonHoc;

    @Column(name = "tenMonHoc", columnDefinition = "nvarchar(100)")
    private String tenMonHoc;

    @Column(name = "soTinChi")
    private Integer soTinChi;

    @Column(name = "namBatDau")
    private Integer namBatDau;

    @Column(name = "quyDinh", columnDefinition = "nvarchar(8)")
    private String quyDinh;

    @Column(name = "moTaMonHoc", columnDefinition = "nvarchar(100)")
    private String moTaMonHoc;

    @ManyToOne
    @JoinColumn(name = "hinhThucDanhGia")
    private HinhThuc hinhThucDanhGia;
}
