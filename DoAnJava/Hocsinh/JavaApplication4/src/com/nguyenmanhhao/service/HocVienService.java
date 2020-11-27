/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.service;

import com.nguyenmanhhao.model.HocVien;
import java.util.List;

/**
 *
 * @author HAO
 */
public interface HocVienService {
    
    public List<HocVien> getList();
    public int createOrUpdate(HocVien hocVien);
    
}