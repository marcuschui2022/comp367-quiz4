namespace comp367quiz4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // migrate local Database to the cloud
            // enable web app to access data stored in local database, and display all data on the web page
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
