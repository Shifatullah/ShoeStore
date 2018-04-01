package com.shoestore.dao;

import java.sql.Connection;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import java.util.ArrayList;
import java.util.List;

import com.shoestore.model.Product;
import com.shoestore.util.DbUtil;


public class ProductDao {
	
	private Connection connection;
	
	public ProductDao() {
		connection = DbUtil.getConnection();
	}
	
	public void addProduct(Product p) {
		try {
			PreparedStatement preparedStatement = connection.prepareStatement("insert into products(code, name) values (?, ?)");
			preparedStatement.setString(1, p.getCode());
			preparedStatement.setString(2, p.getName());
			preparedStatement.executeUpdate();
		} catch(SQLException e){
			e.printStackTrace();
		}
	}

	public void deleteProduct(int id) {
		try {
			PreparedStatement preparedStatement = connection.prepareStatement("delete from products where id = ?");	
			preparedStatement.setInt(1, id);
			preparedStatement.executeUpdate();
		} catch(SQLException e) {
			e.printStackTrace();
		}
	}
	
	public void updateProduct(Product p) {
		try {
			PreparedStatement preparedStatement = connection.prepareStatement("update products set code = ?, name = ? where id = ?");	
			preparedStatement.setString(1, p.getCode());
			preparedStatement.setString(2, p.getName());
			preparedStatement.setInt(3, p.getId());
			preparedStatement.executeUpdate();
		} catch(SQLException e) {
			e.printStackTrace();
		}
	}
	
	public List<Product> getAllProducts(){
		List<Product> products = new ArrayList<Product>();
		try {			
			Statement statement = connection.createStatement();
			ResultSet rs = statement.executeQuery("select * from products");
			while(rs.next()) {
				Product p = new Product();
				p.setId(rs.getInt("id"));
				p.setCode(rs.getString("code"));
				p.setName(rs.getString("name"));	
				products.add(p);
			}
			return products;
		} catch(SQLException e) {
			e.printStackTrace();
		}
		return products;
	}
	
	public Product getProductById(int id) {
		Product p = new Product();
		try {
			PreparedStatement preparedStatement = connection.prepareStatement("select * from products where id = ?");
			preparedStatement.setInt(1, id);
			ResultSet rs = preparedStatement.executeQuery();
			if(rs.next()) {				
				p.setId(rs.getInt("id"));
				p.setCode(rs.getString("code"));
				p.setName(rs.getString("name"));
				return p;
			}
		} catch(SQLException e) {
			e.printStackTrace();
		}
		
		return p;
	}

}