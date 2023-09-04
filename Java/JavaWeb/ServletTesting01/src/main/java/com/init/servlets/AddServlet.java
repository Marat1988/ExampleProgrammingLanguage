package com.init.servlets;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.io.PrintWriter;


@WebServlet(urlPatterns = "/sum")
public class AddServlet extends HttpServlet {
//    @Override
//    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
//        int a = Integer.parseInt(req.getParameter("number1"));
//        int b = Integer.parseInt(req.getParameter("number2"));
//
//        PrintWriter writer  = resp.getWriter();
//        int answer = a + b;
//        writer.write("result = " + answer);
//    }

//    @Override
//    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
//        int a = Integer.parseInt(req.getParameter("number1"));
//        int b = Integer.parseInt(req.getParameter("number2"));
//
//        PrintWriter writer  = resp.getWriter();
//        int answer = a + b;
//        writer.write("result = " + answer);
//    }

    @Override
    protected void service(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        int a = Integer.parseInt(req.getParameter("number1"));
        int b = Integer.parseInt(req.getParameter("number2"));

        PrintWriter writer  = resp.getWriter();
        int answer = a + b;
        writer.write("result = " + answer);
    }
}
