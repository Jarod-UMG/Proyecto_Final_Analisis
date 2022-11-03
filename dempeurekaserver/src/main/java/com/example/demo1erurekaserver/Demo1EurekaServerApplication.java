package com.example.demo1erurekaserver;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.netflix.eureka.server.EnableEurekaServer;

@EnableEurekaServer
@SpringBootApplication
public class Demo1EurekaServerApplication {

    public static void main(String[] args) {
        SpringApplication.run(Demo1EurekaServerApplication.class, args);
    }

}
