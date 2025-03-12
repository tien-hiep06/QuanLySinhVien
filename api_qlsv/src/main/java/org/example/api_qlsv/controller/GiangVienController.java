package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.GiangVien;
import org.example.api_qlsv.service.GiangVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/giangvien")
@CrossOrigin("*")
public class GiangVienController {

    @Autowired
    private GiangVienService giangVienService;

    @GetMapping
    public List<GiangVien> getAllGiangVien(){
        return giangVienService.getAllGiangVien();
    }

    @GetMapping("/{id}")
    public ResponseEntity<GiangVien> getGiangVienById(@PathVariable Long id){
        return giangVienService.getGiangVienById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public GiangVien createGiangVien (@RequestBody GiangVien giangVien){
        return giangVienService.createGiangVien(giangVien);
    }

    @PutMapping("/{id}")
    public ResponseEntity<GiangVien> updateGiangVien(@PathVariable Long id, @RequestBody GiangVien giangVien){
        return giangVienService.updateGiangVien(id,giangVien)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<GiangVien> deleteGiangVien(@PathVariable Long id){
        if(giangVienService.deleteGiangVien(id))
            return ResponseEntity.ok().build();
        else
            return ResponseEntity.notFound().build();
    }
}
