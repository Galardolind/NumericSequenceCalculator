# NumericSequenceCalculator

Web application to compute numeric sequences

##Technologies

C#, .Net, MVC, REST API, AngularJS, Bootstrap, Selenium.

##How to run

To simplify the process, I uploaded the whole visual studio project to the gitHub repository.(The process to deploy is explained on UI Test part)

1. Download the project (clone via gitHub) or direct download [link](https://github.com/Galardolind/NumericSequenceCalculator/archive/master.zip)
2. Proceed as following
  1. (optional)Unzip
  2. Open Visual Studio (I use Visual Studio Community 2015 v 14.0)
  3. Click on 'Open project' then choose the 'NumericSequenceCalculator.sln' file
3. Click on F5 (by default) to run the application
4. The application is ready to be used

##UI tests  && Unit Tests

To Run the UI tests, you need to deploy the application. To do the UI tests I used IIS and Selenium.

1. Open the project
2. Click on Build (The top menu) → Publish NumericSequenceCalculator
3. Setup with your own IIS (If you are not familiar with it follow [this tutorial](https://msdn.microsoft.com/en-us/library/dd465337%28v=vs.110%29)
4. Open the UI directory inside the 'NumericSequenceCalculator.Test' project → open the 'UnitTest1.cs' file
5. Modify the 'SITE_PATH' variable on line 16 to adapt with your server link
6. Rebuild the project → Verify if your web server is correctly launched
7. Run All the test ( Ctrl+R, A )
 


