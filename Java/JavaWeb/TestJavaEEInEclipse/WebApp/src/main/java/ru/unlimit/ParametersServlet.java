package ru.unlimit;

import jakarta.servlet.ServletContext;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

import java.io.IOException;
import java.io.PrintWriter;


@WebServlet(urlPatterns="/ParametersServlet", loadOnStartup=0)
public class ParametersServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	
	@Override
	public void init() throws ServletException {
		super.init();
		System.out.println("Initialization servlet");
	}


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String user = request.getParameter("user");
		HttpSession session = request.getSession();
		ServletContext context = request.getServletContext();
		if (user!="" && user!=null) {
			session.setAttribute("user", user);
			context.setAttribute("user", user);
		}
		//session.setMaxInactiveInterval(5);
		response.setContentType("text/html;charser=utf-8");
		PrintWriter out = response.getWriter();
		out.println("Request parameter: " + user + "<br>");
		out.println("Session parameter: " + session.getAttribute("user") + "<br>");
		out.println("Context parameter: " + context.getAttribute("user") + "<br>");
		out.println("<a href = 'http://localhost:8080/WebApp/Parameters.html'>Назад</a><br>");
		out.close();
		
		System.out.println("session time in seconds: " + session.getMaxInactiveInterval());
	}

}
