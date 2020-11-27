    /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.controller;

import com.nguyenmanhhao.model.HocVien;
import com.nguyenmanhhao.service.HocVienService;
import com.nguyenmanhhao.service.HocVienServiceImpl;
import com.toedter.calendar.JDateChooser;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.Date;


import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JRadioButton;
import javax.swing.JTextArea;
import javax.swing.JTextField;

/**
 *
 * @author HAO
 */
 public class HocVienController {
   
    private  JButton btnSubmit;
    private JTextField jtfMaHocSinh;
    private  JTextField jtfHoTen;
    
    private JDateChooser jdcNgaySinh;
    private JTextField jtfSoDienThoai;
    private JRadioButton jrdNam;
    private JRadioButton jrdNu;
    private JTextArea jtaDiaChi;
    private JCheckBox jcbTinhTrang;
    private JLabel jlbMsg;

    private HocVien hocVien = null;
    private HocVienService hocVienService = null;

    public HocVienController(JButton btnSubmit, JTextField jtfMaHocSinh, JTextField jtfHoTen, JDateChooser jdcNgaySinh, JTextField jtfSoDienThoai, JRadioButton jrdNam, JRadioButton jrdNu, JTextArea jtaDiaChi, JCheckBox jcbTinhTrang, JLabel jlbMsg) {
        this.btnSubmit = btnSubmit;
        this.jtfMaHocSinh = jtfMaHocSinh;
        this.jtfHoTen = jtfHoTen;
        this.jdcNgaySinh = jdcNgaySinh;
        this.jtfSoDienThoai = jtfSoDienThoai;
        this.jrdNam = jrdNam;
        this.jrdNu = jrdNu;
        this.jtaDiaChi = jtaDiaChi;
        this.jcbTinhTrang = jcbTinhTrang;
        this.jlbMsg = jlbMsg;
        
        this.hocVienService = new HocVienServiceImpl();
    }
    
    public void setView(HocVien hocVien) {
        this.hocVien = hocVien;
        // set data
        jtfMaHocSinh.setText("#"+ hocVien.getMa_hoc_sinh());    
        jtfHoTen.setText(hocVien.getHo_ten());
        Date ngaysinh = new Date(jdcNgaySinh.getDate().getTime());
                        hocVien.setNgay_sinh(ngaysinh);
        
         //jdcNgaySinh.setDate(hocVien.getNgay_sinh());
        
        if (hocVien.Gioi_tinh()) {
            jrdNam.setSelected(true);
             jrdNam.setSelected(false);
        } else {
             jrdNam.setSelected(false);
            jrdNam.setSelected(true);
        }
        jtfSoDienThoai.setText(hocVien.getSo_dien_thoai());     
        jtaDiaChi.setText(hocVien.getDia_chi());
        jcbTinhTrang.setSelected(hocVien.Tinh_trang());
        
     
    }

    public void setEvent() {
        btnSubmit.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                try {
                    if (!checkNotNull()) {
                        jlbMsg.setText("Vui lòng nhập dữ liệu bắt buộc!");
                    } else {
                        hocVien.setHo_ten(jtfHoTen.getText().trim());
                        
                        Date ngaysinh = new Date(jdcNgaySinh.getDate().getTime());
                        hocVien.setNgay_sinh(ngaysinh);
                        
                       // hocVien.setNgay_sinh((Date)jdcNgaySinh.getDate());
                        hocVien.setGioi_tinh(jrdNam.isSelected());
                        hocVien.setSo_dien_thoai(jtfSoDienThoai.getText());
                        hocVien.setDia_chi(jtaDiaChi.getText());
                        hocVien.setTinh_trang(jcbTinhTrang.isSelected());
                        if (showDialog()) {
                            int lastId = hocVienService.createOrUpdate(hocVien);
                            if (lastId != 0) {
                                hocVien.setMa_hoc_sinh(lastId);
                                jtfMaHocSinh.setText("#" + lastId);
                                jlbMsg.setText("Xử lý cập nhật dữ liệu thành công!");
                            } else {
                                jlbMsg.setText("Có lỗi xảy ra, vui lòng thử lại!");
                            }
                        }
                    }
                } catch (Exception ex) {    
                    jlbMsg.setText(ex.toString());
                }
            }
            @Override
            public void mouseEntered(MouseEvent e) {
                btnSubmit.setBackground(new Color(0, 200, 83));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnSubmit.setBackground(new Color(100, 221, 23));
            }
        });
    }

    private boolean checkNotNull() {
        return jtfHoTen.getText() != null && !jtfHoTen.getText().equalsIgnoreCase("");
    }

    private boolean showDialog() {
        int dialogResult = JOptionPane.showConfirmDialog(null,
                "Bạn muốn cập nhật dữ liệu hay không?", "Thông báo", JOptionPane.YES_NO_OPTION);
        return dialogResult == JOptionPane.YES_OPTION;
    }
    
    
    
}