﻿https://github.com/PacktPublishing/ASP.NET-Core-2-and-Angular-5


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


tsconfig.json: 	angularCompilerOptions object, which can be used to
configure the behavior of the Angular AoT compiler: the strictMetadataEmit setting which
we added will tell the compiler to report syntax errors immediately rather than produce an
error log file.

Angular AOT: https://angular.io/guide/aot-compiler


Webpack is the most used--and arguably the most powerful nowadays--module
bundler for modern JavaScript applications. Its main job is to recursively build a dependency
graph of all the NPM modules needed by the client-side application before starting it,
package them all into a small number of bundles--often only one--and then feed them (or it)
to the browser.
Dramatically reduces the HTTP requests to load the client-side assets in normal
scenarios, that is, when no package managers, task runners, or concatenation
strategies are being used
Dramatically reduces the chance of variable conflicts when using standard
concatenation strategies such as the .concat().uglify().writeTo() chains
featured by Gulp, Grunt, and the likes
Dramatically increases the control over static files, as it can be configured to
skip all the "dead" JS/CSS and even image (!) assets, reduce/optimize the size of
CSS files even before minifying them, easily switch between CDNs URLs and
locally hosted files, and so on

Wht is Angular Universal ?
The official site states that Universal is “Server-side Rendering for Angular apps”. It’s the middleware that sits between node.js and Angular.
Simply put, it offers best of both worlds: the user experience and high performance and of SPA’s combined with the SEO friendliness of static pages
https://medium.com/burak-tasci/angular-4-with-server-side-rendering-aka-angular-universal-f6c228ded8b0
https://universal.angular.io/

Client app cleanup :82
test

The main reason for building a ViewModel instead of directly passing the Model entities is
that it only represents the data that we want to use, and nothing else;
Another advantage is the additional security it gives, since we can
protect any field from being serialized and passed through the HTTP channel

Adding other controllers pg 100