package com.init.servlets;

import jakarta.servlet.ServletContext;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(urlPatterns = {"/context"})
public class ContextServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        PrintWriter writer = resp.getWriter();
        writer.write("Hello Context Servlet!!!\n");
        ServletContext context = req.getServletContext();
        String name = context.getInitParameter("Name");
        writer.write("parametr = " + name);
        writer.write("\n-------------------------------------\n");

        ServletContext contextAll = req.getServletContext();
        contextAll.setAttribute("param", "Yo-Yo");
        String param = (String) getServletContext().getAttribute("param");
        writer.write("parametr = " + param);


    }
}
