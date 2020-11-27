/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.dao;

import com.nguyenmanhhao.model.TaiKhoan;

/**
 *
 * @author Hao
 */
public interface TaiKhoanDAO {
        public TaiKhoan login(String tenDangNhap, String matKhau);
}
