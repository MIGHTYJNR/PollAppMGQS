﻿namespace MgqsPollApp.Dtos
{
    public class PollOptionDto
    {
        public string Text { get; set; }
        public int VoteCount { get; set; }
    }

    public class CreatePollOptionRequestModel
    {
        public string Text { get; set; }
        public int VoteCount { get; set; }
    }
}
