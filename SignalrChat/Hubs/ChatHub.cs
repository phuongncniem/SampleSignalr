using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalrChat.Hubs
{
    [HubName("CustomNameChatHub")] // Thay đổi tên class được gọi trong javaScript ở client. Sử dụng name trong Script ở client là có phân biệt hoa thường
    public class ChatHub : Hub
    {

        // Muốn client có thể gọi được method SendP thì method phải đc khai báo ở trạng thái public
        [HubMethodName("SendP")] // Tương tự như HubName dùng để thay đổi tên gọi của method khi gọi từ client.
        public async Task SendP(string name, string message)
        {
           await  Clients.Others.addNewMessageToPage(name, message);
        }

        public void SendPrivated(string name, string message, string connId)
        {
            Clients.Client(connId).appendNewMessage(name, message);
        }

        public void SendGroup(string name, string message, string connId)
        {
            Clients.Group(connId).appendNewMessage(name, message);
        }
    }
}