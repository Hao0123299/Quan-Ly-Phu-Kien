/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.service;

import com.nguyenmanhhao.qlhv.bean.KhoaHocBean;
import com.nguyenmanhhao.qlhv.bean.LopHocBean;
import java.util.List;

/**
 *
 * @author HAO
 */
public interface ThongKeService {
     public List<LopHocBean> getListByLopHoc();
    
    public List<KhoaHocBean> getListByKhoaHoc();
    
}
