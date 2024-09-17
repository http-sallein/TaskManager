namespace api.common
{
    public static class AppExtention
    {
        public static void ConfigureDevEnvironment(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapSwagger();
        }
    }
}