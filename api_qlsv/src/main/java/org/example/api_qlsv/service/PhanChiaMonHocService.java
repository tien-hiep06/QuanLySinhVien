package org.example.api_qlsv.service;


import org.example.api_qlsv.model.PhanChiaMonHoc;
import org.example.api_qlsv.repository.PhanChiaMonHocRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class PhanChiaMonHocService {
    @Autowired

    private PhanChiaMonHocRepository phanChiaMonHocRepository;

    public List<PhanChiaMonHoc> getAllPhanChiaMonHoc(){
        return phanChiaMonHocRepository.findAll();
    }

    public Optional<PhanChiaMonHoc> getPhanChiaMonHocById(Long id){
        return phanChiaMonHocRepository.findById(id);
    }

    public PhanChiaMonHoc createPhanChiaMonHoc(PhanChiaMonHoc phanChiaMonHoc){
        return phanChiaMonHocRepository.save(phanChiaMonHoc);
    }

    public Optional<PhanChiaMonHoc> updatePhanChiaMonHoc(Long id, PhanChiaMonHoc phanChiaMonHoc){
        if(phanChiaMonHocRepository.existsById(id)){
            phanChiaMonHoc.setIdChiaMon(id);
            return Optional.of(phanChiaMonHocRepository.save(phanChiaMonHoc));
        }
        return Optional.empty();
    }

    public boolean deletePhanChiaMonHoc(Long id){
        if(phanChiaMonHocRepository.existsById(id)){
            phanChiaMonHocRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
