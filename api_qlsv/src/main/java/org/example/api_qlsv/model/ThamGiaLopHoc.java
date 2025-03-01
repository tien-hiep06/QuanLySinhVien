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

class ThamGiaLopHocId implements Serializable {
    private Integer lopHocPhan;
    private Integer sinhVien;

    public ThamGiaLopHocId() {}

    public ThamGiaLopHocId(Integer lopHocPhan, Integer sinhVien) {
        this.lopHocPhan = lopHocPhan;
        this.sinhVien = sinhVien;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        ThamGiaLopHocId that = (ThamGiaLopHocId) o;
        return Objects.equals(lopHocPhan, that.lopHocPhan) &&
                Objects.equals(sinhVien, that.sinhVien);
    }

    @Override
    public int hashCode() {
        return Objects.hash(lopHocPhan, sinhVien);
    }
}
