using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MSIP_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIP_App.Models
{
    public static class SeedDatabase
    {
        public static void SeedData(this ModelBuilder modelBuilder ) 
        {
            modelBuilder.Entity<Urls>().HasData(

                new Urls{Id=1,Name="Embry-Riddle",
                    Url="https://fed.erau.edu/oamfed/idp/wsfed11?wa=wsignin1.0&wtrealm=urn%3amyernie%3asharepoint&wctx=https%3a%2f%2fernie.erau.edu%2f_layouts%2f15%2fAuthenticate.aspx%3fSource%3d%252F" },
                new Urls{Id=2,Name="Microsoft Military Education Portal",
                    Url="https://miledu.microsoft.com/login?next=/mssainfo" },
                new Urls{Id=3,Name="Skillpipe", 
                    Url = "https://www.skillpipe.com/#/account/login" },
                new Urls{Id=4,Name="Microsoft Azure Portal", 
                    Url = "https://portal.azure.com/" },
                new Urls{Id=5,Name="Learn On Demand",
                    Url="https://mssa-erau.learnondemand.net/User/Login?ReturnUrl=%2fUser%2fCurrentTraining%2f1395478" }
                );
        }
    }
}
