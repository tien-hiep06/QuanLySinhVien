package org.example.api_qlsv.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "NguoiDung", schema = "dbo")
public class NguoiDung {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "idNguoiDung")
    private Integer id;

    @Column(name = "chucVu")
    private String chucVu;

    @Column(name = "matKhau")
    private String matKhau;

    @ManyToOne
    @JoinColumn(name = "idSinhVien", nullable = true)
    private SinhVien sinhVien;

    @ManyToOne
    @JoinColumn(name = "idGiangVien", nullable = true)
    private GiangVien giangVien;
}

