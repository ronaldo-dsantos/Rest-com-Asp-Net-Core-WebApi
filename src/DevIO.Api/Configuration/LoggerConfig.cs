namespace DevIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "7d7d15419d1b4dd18d884dfc7f02a52d";
                o.LogId = new Guid("195d6f3a-560a-4040-86e5-d35cf237b10f");
            });

            services.AddLogging(o =>
            {
                services.AddElmahIo(o =>
                {
                    o.ApiKey = "7d7d15419d1b4dd18d884dfc7f02a52d";
                    o.LogId = new Guid("195d6f3a-560a-4040-86e5-d35cf237b10f");
                });               
            });

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}
