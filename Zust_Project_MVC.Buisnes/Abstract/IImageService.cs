﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zust_Project_MVC.Buisnes.Abstract
{
    public interface IImageService
    {
        Task<string> SaveFileAsync(IFormFile file);
    }
}
