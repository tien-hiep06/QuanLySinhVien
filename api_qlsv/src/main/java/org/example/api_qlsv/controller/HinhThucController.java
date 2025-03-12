package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.HinhThuc;
import org.example.api_qlsv.service.HinhThucService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/hinhthuc")
@CrossOrigin("*")
public class HinhThucController {

    @Autowired
    private HinhThucService hinhThucService;

    @GetMapping
    public List<HinhThuc> getAllHinhThuc(){
        return hinhThucService.getAllHinhThuc();
    }

    @GetMapping("/{id}")
    public ResponseEntity<HinhThuc> getHinhThucById(@PathVariable String id)
    {
        return hinhThucService.getHinhThucById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public HinhThuc createHinhThuc(@RequestBody HinhThuc hinhThuc){
        return hinhThucService.createHinhThuc(hinhThuc);
    }

    @PutMapping("/{id}")
    public ResponseEntity<HinhThuc> updateHinhThuc(@PathVariable String id, @RequestBody HinhThuc hinhThuc){
        return hinhThucService.updateHinhThuc(id,hinhThuc)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<HinhThuc> deleteHinhThuc(@PathVariable String id){
        if(hinhThucService.deleteHinhThuc(id))
            return ResponseEntity.ok().build();
        else
            return ResponseEntity.notFound().build();
    }
}
