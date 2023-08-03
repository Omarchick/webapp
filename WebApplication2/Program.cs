using Telegram.Bot;
using TelegramGptBot;
using TelegramTest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


TaskHandler.TaskId = Guid.NewGuid();
AutoSender.StartSending();


app.MapRazorPages();

app.Run();
