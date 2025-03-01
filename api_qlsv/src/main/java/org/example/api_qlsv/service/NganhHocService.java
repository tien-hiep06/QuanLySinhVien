package org.example.api_qlsv.service;

import org.example.api_qlsv.model.NganhHoc;
import org.example.api_qlsv.repository.NganhHocRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class NganhHocService {
    @Autowired
    private NganhHocRepository nganhHocRepository;

    public List<NganhHoc> getAllNganhHoc() {
        return nganhHocRepository.findAll();
    }

    public Optional<NganhHoc> getNganhHocById(Long id) {
        return nganhHocRepository.findById(id);
    }

    public NganhHoc createNganhHoc(NganhHoc nganhHoc) {
        return nganhHocRepository.save(nganhHoc);
    }

    public Optional<NganhHoc> updateNganhHoc(Long id, NganhHoc nganhHoc) {
        if(nganhHocRepository.existsById(id)) {
            nganhHoc.setId(id);
            return Optional.of(nganhHocRepository.save(nganhHoc));
        }
        return Optional.empty();
    }
    public boolean deleteNganhHoc(Long id) {
        if(nganhHocRepository.existsById(id)) {
            nganhHocRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
