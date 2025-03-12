package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.NguoiDung;
import org.example.api_qlsv.service.NguoiDungService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/nguoidung")
@CrossOrigin("*")
public class NguoiDungController {

    @Autowired
    private NguoiDungService nguoiDungService;

    @GetMapping
    public List<NguoiDung> getAllNguoiDung(){
        return nguoiDungService.getAllNguoiDung();
    }

    @GetMapping("/{id}")
    public ResponseEntity<NguoiDung> getNguoiDungById(@PathVariable Long id){
        return nguoiDungService.getNguoiDungById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public NguoiDung createNguoiDung(@RequestBody NguoiDung nguoiDung){
        return nguoiDungService.createNguoiDung(nguoiDung);
    }

    @PutMapping("/{id}")
    public ResponseEntity<NguoiDung> updateNguoiDung(@PathVariable Long id, @RequestBody NguoiDung nguoiDung){
        return nguoiDungService.updateNguoiDung(id,nguoiDung)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<NguoiDung> deleteNguoiDung(@PathVariable Long id){
        if(nguoiDungService.deleteNguoiDung(id))
            return ResponseEntity.ok().build();
        else
            return ResponseEntity.notFound().build();
    }
}
