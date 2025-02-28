package org.example.api_qlsv.model;

import java.io.Serializable;
import java.util.Objects;

public class ThamGiaLopHocId implements Serializable {
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
