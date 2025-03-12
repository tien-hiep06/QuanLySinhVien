package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.LopHocPhan;
import org.example.api_qlsv.service.LopHocPhanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/lophocphan")
@CrossOrigin("*")
public class LopHocPhanController {

    @Autowired
    private LopHocPhanService lopHocPhanService;

    @GetMapping
    public List<LopHocPhan> getAllLopHocPhan (){
        return lopHocPhanService.getAllLopHocPhan();
    }

    @GetMapping("/{id}")
    public ResponseEntity<LopHocPhan> getLopHocPhanById(@PathVariable Long id){
        return lopHocPhanService.getLopHocPhanById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public LopHocPhan creatLopHocPhan(@RequestBody LopHocPhan lopHocPhan){
        return lopHocPhanService.crateLopHocPhan(lopHocPhan);
    }

    @PutMapping("/{id}")
    public ResponseEntity<LopHocPhan> updateLopHocPhan(@PathVariable Long id, @RequestBody LopHocPhan lopHocPhan){
        return lopHocPhanService.updateLopHocPhan(id, lopHocPhan)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<LopHocPhan> deleteLopHocPhan(@PathVariable Long id){
        if(lopHocPhanService.deleteLopHocPhanById(id))
            return ResponseEntity.ok().build();
        else
            return ResponseEntity.notFound().build();
    }
}
