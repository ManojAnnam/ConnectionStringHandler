﻿using System;
using System.Collections.Generic;

namespace ConnectionStringHandler.Repository.DBModels
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
