namespace Group2MVC;

public class Program
{
    public static void Main(string[] args)
    {
        var bobthebuilder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        bobthebuilder.Services.AddControllersWithViews();

        var app = bobthebuilder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();


    }
    private void FirstMethod()
    {
        Console.WriteLine("Hej");
    }

    private void SecondMethodFromBransch()
    {
        Console.WriteLine("Hej");
    }

    private void ThirdMethodFrom()
    {
        Console.WriteLine("Hello World");
    }
}
