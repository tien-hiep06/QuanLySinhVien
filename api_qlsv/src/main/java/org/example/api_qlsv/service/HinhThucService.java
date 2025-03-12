package org.example.api_qlsv.service;

import org.example.api_qlsv.model.HinhThuc;
import org.example.api_qlsv.repository.HinhThucRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class HinhThucService {

    @Autowired
    private HinhThucRepository hinhThucRepository;

    public List<HinhThuc> getAllHinhThuc() {
        return hinhThucRepository.findAll();
    }

    public Optional<HinhThuc> getHinhThucById(String id) {
        return hinhThucRepository.findById(id);
    }

    public HinhThuc createHinhThuc(HinhThuc hinhThuc) {
        return hinhThucRepository.save(hinhThuc);
    }

    public Optional<HinhThuc> updateHinhThuc(String id, HinhThuc hinhThuc) {
        if(hinhThucRepository.existsById(id)){
            hinhThuc.setHinhThucDanhGia(id);
            return Optional.of(hinhThucRepository.save(hinhThuc));
        }
        return Optional.empty();
    }

    public boolean deleteHinhThuc(String id) {
        if(hinhThucRepository.existsById(id)){
            hinhThucRepository.deleteById(id);
            return true;
        }else
            return false;
    }
}
