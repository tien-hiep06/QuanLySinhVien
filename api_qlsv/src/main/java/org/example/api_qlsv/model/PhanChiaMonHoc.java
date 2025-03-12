package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.*;

@Entity
@Table(name = "PhanChiaMonHoc", schema = "dbo")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PhanChiaMonHoc {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idChiaMon")
    private Long idChiaMon;

    @Column(name = "idNganhHoc", nullable = false)
    private Integer idNganhHoc;

    @Column(name = "idMonHoc", nullable = false)
    private Integer idMonHoc;
}
