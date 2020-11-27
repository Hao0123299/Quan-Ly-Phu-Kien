/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.service;

import com.nguyenmanhhao.model.TaiKhoan;
import com.nguyenmanhhao.qlhv.dao.TaiKhoanDAO;
import com.nguyenmanhhao.qlhv.dao.TaiKhoanDAOImpl;

/**
 *
 * @author Hao
 */
public class TaiKhoanServiceImpl implements TaiKhoanService {

    private TaiKhoanDAO taiKhoanDAO = null;

    public TaiKhoanServiceImpl() {
        taiKhoanDAO = new TaiKhoanDAOImpl();
    }

    @Override
    public TaiKhoan login(String tenDangNhap, String matKhau) {
        return taiKhoanDAO.login(tenDangNhap, matKhau);
    }

}
