/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.dao;

import com.nguyenmanhhao.model.HocVien;
import java.awt.List;

/**
 *
 * @author HAO
 */
public interface HocVienDAO {
    public java.util.List<HocVien> getList();
    
    public int createOrUpdate(HocVien hocVien);

}