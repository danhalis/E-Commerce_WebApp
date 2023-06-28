﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_WebApp.Shared
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; } = default;
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
