namespace netcore_lesson1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Trần Quang Quân");

            app.Run();
        }
    }
}
