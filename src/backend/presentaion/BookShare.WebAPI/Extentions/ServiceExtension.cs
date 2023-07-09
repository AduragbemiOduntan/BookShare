namespace BookShare.WebAPI.Extentions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) 
        { 
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options => { });
    }
}
