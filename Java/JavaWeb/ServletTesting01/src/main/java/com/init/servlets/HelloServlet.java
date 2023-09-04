package com.init.servlets;

import jakarta.servlet.ServletConfig;
import jakarta.servlet.ServletContext;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebInitParam;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Enumeration;

@WebServlet(
        urlPatterns = {"/hello"},
        initParams = {
                @WebInitParam(name = "version", value = "1.0001"),
                @WebInitParam(name = "port", value = "8080"),
                @WebInitParam(name = "protocol", value = "TCP/IP")
        }
)
public class HelloServlet extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ServletConfig config = this.getServletConfig();
        Enumeration e = config.getInitParameterNames();
        PrintWriter writer = resp.getWriter();
        writer.write("Hello Servlet!!!\n");
        while (e.hasMoreElements()) {
            String name = (String) e.nextElement();
            String value = config.getInitParameter(name);
            writer.write(String.format("Name = %s, Param = %s\n", name, value));
        }
        ServletContext context = req.getServletContext();
        String name = context.getInitParameter("Name");
        writer.write("parametr = " + name);
        writer.write("\n-------------------------------------\n");

        ServletContext contextAll = this.getServletContext();
        String param = (String) getServletContext().getAttribute("param");
        writer.write("parametr = " + param);
        //contextAll.removeAttribute("param");

        Enumeration<String> en = contextAll.getAttributeNames();

        while (en.hasMoreElements()) {
            String element = (String) en.nextElement();
            log(element);
        }


    }
}
