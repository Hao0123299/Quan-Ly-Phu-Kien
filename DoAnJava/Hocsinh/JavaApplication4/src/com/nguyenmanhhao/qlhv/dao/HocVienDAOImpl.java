        /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.dao;

import com.nguyenmanhhao.model.HocVien;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.awt.List;
import java.sql.SQLException;

/**
 *
 * @author HAO
 */
public class HocVienDAOImpl implements HocVienDAO {

    @Override
    public java.util.List<HocVien> getList() {
        
        try {
            Connection cons = DBConnect.getConnection();
            String sql = "select ma_hoc_sinh, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, tinh_trang from hocsinh";
            java.util.List<HocVien> list = new ArrayList<>();
            PreparedStatement ps = (PreparedStatement) cons.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                HocVien hocVien = new HocVien();
                hocVien.setMa_hoc_sinh(rs.getInt("ma_hoc_sinh"));
                hocVien.setHo_ten(rs.getString("ho_ten"));
                hocVien.setNgay_sinh(rs.getDate("ngay_sinh"));
                hocVien.setGioi_tinh(rs.getBoolean("gioi_tinh"));
                hocVien.setSo_dien_thoai(rs.getString("so_dien_thoai"));
                hocVien.setDia_chi(rs.getString("dia_chi"));
                hocVien.setTinh_trang(rs.getBoolean("tinh_trang"));
                list.add(hocVien);
            }
            ps.close();
            rs.close();
            cons.close();
            return list;

        } catch (SQLException e) {
            e.printStackTrace();
        }
        return  null;
    }

     @Override
    public int createOrUpdate(HocVien hocVien) {
        try {
            Connection cons = DBConnect.getConnection();
            System.out.println(hocVien.getNgay_sinh());
            //String sql = "INSERT INTO Hoc_sinh(ma_hoc_sinh, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, tinh_trang) VALUES(?, ?, ?, ?, ?, ?, ?) AS new_foo ON DUPLICATE KEY UPDATE ma_hoc_sinh=new_foo.ma_hoc_sinh";
            String sql = "INSERT INTO hocsinh(ma_hoc_sinh, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, tinh_trang) "
                    + "VALUES(?, ?, ?, ?, ?, ?, ?) ON DUPLICATE KEY UPDATE ho_ten = VALUES(ho_ten), ngay_sinh = VALUES(ngay_sinh), gioi_tinh = VALUES(gioi_tinh), so_dien_thoai = VALUES(so_dien_thoai), dia_chi = VALUES(dia_chi), tinh_trang = VALUES(tinh_trang);";
            PreparedStatement ps = cons.prepareStatement(sql, PreparedStatement.RETURN_GENERATED_KEYS);
            ps.setInt(1, hocVien.getMa_hoc_sinh());
            ps.setString(2, hocVien.getHo_ten());
            ps.setDate(3, new Date(hocVien.getNgay_sinh().getTime()));
            ps.setBoolean(4, hocVien.Gioi_tinh());
            ps.setString(5, hocVien.getSo_dien_thoai());
            ps.setString(6, hocVien.getDia_chi());
            ps.setBoolean(7, hocVien.Tinh_trang());
            int result = ps.executeUpdate();
            ps.close();
            cons.close();
            return result;
        } catch (Exception ex) {
            ex.printStackTrace();
            return 0;
        }
    }
}