package org.example.api_qlsv.service;

import org.example.api_qlsv.model.GiangVien;
import org.example.api_qlsv.repository.GiangVienRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class GiangVienService {

    @Autowired
    private GiangVienRepository giangVienRepository;

    public List<GiangVien> getAllGiangVien() {
        return giangVienRepository.findAll();
    }

    public Optional<GiangVien> getGiangVienById(Long id) {
        return giangVienRepository.findById(id);
    }

    public GiangVien createGiangVien(GiangVien giangVien) {
        return giangVienRepository.save(giangVien);
    }

    public Optional<GiangVien> updateGiangVien(Long id, GiangVien giangVien) {
        if (giangVienRepository.existsById(id)) {
            giangVien.setId(id);
            return Optional.of(giangVienRepository.save(giangVien));
        }
        return Optional.empty();
    }

    public boolean deleteGiangVien(Long id) {
        if (giangVienRepository.existsById(id)) {
            giangVienRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
