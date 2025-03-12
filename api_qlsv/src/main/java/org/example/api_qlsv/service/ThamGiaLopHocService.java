package org.example.api_qlsv.service;

import org.example.api_qlsv.model.ThamGiaLopHoc;
import org.example.api_qlsv.model.ThamGiaLopHocId;
import org.example.api_qlsv.repository.ThamGiaLopHocRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import java.util.List;
import java.util.Optional;

@Service
public class ThamGiaLopHocService {
    @Autowired
    private ThamGiaLopHocRepository thamGiaLopHocRepository;

    public List<ThamGiaLopHoc> getAllThamGiaLopHocs() {
        return thamGiaLopHocRepository.findAll();
    }

    public ThamGiaLopHoc getThamGiaLopHocById(Long idLopHocPhan, Long idSinhVien) {
        ThamGiaLopHocId id = new ThamGiaLopHocId(idLopHocPhan, idSinhVien);
        return thamGiaLopHocRepository.findById(id).orElse(null);
    }

    public ThamGiaLopHoc creatThamGiaLopHoc(ThamGiaLopHoc thamGiaLopHoc) {
        return thamGiaLopHocRepository.save(thamGiaLopHoc);
    }

    public ThamGiaLopHoc updateThamGiaLopHoc(Long idLopHocPhan, Long idSinhVien, ThamGiaLopHoc newThamGiaLopHoc) {
        ThamGiaLopHocId id = new ThamGiaLopHocId(idLopHocPhan, idSinhVien);
        Optional<ThamGiaLopHoc> optional = thamGiaLopHocRepository.findById(id);
        if (optional.isPresent()) {
            ThamGiaLopHoc existing = optional.get();
            existing.setDiemSo(newThamGiaLopHoc.getDiemSo());
            existing.setDiemChu(newThamGiaLopHoc.getDiemChu());
            existing.setMaKetQua(newThamGiaLopHoc.getMaKetQua());
            return thamGiaLopHocRepository.save(existing);
        }
        return null;
    }

    public boolean deleteThamGiaLopHoc(Long idLopHocPhan, Long idSinhVien) {
        ThamGiaLopHocId id = new ThamGiaLopHocId(idLopHocPhan, idSinhVien);
        if (thamGiaLopHocRepository.existsById(id)) {
            thamGiaLopHocRepository.deleteById(id);
            return true;
        }
        return false;
    }
}
