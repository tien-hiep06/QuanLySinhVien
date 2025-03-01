package org.example.api_qlsv.service;

import org.example.api_qlsv.model.LopHocPhan;
import org.example.api_qlsv.repository.LopHocPhanRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class LopHocPhanService {
    @Autowired

    private LopHocPhanRepository lopHocPhanRepository;

    public List<LopHocPhan> getAllLopHocPhan(){
        return lopHocPhanRepository.findAll();
    }

    public Optional<LopHocPhan> getLopHocPhanById(Long id){
        return lopHocPhanRepository.findById(id);
    }

    public LopHocPhan crateLopHocPhan(LopHocPhan lopHocPhan){
        return lopHocPhanRepository.save(lopHocPhan);
    }

    public Optional<LopHocPhan> updateLopHocPhan(Long id, LopHocPhan lopHocPhan){
        if(lopHocPhanRepository.existsById(id)){
            lopHocPhan.setId(id);
            return Optional.of(lopHocPhanRepository.save(lopHocPhan));
        }
        return Optional.empty();
    }

    public Boolean deleteLopHocPhanById(Long id){
        if(lopHocPhanRepository.existsById(id)){
            lopHocPhanRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
