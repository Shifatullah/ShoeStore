<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>      
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Edit Product</title>
</head>
<body>
	<h1>Edit Product</h1>
	<form:form method="post" action="/backend/editAndSave">
	<table>
		<tr>
			<td>Id:</td>
			<td>
				<form:input path="id" readonly="true"></form:input>
			</td>
		</tr>	
		<tr>
			<td>Code:</td>
			<td>
				<form:input path="code"></form:input>
			</td>
		</tr>
		<tr>
			<td>Name:</td>
			<td>
				<form:input path="name"></form:input>
			</td>
		</tr>		
		<tr>
			<td></td>
			<td>
				<input type="submit" value="Save" />
			</td>		
		</tr>
	</table>
	</form:form>
</body>
</html>