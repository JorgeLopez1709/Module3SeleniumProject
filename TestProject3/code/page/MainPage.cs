﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject3.code.control;

namespace TestProject3.code.page
{
    public class MainPage

    {
        public Button loginButton = new Button(By.XPath("//li/a[@href=\"/auth/login\"]"));
    }
}
