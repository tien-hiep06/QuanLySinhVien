package org.example.api_qlsv.model;

import java.io.Serializable;
import java.util.Objects;

public class ThamGiaLopHocId implements Serializable {
    private Long lopHocPhan;
    private Long sinhVien;

    public ThamGiaLopHocId() {}

    public ThamGiaLopHocId(Long lopHocPhan, Long sinhVien) {
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
