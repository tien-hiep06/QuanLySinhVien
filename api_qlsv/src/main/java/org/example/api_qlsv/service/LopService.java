package org.example.api_qlsv.service;

import org.example.api_qlsv.model.Lop;
import org.example.api_qlsv.repository.LopRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class LopService {
    @Autowired

    private LopRepository lopRepository;

    public List<Lop> getAllLop() {
        return lopRepository.findAll();
    }

    public Optional<Lop> getLopById(Long id) {
        return lopRepository.findById(id);
    }

    public Lop createLop(Lop lop) {
        return lopRepository.save(lop);
    }

    public Optional<Lop> updateLop(Long id, Lop lop) {
        if(lopRepository.existsById(id)) {
            lop.setId(id);
            return Optional.of(lopRepository.save(lop));
        }
        return Optional.empty();
    }

    public boolean deleteLop(Long id) {
        if(lopRepository.existsById(id)) {
            lopRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
