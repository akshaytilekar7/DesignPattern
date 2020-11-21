/*
 1] app.Use vs app.Run vs app.Map in ASP.NET 
 
 app.Use may call next middleware component in the pipeline. 
 app.Run will never call subsequent middleware
 in short :  await next() can call in app.use() but not in app.run()


    app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<html><body>");
                await context.Response.WriteAsync("<div>middleware 1 APP.USE</div>");
                await next();
                await context.Response.WriteAsync("</body></html>");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("<div>middleware 1 APP.RUN</div>");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<html><body>");
                await context.Response.WriteAsync("<div>middleware 2 APP.USE</div>");
                //await next();
                await context.Response.WriteAsync("</body></html>");
            });
    
    ANSWER :    middleware 1 APP.USE
                middleware 1 APP.RUN

    if we comment app.RUN()
                middleware 1 APP.USE
                middleware 2 APP.USE

    *]  app.Map("/maptest", HandleTest);
        private static void HandleTest(IApplicationBuilder app)
        {
            app.Run(async context => {
                await context.Response.Write("map called")
            });
        }

        // will see "map called" only for following request is made
            localhost://44563/maptest


        -   

    2] map requests to responses?
        app.UseMvc(routes => { routes.MapRoute("default","{controller=Home}/{action=Index}/{id?}"); }); 
        OR
        [Route(“reviews/{reviewId}”)]
        public ActionResult Show(int reviewId) { … }

    3]  ConfigureServices vs Configure
        -   ConfigureServices is used to add services to our application
        -   Ex. add EF
            public void ConfigureServices(IServiceCollection services)  
            {
                services.Configure<AppSettings>(Configuration.GetSubKey("AppSettings"));
                services.AddEntityFramework()
                        .AddSqlServer()
                        .AddDbContext<SchoolContext>();
                // Add MVC services to the services container.
                services.AddMvc();
            }

        -   Configure
            -   Configure method is used to set up middleware
            -   We manage HTTP request pipeline inside of Configure method
            -   Inside of Configure method, we write code that will process every request and eventually make a response
            -   Example Adding show custom error page in the development environment.
                public void Configure(IApplicationBuilder app, IHostingEnvironment env)
                {
                    if (env.IsDevelopment())
                    {
                        app.UseDeveloperExceptionPage();
                    }
                }

    4] WWW ROOT :
        all the static resources, such as CSS, JavaScript, and image files are kept under the wwwroot folder

    5] How to enable static content?
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
        }
    6]
        Transient - objects are always different; a new instance is provided to every controller and every service.

        Singleton -  objects are the same for every object and every request.
 
        Scoped - objects are the same within a request, but different across different requests.-
               - It is equivalent to a singleton in the current scope.  
                 For example, in MVC it creates one instance for each HTTP request, 
                 but it uses the same instance in the other calls within the same web request.
    7]
        -   Command line style development
        -   all os

    8] DB connectivity
        -    services.AddDbContext<UserDbContext>
             (opts =>
             opts.UseInMemoryDatabase("userDB") // dbName
             );

             services.AddScoped<UserDbContext>();

             // Other databases could have been connected using UseSqlServer
             UseSqlServer(Configuration["ConnectionString:UserDB"]).

            one to one →an author can write only one book, and a book only have one author.
            one to many →an author can write multiple books, but book can only have one author.
            many to many →an author can write multiple books, and also a book can be written by multiple authors.

   9]
        ON DELETE CASCADE : parent delete child also get deleted
        ON DELETE SET NULL : parent delete child set to null

   10]        
        Run, Map and Use are three methods that you will need to use to configure HTTP Pipeline






 */