package com.example.servlet;


import com.example.servlet.models.Book;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;


@WebServlet("/testJSP")
public class TestJSP extends HttpServlet {
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        Book book = new Book("Inro Java", 2);
        req.setAttribute("book", book);

        getServletContext().getRequestDispatcher("/myjsp").forward(req, resp);
    }
}
