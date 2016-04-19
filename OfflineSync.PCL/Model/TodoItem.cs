﻿using Newtonsoft.Json;

namespace OfflineSync.PCL.Model
{
    public class ToDoItem
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public bool Complete { get; set; }

        public string UserId { get; set; }
    }
}
