/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.main;

import com.nguyenmanhhao.view.DangNhapJDialog;
import com.nguyenmanhhao.view.MainnJFrame;

/**
 *
 * @author HAO
 */
public class Main {
    public static void main(String[] args)
    {
        //new MainnJFrame().setVisible(true);
        DangNhapJDialog dialog = new DangNhapJDialog(null, true);
        dialog.setTitle("Đăng nhâp hệ thống");
        dialog.setResizable(false);
        dialog.setLocationRelativeTo(null);
        dialog.setVisible(true);
        
    }
}