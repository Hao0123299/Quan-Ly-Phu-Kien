/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.dao;

import com.nguyenmanhhao.qlhv.bean.KhoaHocBean;
import com.nguyenmanhhao.qlhv.bean.LopHocBean;
import java.util.List;

/**
 *
 * @author HAO
 */
public interface ThongKeDAO {
    public List<LopHocBean> getListByLopHoc();
    
    public List<KhoaHocBean> getListByKhoaHoc();

   /* public List<KhoaHocBean> getListByKhoaHoc() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.*/
    //}
}