<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@page import="java.util.*"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	Hello from jsp
	<br>

	<%!private int sum(int a, int b) {
		return a + b;
	}

	String s = "hello";%>
	<br>
	<%=sum(1, 3)%>
	<br>
	
	<%for(int k = 0; k < 5; k++){
	%>
	
	<br>
	
	k=<%=k %>
	
	
	<%
	}
	%>
</body>
</html>