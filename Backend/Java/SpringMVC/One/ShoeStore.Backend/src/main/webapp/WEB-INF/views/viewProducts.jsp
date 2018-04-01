<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>      
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>View Products</title>
</head>
<body>
	<table border="1">
	<thead>
		<tr>
			<th>Id</th>
			<th>Code</th>
			<th>Name</th>
			<th colspan="2">Action</th>
		</tr>
	</thead>
	<tbody>
		<c:forEach items="${list}" var="product">
			<tr>
				<td>${product.id}</td>
				<td>${product.code}</td>
				<td>${product.name}</td>
				<td>
					<a href="editProducts/${product.id}">Update</a>
				</td>
				<td>
					<a href="deleteProducts/${product.id}">Delete</a>
				</td>
			</tr>
		</c:forEach>
	</tbody>
	</table>
	<p><a href="addProducts">Add Product</a></p>
</body>
</html>