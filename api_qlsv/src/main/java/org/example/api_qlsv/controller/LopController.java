package org.example.api_qlsv.controller;

import org.example.api_qlsv.model.Lop;
import org.example.api_qlsv.service.LopService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/lop")
@CrossOrigin("*")
public class LopController {

    @Autowired
    private LopService lopService;

    @GetMapping
    public List<Lop> getAllLop(){
        return lopService.getAllLop();
    }

    @GetMapping("/{id}")
    public ResponseEntity<Lop> getLopById(@PathVariable Long id){
        return lopService.getLopById(id)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public Lop crateLop(@RequestBody Lop lop){
        return lopService.createLop(lop);
    }

    @PutMapping("/{id}")
    public ResponseEntity<Lop> updateLop(@PathVariable Long id, @RequestBody Lop lop){
        return lopService.updateLop(id, lop)
                .map(ResponseEntity::ok)
                .orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Lop> deleteLop(@PathVariable Long id){
        if(lopService.deleteLop(id))
            return ResponseEntity.ok().build();
        else
            return ResponseEntity.notFound().build();
    }
}
