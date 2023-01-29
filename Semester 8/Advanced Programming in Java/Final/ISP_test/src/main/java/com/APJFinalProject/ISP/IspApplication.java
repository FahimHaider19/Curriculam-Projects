package com.APJFinalProject.ISP;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

@SpringBootApplication
public class IspApplication {

	public static void main(String[] args) {
		SpringApplication.run(IspApplication.class, args);
	}

}
