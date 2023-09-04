package com.init.servlets;

import jakarta.servlet.ServletConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(urlPatterns = "/lifestyle")
public class LifeStyle extends HttpServlet {

    int a = 0;

    @Override
    public void init(ServletConfig config) throws ServletException {
        System.out.println("Init service");
        //log("Init service");
    }

    @Override
    public void service(ServletRequest req, ServletResponse res) throws ServletException, IOException {
        System.out.println("Service before");
        super.service(req, res);
        System.out.println("Service after");

    }

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        System.out.println("doGet before");
        final PrintWriter writer = resp.getWriter();
        a += 10;
        writer.println("a = " + a);
        writer.write("doGet after");
    }

    @Override
    public void destroy() {
        System.out.println("Destroy servlet");
        // log("Destroy servlet");

    }
}
