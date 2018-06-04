Microsoft.Aspnetcore.spa, configuration files
https://blogs.msdn.microsoft.com/webdev/2017/02/14/building-single-page-applications-on-asp-net-core-with-javascriptservices/

What is HotModuleReplacement ?
HotModuleReplacement : https://webpack.js.org/concepts/hot-module-replacement/

/wwwroot/ folder, which will contain the compiled, ready-to-publish contents of our application: HTML, JS, and CSS files, along with
fonts, images, and everything else we want our users to have access to in terms of static file.

Webhost vs WebServer:
The host is responsible for application startup and lifetime management.The server is responsible for accepting HTTP requests. Part of the host's
responsibility includes ensuring that the application's services and the server are available and properly configured. We could think of the host as
being a wrapper around the server. The host is configured to use a particular server; the server is unaware of its host
http://aspnetcore.readthedocs.io/en/stable/fundamentals/hosting.html

The appsettings.json file is nothing less than the replacement of the good old Web.config file.

 

	tsconfig.json:
	angularCompilerOptions object, which can be used to
configure the behavior of the Angular AoT compiler: the strictMetadataEmit setting which
we added will tell the compiler to report syntax errors immediately rather than produce an
error log file.

Angular AOT: https://angular.io/guide/aot-compiler

pg:64
