package org.example.api_qlsv.service;

import org.example.api_qlsv.model.SinhVien;
import org.example.api_qlsv.repository.SinhVienRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class SinhVienService {

    @Autowired
    private SinhVienRepository sinhVienRepository;

    public List<SinhVien> getAllSinhVien() {
        return sinhVienRepository.findAll();
    }

    public Optional<SinhVien> getSinhVienById(Long id) {
        return sinhVienRepository.findById(id);
    }

    public SinhVien createSinhVien(SinhVien sinhVien) {
        return sinhVienRepository.save(sinhVien);
    }

    public Optional<SinhVien> updateSinhVien(Long id, SinhVien sinhVien) {
        if(sinhVienRepository.existsById(id)) {
            sinhVien.setId(id);
            return Optional.of(sinhVienRepository.save(sinhVien));
        }
        return Optional.empty();
    }
    public boolean deleteSinhVien(Long id) {
        if(sinhVienRepository.existsById(id)) {
            sinhVienRepository.deleteById(id);
            return true;
        }
        return false;
    }

}
