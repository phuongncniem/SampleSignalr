using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalrChat.Hubs
{
    public class ChatHub : Hub
    {

        public void SendP(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
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