using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
            // Mặc định URL kết nối tới hub là /signalr, nhưng trong một số trường hợp ta muốn overwrite lại thì dùng cấu trúc bên dưới.
            //app.MapSignalR("/signalr", new HubConfiguration());
            // -------Cấu hình chi tiết hơn -------
            //var hubConfiguration = new HubConfiguration();
            //hubConfiguration.EnableDetailedErrors = true; // Kích hoạt thông báo lỗi chi tieert default là false
            //hubConfiguration.EnableJavaScriptProxies = false; // Vô hiệu hóa các tệp proxy JavaScript được tạo auto
            //app.MapSignalR("/signalr", hubConfiguration);
        }
    }
}
