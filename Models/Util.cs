using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;

namespace FreneticLLCWebsite.Models
{
    public static class Util
    {
        public static readonly HtmlString Discord = new HtmlString("<a class=\"largelink\" href=\"/Go/Discord\">Discord<img src=\"/images/index/icon-discord.png\" height=\"25px\" /></a>");
    }
}
