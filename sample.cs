// C# Test Case to open the URL
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_Automation
{
class Program
{
	static void Main(string[] args)
	{
		IWebDriver driver = new ChromeDriver("Path to Chrome Driver");

// This will open up the URL
	driver.Url = "https://www.exos.com/”;
}
}
}

// C# Program to check whether the
// element is present in the List
// or not
using System;
using System.Collections;
using System.Collections.Generic;

class Sample {

// Main Method
public static void Main(String[] args)
{

// Creating an List<T> of Integers
List<int> firstlist = new List<int>();

// Adding elements to List
firstlist.Add(1);
firstlist.Add(2);
firstlist.Add(3);
firstlist.Add(4);
firstlist.Add(5);
firstlist.Add(6);
firstlist.Add(7);

// Checking whether 4 is present
// in List or not
Console.Write(firstlist.Contains(4));
}
}
