package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

import java.io.Serializable;
import java.util.Objects;

@Getter
@Setter
@Entity
@Table(name = "ThamGiaLopHoc", schema = "dbo")
@IdClass(ThamGiaLopHocId.class)
public class ThamGiaLopHoc {
    @Id
    @ManyToOne
    @JoinColumn(name = "idLopHocPhan")
    private LopHocPhan lopHocPhan;

    @Id
    @ManyToOne
    @JoinColumn(name = "idSinhVien")
    private SinhVien sinhVien;

    @Column(name = "diemSo")
    private Float diemSo;

    @Column(name = "diemChu", columnDefinition = "char(8)")
    private String diemChu;

    @Column(name = "maKetQua", columnDefinition = "nvarchar(8)")
    private String maKetQua;
}
