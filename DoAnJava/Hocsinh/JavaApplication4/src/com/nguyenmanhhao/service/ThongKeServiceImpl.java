/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.service;

import com.nguyenmanhhao.qlhv.bean.KhoaHocBean;
import com.nguyenmanhhao.qlhv.bean.LopHocBean;
import com.nguyenmanhhao.qlhv.dao.ThongKeDAO;
import com.nguyenmanhhao.qlhv.dao.ThongKeDAOImpl;
import java.util.List;

/**
 *
 * @author HAO
 */
public class ThongKeServiceImpl implements ThongKeService {

    private ThongKeDAO thongKeDAO = null;

    public ThongKeServiceImpl() {
        this.thongKeDAO = new ThongKeDAOImpl();
    }

    @Override
    public List<LopHocBean> getListByLopHoc() {
        return (List<LopHocBean>) thongKeDAO.getListByLopHoc();
    }

    @Override
    public List<KhoaHocBean> getListByKhoaHoc() {
        return thongKeDAO.getListByKhoaHoc();
    }

}