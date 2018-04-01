package com.shoestore.backend;

import java.text.DateFormat;
import java.util.Date;
import java.util.List;
import java.util.Locale;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.servlet.ModelAndView;

import com.shoestore.dao.ProductDao;
import com.shoestore.model.Product;

/**
 * Handles requests for the application home page.
 */
@Controller
public class HomeController {

	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);

	/**
	 * Simply selects the home view to render by returning its name.
	 */
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Locale locale, Model model) {
		logger.info("Welcome home! The client locale is {}.", locale);

		Date date = new Date();
		DateFormat dateFormat = DateFormat.getDateTimeInstance(DateFormat.LONG, DateFormat.LONG, locale);

		String formattedDate = dateFormat.format(date);

		model.addAttribute("serverTime", formattedDate);

		return "home";
	}

	@Autowired
	ProductDao dao;

	@RequestMapping("/addProducts")
	public ModelAndView showform() {
		return new ModelAndView("addProducts", "command", new Product());
	}

	@RequestMapping(value = "/addProducts", method = RequestMethod.POST)
	public ModelAndView save(@ModelAttribute(" ") Product product) {
		dao.addProduct(product);
		return new ModelAndView("redirect:/viewProducts");
	}

	@RequestMapping("/viewProducts")
	public ModelAndView viewProducts() {
		List<Product> list = dao.getAllProducts();
		return new ModelAndView("viewProducts", "list", list);
	}

	@RequestMapping("/editProducts/{id}")
	public ModelAndView edit(@PathVariable int id) {
		Product product = dao.getProductById(id);
		return new ModelAndView("editProducts", "command", product);
	}

	@RequestMapping(value = "/editAndSave", method = RequestMethod.POST)
	public ModelAndView editsave(@ModelAttribute("product") Product product) {
		dao.updateProduct(product);
		return new ModelAndView("redirect:/viewProducts");
	}

	@RequestMapping("/deleteProducts/{id}")
	public ModelAndView delete(@PathVariable int id) {
		dao.deleteProduct(id);
		return new ModelAndView("redirect:/viewProducts");
	}

}
