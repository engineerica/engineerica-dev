# Engineerica Products Extensions #

This project provides a framework for connecting to **AccuClass**, **Conference Track**, **AccuWB**, **AccuClub**, **AccuTraining** and **AccuCampus**. Just download the generated API and connect your systems to our applications easily.

Accudemia users, please visit: https://github.com/engineerica/accudemiaext/

You can also check out [Engineerica's Developer Hub](https://developers.engineerica.com/) to explore the RESTful APIs and resources for our products and services. Follow our [quickstart guide](https://developers.engineerica.com/gettingstarted/) to view code examples that will guide you in interacting with our APIs.


# Download #

Download the latest compiled version from here:

https://drive.google.com/folderview?id=0B5S-aT-V07k-R2paV0FKRzNZVUE&usp=sharing

Download the latest client libraries from here (optional): 

https://github.com/engineerica/engineerica-dev/tree/master/client-libraries

Deprecated libraries are located here: https://github.com/engineerica/engineerica-dev/tree/master/deprecated


# How to use it? #

We currently provide a .NET API you can use in your applications.  Also, there's an example you can find the _Source_ tab to get started easily.

In order to use this API you will need either `MonoDevelop` or Visual Studio.NET 2010.  The API is compiled in .NET 4.0.

Steps to connect to one of our systems:

1. Create a new C# or VB.NET project.

2. Download the compiled API (link above) and uncompress it.

3. Add a reference to the DLL `EngineericaApi`.dll.

4. In any class you have or in the _Main(...)_ method, login to the server as follows:

```
  EngineericaApi.AccuClass.Login.Execute("domain", "your@email.edu", "password123", "token");
```

> Where "token" must be kept as is.

5. Now, do whatever you want to do. For example, if you want to export your students data, you can request the data to be exported in HTML, CSV or XLSX format using the following code:
```

// Request the data to be exported
var exp = EngineericaApi.AccuClass.Export.Execute(EngineericaApi.AccuClass.ExportType.Students, "HTML");

var jobId = new Guid(exp.Response.JobId.ToString());
do {
	Console.Clear();
	Console.WriteLine("Monitoring Job #" + jobId);	

	System.Threading.Thread.Sleep(1000);

	// Get the job status
	var res = EngineericaApi.AccuClass.Bgjob.Getstatus(jobId, null);
	
	foreach (var r in res.Response.results[0].Statuses)
	{
		Console.WriteLine(r.Message);
	}
	
	// Check it's completed
	if (res.Response.results[0].Succeed.Value) break;
} while(true);

// Once it's ready, you can open the file, download it or do whatever you want.
System.Diagnostics.Process.Start("http://www.accuclass.net/JobResults/" + jobId + ".html");
```

# Support #

For support, please contact us using the [Contact Us Form](http://www.engineerica.com/contact/general?reason=support&from=engineerica-dev-site).
