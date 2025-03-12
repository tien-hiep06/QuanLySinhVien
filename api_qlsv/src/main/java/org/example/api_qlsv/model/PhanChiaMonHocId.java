package org.example.api_qlsv.model;

import java.io.Serializable;
import java.util.Objects;

public class PhanChiaMonHocId implements Serializable {
    private Long nganhHoc;
    private Long monHoc;

    public PhanChiaMonHocId() {}

    public PhanChiaMonHocId(Long nganhHoc, Long monHoc) {
        this.nganhHoc = nganhHoc;
        this.monHoc = monHoc;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        PhanChiaMonHocId that = (PhanChiaMonHocId) o;
        return Objects.equals(nganhHoc, that.nganhHoc) &&
                Objects.equals(monHoc, that.monHoc);
    }

    @Override
    public int hashCode() {
        return Objects.hash(nganhHoc, monHoc);
    }
}
