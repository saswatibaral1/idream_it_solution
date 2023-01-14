package com.idream.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class IdreamController {

	@GetMapping("/")
	public String loadIndex() {
		return "index.html";
	}
}