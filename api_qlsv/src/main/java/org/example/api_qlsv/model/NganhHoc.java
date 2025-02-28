package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;
import java.util.List;

@Getter
@Setter
@Entity
@Table(name = "NganhHoc", schema = "dbo")
public class NganhHoc {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idNganhHoc")
    private Integer id;

    @Column(name = "maNganhHoc", unique = true)
    private String maNganhHoc;

    @Column(name = "tenNganhHoc", columnDefinition = "nvarchar(MAX)")
    private String tenNganhHoc;

    @Column(name = "soTinChi")
    private Integer soTinChi;

    @Column(name = "namBatDau")
    private Integer namBatDau;
}
