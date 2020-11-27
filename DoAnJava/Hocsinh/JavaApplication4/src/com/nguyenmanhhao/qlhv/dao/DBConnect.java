/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nguyenmanhhao.qlhv.dao;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author HAO
 */
public class DBConnect {

    public static Connection getConnection() {
        
        try {
            Connection cons = null;
           Class.forName("com.mysql.jdbc.Driver");  
           cons = DriverManager.getConnection(
                    "jdbc:mysql://localhost:3306/hocsinh", "root", "123456");
           return cons;
             
        } catch (Exception e) {
            e.printStackTrace(); 
        }
        return null;
    }
    /*Class.forName("com.mysql.jdbc.Driver");
            cons = DriverManager.getConnection(
                    "jdbc:mysql://localhost:3306/db_qlhv", "root", "");*/

    public static void main(String[] args) {
        System.out.println(getConnection()); 
    }
}