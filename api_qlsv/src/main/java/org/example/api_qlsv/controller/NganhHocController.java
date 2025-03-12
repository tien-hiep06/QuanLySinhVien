package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.NganhHoc;
import org.example.api_qlsv.service.NganhHocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/nganhhoc")
@CrossOrigin("*")
public class NganhHocController {

    @Autowired
    private NganhHocService nganhHocService;

    @GetMapping
    public List<NganhHoc> getALLNganhHoc() {
        return nganhHocService.getAllNganhHoc();
    }

    @GetMapping("/{id}")
    public ResponseEntity<NganhHoc> getNganhHocById(@PathVariable Long id) {
        return nganhHocService.getNganhHocById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public NganhHoc createNganhHoc(@RequestBody NganhHoc nganhHoc) {
        return nganhHocService.createNganhHoc(nganhHoc);
    }

    @PutMapping("/{id}")
    public ResponseEntity<NganhHoc> updateNganhHoc(@PathVariable Long id, @RequestBody NganhHoc nganhHoc) {
        return nganhHocService.updateNganhHoc(id, nganhHoc)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<NganhHoc> deleteNganhHoc(@PathVariable Long id) {
        if (nganhHocService.deleteNganhHoc(id)) {
            return ResponseEntity.ok().build();
        }else {
            return ResponseEntity.notFound().build();
        }
    }
}
