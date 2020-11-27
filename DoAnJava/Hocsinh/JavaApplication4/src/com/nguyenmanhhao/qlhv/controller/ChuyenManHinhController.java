     /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.controller;

import com.nguyenmanhhao.qlhv.bean.DanhMucBean;
import com.nguyenmanhhao.view.HocVienJPanel;
import com.nguyenmanhhao.view.KhoaHocJPanel;
import com.nguyenmanhhao.view.ThongKeJPanel;
import com.nguyenmanhhao.view.TrangChuJPanel;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import javax.swing.JLabel;
import javax.swing.JPanel;

/**
 *
 * @author HAO
 */
public class ChuyenManHinhController {
    private JPanel root;
    private String kindSlected = "";
    private java.util.List<DanhMucBean> listItem = null;
    

    public ChuyenManHinhController(JPanel jpnRoot) {
  
        this.root = jpnRoot;
    }
    
    public void setView(JPanel jpnItem, JLabel jlbItem){
        kindSlected = "TrangChu";
        jpnItem.setBackground(new Color(96, 100, 191));
        jlbItem.setBackground(new Color(96, 100, 191));
        root.removeAll();
        root.setLayout(new BorderLayout());
        root.add(new TrangChuJPanel());
        root.validate();
        root.repaint();
    }
 
     /**
     *
     * @param <error>
     * @param listItem
     */
   
    public void setEvent(java.util.List<DanhMucBean> listItem){
        this.listItem = listItem;
         for(DanhMucBean item : listItem){
           item.getJlb().addMouseListener(new LableEvent(item.getKind(), item.getJpn(), item.getJlb()));
         }   
    }
    class  LableEvent implements MouseListener{
        private JPanel node;
        private String kind;
        private JPanel jpnItem;
        private JLabel jlbItem;

        public LableEvent(String kind, JPanel jpnItem, JLabel jlbItem) {
            this.kind = kind;
            this.jpnItem = jpnItem;
            this.jlbItem = jlbItem;
        }
        @Override
        public void mouseClicked(MouseEvent e) {
           switch(kind){
               case "TrangChu":
                   node = new TrangChuJPanel();
                   break;
               case "HocVien":
                   node = new HocVienJPanel();
                   break;
                case "KhoaHoc":
                   node = new KhoaHocJPanel();
                   break;
                case "ThongKe":
                    node = new ThongKeJPanel();
                    break;
                
                   default:
                       node = new TrangChuJPanel();
                       break;
           }
           root.removeAll();;
           root.setLayout(new BorderLayout());
           root.add(node);
           root.validate();
           root.repaint();
            setChangeBackgroud(kind);
        }

        @Override
        public void mousePressed(MouseEvent e) {
            kindSlected = kind;
            jlbItem.setBackground(new Color(96, 100, 191));
            jpnItem.setBackground(new Color(96, 100, 191));
        }

        @Override
        public void mouseReleased(MouseEvent e) {
            
        }

        @Override
        public void mouseEntered(MouseEvent e) {
            jlbItem.setBackground(new Color(96, 100, 191));
            jpnItem.setBackground(new Color(96, 100, 191));
        }

        @Override
        public void mouseExited(MouseEvent e) {
            if(!kindSlected.equalsIgnoreCase(kind)){
                jlbItem.setBackground(new Color(76, 175, 80));
                jpnItem.setBackground(new Color(76, 175, 80));
            }
        }
        
    }
    private void setChangeBackgroud(String kind){
        for(DanhMucBean itemBean: listItem){
            if(itemBean.getKind().equalsIgnoreCase(kind)){
                itemBean.getJpn().setBackground(new Color(96, 100, 191));
                itemBean.getJlb().setBackground(new Color(96, 100, 191));
            }else{
                itemBean.getJpn().setBackground(new Color(76, 175, 80));
                itemBean.getJlb().setBackground(new Color(76, 175, 80));
            }
        }
    }
}
