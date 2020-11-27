/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.controller;

import com.nguyenmanhhao.model.TaiKhoan;
import com.nguyenmanhhao.service.TaiKhoanService;
import com.nguyenmanhhao.service.TaiKhoanServiceImpl;
import com.nguyenmanhhao.view.DangNhapJDialog;
import com.nguyenmanhhao.view.MainnJFrame;
import static com.sun.java.accessibility.util.AWTEventMonitor.addMouseListener;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.Date;
import javax.swing.JButton;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
//import javax.swing.JLabel;
import javax.swing.JTextField;

/**
 *
 * @author Hao
 */
public class TaiKhoanController {
    private JDialog dialog;
    private JButton btnSubmit;
    private JTextField jtfTenDangNhap;
    private JTextField jtfMatKhau;
    private JLabel jlbMsg;
    
    private TaiKhoanService taiKhoanService = null;

    public TaiKhoanController(JDialog dialog, JButton btnSubmit, JTextField jtfTenDangNhap, JTextField jtfMatKhau, JLabel jlbMsg) {
        this.dialog = dialog;
        this.btnSubmit = btnSubmit;
        this.jtfTenDangNhap = jtfTenDangNhap;
        this.jtfMatKhau = jtfMatKhau;
        this.jlbMsg = jlbMsg;
        
        taiKhoanService = new TaiKhoanServiceImpl();
        
    }

    
    public void setEvent() {
        /*btnSubmit.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {               
                    if (jtfTenDangNhap.getText().length() == 0
                            || jtfMatKhau.getText().length() == 0) {
                        jlbMsg.setText("Vui lòng nhập dữ liệu bắt buộc!");
                    } else {
                        TaiKhoan taiKhoan = taiKhoanService.login(jtfTenDangNhap.getText(), jtfMatKhau.getText());
                        if (taiKhoan == null) {
                            jlbMsg.setText("Tên đăng nhập và mật khẩu không đúng!");
                        } else {
                            if (!taiKhoan.isTinh_trang()) {
                                jlbMsg.setText("Tài khoản của bạn đang bị tạm khóa!");
                            } else {
                                dialog.dispose();
                                MainnJFrame frame = new MainnJFrame();
                                frame.setTitle("Quản lý học viên");
                                frame.setExtendedState(JFrame.MAXIMIZED_BOTH);
                                frame.setVisible(true);
                            }
                        }
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
        });*/
        btnSubmit.addMouseListener(new MouseAdapter(){
             @Override
            public void mouseClicked(MouseEvent e) {
                if (jtfTenDangNhap.getText().length() == 0 || jtfMatKhau.getText().length() == 0) 
                {
                    jlbMsg.setText("Vui lòng nhập dữ liệu bắt buộc!");
                } 
                else
                {
                    TaiKhoan taiKhoan = taiKhoanService.login(jtfTenDangNhap.getText(), jtfMatKhau.getText());
                    if (taiKhoan == null)
                    {
                        jlbMsg.setText("Tên đăng nhập và mật khẩu không đúng!");
                    } else
                    {
                        if (!taiKhoan.isTinh_trang())
                        {
                            jlbMsg.setText("Tài khoản của bạn đang bị tạm khóa!");
                        } else
                        {
                            dialog.dispose();
                            MainnJFrame frame = new MainnJFrame();
                            frame.setTitle("Quản lý học viên");
                            frame.setExtendedState(JFrame.MAXIMIZED_BOTH);
                            frame.setVisible(true);
                        }
                    }
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
}
