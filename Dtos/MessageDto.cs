﻿namespace MgqsPollApp.Dtos
{
    public class MessageDto
    {
        public string Sender { get; set; } 
        public string Content { get; set; } 
    }

    public class CreateMessageRequestModel
    {
        public string Sender { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int ChatRoomId { get; set; }
    }
}
