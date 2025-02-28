package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "HinhThuc", schema = "dbo")
public class HinhThuc {
    @Id
    @Column(name = "hinhThucDanhGia", length = 3)
    private String hinhThucDanhGia;

    @Column(name = "tenHinhThucDanhGia", columnDefinition = "nvarchar(100)")
    private String tenHinhThucDanhGia;
}
