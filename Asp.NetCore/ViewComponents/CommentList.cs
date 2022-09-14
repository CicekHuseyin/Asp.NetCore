﻿using Asp.NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Hüseyin"
                },
                new UserComment
                {
                    ID=2,
                    Username="Mesut"
                },
                new UserComment
                {
                    ID=3,
                    Username="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}
