package org.example.api_qlsv.service;

import org.example.api_qlsv.model.MonHoc;
import org.example.api_qlsv.model.PhanChiaMonHoc;
import org.example.api_qlsv.model.PhanChiaMonHocId;
import org.example.api_qlsv.repository.PhanChiaMonHocRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class PhanChiaMonHocService {

    @Autowired
    private PhanChiaMonHocRepository phanChiaMonHocRepository;

    public List<PhanChiaMonHoc> getAllPhanChiaMonHoc (){
        return phanChiaMonHocRepository.findAll();
    }

    public PhanChiaMonHoc getPhanChiMonHocById(Long idNganhHoc, Long idMonHoc){
        PhanChiaMonHocId id = new PhanChiaMonHocId(idNganhHoc,idMonHoc);
        return phanChiaMonHocRepository.findById(id).orElse(null);
    }

    public PhanChiaMonHoc createPhanChiaMonHoc(PhanChiaMonHoc phanChiaMonHoc){
        return phanChiaMonHocRepository.save(phanChiaMonHoc);
    }


    public boolean deletePhanChiaMonHoc(Long idNganhHoc, Long idMonHoc){
        PhanChiaMonHocId id = new PhanChiaMonHocId(idNganhHoc, idMonHoc);
        if(phanChiaMonHocRepository.existsById(id)){
            phanChiaMonHocRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
