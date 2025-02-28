package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "PhanChiaMonHoc", schema = "dbo")
@IdClass(PhanChiaMonHocId.class)
public class PhanChiaMonHoc {
    @Id
    @ManyToOne
    @JoinColumn(name = "idNganhHoc")
    private NganhHoc nganhHoc;

    @Id
    @ManyToOne
    @JoinColumn(name = "idMonHoc")
    private MonHoc monHoc;
}
