package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "GiangVien", schema = "dbo")
public class GiangVien {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idGiangVien")
    private Long id;

    @Column(name = "maGiangVien", unique = true)
    private String maGiangVien;

    @Column(name = "hotenGiangVien", columnDefinition = "nvarchar(50)")
    private String hoTen;

    @Column(name = "ngaySinh")
    private java.sql.Date ngaySinh;

    @Column(name = "gioiTinh", columnDefinition = "nvarchar(5)")
    private String gioiTinh;
}
