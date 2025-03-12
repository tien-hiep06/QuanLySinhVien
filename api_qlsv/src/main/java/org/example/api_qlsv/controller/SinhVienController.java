package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.SinhVien;
import org.example.api_qlsv.service.SinhVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/sinhvien")
@CrossOrigin("*")
public class SinhVienController {

    @Autowired
    private SinhVienService sinhVienService;

    @GetMapping
    public List<SinhVien> getAllSinhVien(){
        return sinhVienService.getAllSinhVien();
    }

    @GetMapping("/{id}")
    public ResponseEntity<SinhVien> getSinhVienById(@PathVariable Long id){
        return sinhVienService.getSinhVienById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public SinhVien createSinhVien(@RequestBody SinhVien sinhVien){
        return sinhVienService.createSinhVien(sinhVien);
    }

    @PutMapping("/{id}")
    public ResponseEntity<SinhVien> updateSinhVien(@PathVariable Long id, @RequestBody SinhVien sinhVien){
        return sinhVienService.updateSinhVien(id,sinhVien)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<SinhVien> deleteSinhVien(@PathVariable Long id){
        if(sinhVienService.deleteSinhVien(id))
            return ResponseEntity.ok().build();
        else
            return ResponseEntity.notFound().build();
    }

}
