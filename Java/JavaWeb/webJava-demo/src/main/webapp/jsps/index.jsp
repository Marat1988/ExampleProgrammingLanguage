<html>
<body>
    <h2>Hello World!</h2>
    <p>Running</p>
    <p>Result 1 + 1 = ${1+1}</p>
    ${(1==1)?3:4}
    <hr/>

    <%@page import="com.example.servlet.models.Book" %>



    <%!
        int count = 0;
        String text = "Hi-hi";
        String getText(){
            return "HOHOHOHOHOHO";
        }
    %>


    <%
        Book book = new Book("Harry Poter", 1);
    %>

    <%=book.getId()%>
    <%=book.getTitle()%>
    <hr/>


    <%=count%>
    <%=text%>
    <%=getText()%>

    <hr/>

    <%
        for (int i = 0; i < 10; i++) {

        }

    %>

</body>
</html>
