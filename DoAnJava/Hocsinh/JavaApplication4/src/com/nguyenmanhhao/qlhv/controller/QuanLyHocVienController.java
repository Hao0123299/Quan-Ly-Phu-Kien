/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.controller;

import com.nguyenmanhhao.model.HocVien;
import com.nguyenmanhhao.service.HocVienService;
import com.nguyenmanhhao.service.HocVienServiceImpl;
import com.nguyenmanhhao.utility.ClassTableModel;
import com.nguyenmanhhao.view.HocVienJFrame;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.Date;

import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.RowFilter;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;

/**
 *
 * @author HAO
 */
public class QuanLyHocVienController {

    private JPanel jpnView;
    private JButton btnAdd;
    private JTextField jtfSearch;
    
    private HocVienService hocVienService = null;

    private ClassTableModel classTableModel = null;

    private final String[] COLUMNS = {"Mã học sinh", "Tên học sinh", "Ngày sinh",
        "Giới tính", "Số điện thoại", "Địa chỉ", "Trạng thái"};

   

    private TableRowSorter<TableModel> rowSorter = null;

    public QuanLyHocVienController(JPanel jpnView, JButton btnAdd, JTextField jtfSearch) {
        this.jpnView = jpnView;
        this.btnAdd = btnAdd;
        this.jtfSearch = jtfSearch;

        this.hocVienService = new HocVienServiceImpl();
        this.classTableModel = new ClassTableModel();

        
    }

    public void setDataToTable() {
      
        java.util.List<HocVien> listItem = hocVienService.getList();
        DefaultTableModel model = new ClassTableModel().setTableHocVien(listItem, COLUMNS);
         JTable table = new JTable(model);  

        rowSorter = new TableRowSorter<>(table.getModel());
        table.setRowSorter(rowSorter);

        jtfSearch.getDocument().addDocumentListener(new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                String text = jtfSearch.getText();
                if (text.trim().length() == 0) {
                    rowSorter.setRowFilter(null);
                } else {
                    rowSorter.setRowFilter(RowFilter.regexFilter("(?i)" + text));
                }
            }

            @Override
            public void removeUpdate(DocumentEvent e) {
                String text = jtfSearch.getText();
                if (text.trim().length() == 0) {
                    rowSorter.setRowFilter(null);
                } else {
                    rowSorter.setRowFilter(RowFilter.regexFilter("(?i)" + text));
                }
            }

            @Override
            public void changedUpdate(DocumentEvent e) {
            }
            
        });
        
       
        table.addMouseListener(new MouseAdapter() {
      @Override
      public void mouseClicked(MouseEvent e) {
             if (e.getClickCount() == 2 && table.getSelectedRow() != -1) {
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);

                    
                    HocVien hocVien = new HocVien();
                    
                    hocVien.setMa_hoc_sinh((int) model.getValueAt(selectedRowIndex, 0));
                    
                    hocVien.setHo_ten(model.getValueAt(selectedRowIndex, 1).toString());
                    

                   hocVien.setNgay_sinh((Date)model.getValueAt(selectedRowIndex, 2));
                    
                    
                    hocVien.setGioi_tinh(model.getValueAt(selectedRowIndex, 3).toString().equalsIgnoreCase("Nam"));
                    
                    hocVien.setSo_dien_thoai(model.getValueAt(selectedRowIndex, 4) != null 
                            ? model.getValueAt(selectedRowIndex, 4).toString() : null);
                    
                    hocVien.setDia_chi(model.getValueAt(selectedRowIndex, 5) != null
                            ? model.getValueAt(selectedRowIndex, 5).toString() : null);
                    
                    hocVien.setTinh_trang((boolean) model.getValueAt(selectedRowIndex, 6));

                    HocVienJFrame frame = new HocVienJFrame(hocVien); 
                     frame.setTitle("Thông tin học viên");
                     frame.setResizable(false);
                     frame.setLocationRelativeTo(null);
                    frame.setVisible(true);
             }
      }

});
   /* 
        table.getColumnModel().getColumn(0).setMinWidth(0);
        table.getColumnModel().getColumn(0).setMaxWidth(0);
        table.getColumnModel().getColumn(0).setPreferredWidth(0);
        */
        /*table.getColumnModel().getColumn(1).setMinWidth(80);
        table.getColumnModel().getColumn(1).setMaxWidth(80);
        table.getColumnModel().getColumn(1).setPreferredWidth(80);*/
       
               
        table.getTableHeader().setFont(new Font("Arial", Font.BOLD, 14));
        table.getTableHeader().setPreferredSize(new Dimension(1350, 40));
        table.setRowHeight(50);
        table.validate();
        table.repaint();
        
        JScrollPane scroll = new JScrollPane();
        scroll.getViewport().add(table);
        scroll.setPreferredSize(new Dimension(1300, 400));
        jpnView.removeAll();
        jpnView.setLayout(new BorderLayout());
        jpnView.add(scroll);
        jpnView.validate();
        jpnView.repaint();
    }
    public void setEvent(){
       
        
        btnAdd.addMouseListener(new MouseAdapter(){
             @Override
            public void mouseClicked(MouseEvent e) {
                HocVienJFrame frame =  new HocVienJFrame(new HocVien());
                frame.setTitle("Thông tin học sinh");
                frame.setLocationRelativeTo(null);
                frame.setResizable(false);
                frame.setVisible(true);
            }
            @Override
            public void mouseEntered(MouseEvent e) {
                btnAdd.setBackground(new Color(0, 200, 83));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnAdd.setBackground(new Color(100, 221, 23));
            }
            
        });
    }
}
