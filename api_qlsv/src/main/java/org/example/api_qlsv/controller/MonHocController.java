package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.MonHoc;
import org.example.api_qlsv.service.MonHocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/monhoc")
@CrossOrigin("*")
public class MonHocController {

    @Autowired
    private MonHocService monHocService;

    @GetMapping
    public List<MonHoc> getAllMonHoc() {
        return monHocService.getAllMonHoc();
    }

    @GetMapping("/{id}")
    public ResponseEntity<MonHoc> getMonHocById(@PathVariable Long id) {
        return monHocService.getMonHocById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public MonHoc createMonHoc(@RequestBody MonHoc monHoc) {
        return monHocService.createMonHoc(monHoc);
    }

    @PutMapping("/{id}")
    public ResponseEntity<MonHoc> updateMonHoc (@PathVariable Long id, @RequestBody MonHoc monHoc){
        return monHocService.updateMonHoc(id, monHoc)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<MonHoc> deleteMonHoc (@PathVariable Long id){
        if(monHocService.deleteMonHoc(id)){
            return ResponseEntity.ok().build();
        }else {
            return ResponseEntity.notFound().build();
        }

    }
}
