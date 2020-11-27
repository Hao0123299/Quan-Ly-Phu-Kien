 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.bean;

/**
 *
 * @author HAO
 */
public class LopHocBean {

    private String ngay_dang_ky;
    private int so_luong_hoc_vien;

    public LopHocBean() {
    }

    public LopHocBean(String ngay_dang_ky, int so_luong_hoc_vien) {
        this.ngay_dang_ky = ngay_dang_ky;
        this.so_luong_hoc_vien = so_luong_hoc_vien;
    }
    
     

    public String getNgay_dang_ky() {
        return ngay_dang_ky;
    }

    public void setNgay_dang_ky(String ngay_dang_ky) {
        this.ngay_dang_ky = ngay_dang_ky;
    }

    public int getSo_luong_hoc_vien() {
        return so_luong_hoc_vien;
    }

    public void setSo_luong_hoc_vien(int so_luong_hoc_vien) {
        this.so_luong_hoc_vien = so_luong_hoc_vien;
    }

}
