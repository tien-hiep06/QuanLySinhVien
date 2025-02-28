package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "Lop", schema = "dbo")
public class Lop {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idLop")
    private Integer id;

    @Column(name = "maLop")
    private String maLop;

    @ManyToOne
    @JoinColumn(name = "idNganhHoc")
    private NganhHoc nganhHoc;

    @ManyToOne
    @JoinColumn(name = "idGiangVien")
    private GiangVien giangVien;
}
