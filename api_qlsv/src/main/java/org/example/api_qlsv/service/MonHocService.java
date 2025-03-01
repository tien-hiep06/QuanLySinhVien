package org.example.api_qlsv.service;

import org.example.api_qlsv.model.MonHoc;
import org.example.api_qlsv.repository.MonHocRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class MonHocService {

    @Autowired

    private MonHocRepository monHocRepository;

    public List<MonHoc> getAllMonHoc(){
        return monHocRepository.findAll();
    }

    public Optional<MonHoc> getMonHocById(Long id){
        return monHocRepository.findById(id);
    }

    public MonHoc createMonHoc(MonHoc monHoc){
        return monHocRepository.save(monHoc);
    }

    public Optional<MonHoc> updateMonHoc(Long id, MonHoc monHoc){
        if(monHocRepository.existsById(id)){
            monHoc.setId(id);
            return Optional.of(monHocRepository.save(monHoc));
        }
        return Optional.empty();
    }

    public boolean deleteMonHoc(Long id){
        if (monHocRepository.existsById(id)){
            monHocRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
