package org.example.api_qlsv.service;

import org.example.api_qlsv.model.NguoiDung;
import org.example.api_qlsv.repository.NguoiDungRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class NguoiDungService {
    @Autowired

    private NguoiDungRepository nguoiDungRepository;

    public List<NguoiDung> getAllNguoiDung(){
        return nguoiDungRepository.findAll();
    }

    public Optional<NguoiDung> getNguoiDungById(Long id){
        return nguoiDungRepository.findById(id);
    }

    public NguoiDung createNguoiDung(NguoiDung nguoiDung){
        return nguoiDungRepository.save(nguoiDung);
    }

    public Optional<NguoiDung> updateNguoiDung(Long id, NguoiDung nguoiDung){
        if(nguoiDungRepository.existsById(id)){
            nguoiDung.setId(id);
            return Optional.of(nguoiDungRepository.save(nguoiDung));
        }
        return Optional.empty();
    }

    public boolean deleteNguoiDung(Long id){
        if(nguoiDungRepository.existsById(id)){
            nguoiDungRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
