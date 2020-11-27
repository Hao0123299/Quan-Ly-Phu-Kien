/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.service;

import com.nguyenmanhhao.model.HocVien;
import com.nguyenmanhhao.qlhv.dao.HocVienDAO;
import com.nguyenmanhhao.qlhv.dao.HocVienDAOImpl;
import java.util.List;

/**
 *
 * @author HAO
 */
public class HocVienServiceImpl implements HocVienService {

    private HocVienDAO hocVienDAO =null;

    public HocVienServiceImpl() {
        this.hocVienDAO= new HocVienDAOImpl();
    }
    @Override
    public List<HocVien> getList() {
        return hocVienDAO.getList();
    }
    @Override
    public int createOrUpdate(HocVien hocVien) {
        return hocVienDAO.createOrUpdate(hocVien);
    }
}
