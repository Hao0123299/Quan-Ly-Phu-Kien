/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.dao;

import com.nguyenmanhhao.model.TaiKhoan;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

/**
 *
 * @author Hao
 */
public class TaiKhoanDAOImpl implements TaiKhoanDAO {

    @Override
    public TaiKhoan login(String tenDangNhap, String matKhau) {
        Connection cons = DBConnect.getConnection();
        String sql = "SELECT * FROM tai_khoan WHERE ten_dang_nhap LIKE ?  AND mat_khau LIKE ?";
        TaiKhoan taiKhoan = null;
        try {
            PreparedStatement ps = (PreparedStatement) cons.prepareStatement(sql);
            ps.setString(1, tenDangNhap);
            ps.setString(2, matKhau);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                taiKhoan = new TaiKhoan();
                taiKhoan.setMa_tai_khoan(rs.getInt("ma_tai_khoan"));
                taiKhoan.setTen_dang_nhap(rs.getString("ten_dang_nhap"));
                taiKhoan.setMat_khau(rs.getString("mat_khau"));
                taiKhoan.setTinh_trang(rs.getBoolean("tinh_trang"));
            }
            ps.close();
            cons.close();
            return taiKhoan;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }

}
