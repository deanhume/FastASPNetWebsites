Using this tool
---------------

The sample application for the book **High Performance ASP.net** is called the **“Surf Store Application”**. It is meant to simulate an eCommerce store and not be too dissimilar from many sites that you see online today. The sample application may also seem rather basic at first, but the key thing is that the web pages contain all the elements that a standard website would have. There is JavaScript, CSS, HTML, and images – all of these make up the components of a webpage front end that we are trying to improve upon.

![Surf Store Application][2]

The ASP.net MVC sample application
---------------

The MVC sample application in this book has been written using ASP.net MVC 4 and the Razor view engine. In many aspects it is almost the same as the ASP.net Webforms sample application, except it has been written to suit the MVC pattern.

The ASP.net Webforms sample application
---------------
Also included with each chapter is a ASP.net Webforms sample application. This has been written using .Net 4 and it should fit the standard pattern of a Webforms application. You will also notice that each file structure contains a **Before and After** folder.

![Folder Structure][1]

The different folders contain the solutions of both the **MVC and Webforms** applications. The Before folder contains the solutions before any optimizations have been applied. This is so that you can run through the example in each chapter and apply the changes. Next, the After folder contains the files after the changes have been applied – this way you can check and compare against the changes you have made.

One important caveat worth mentioning is that the built-in development webserver, known as Cassini, which comes with Visual Studio doesn’t quite reproduce the full blown IIS that we need as we run through in this book. When in development, you might need to deploy your application or the sample application to your Localhost, a server with IIS installed, or you can use IIS express. This will give you the best results when running through each example.

  [1]: http://c1431883.r83.cf3.rackcdn.com/Folder-Structure.jpg
  [2]: http://c1431883.r83.cf3.rackcdn.com/SampleApplication.jpg
