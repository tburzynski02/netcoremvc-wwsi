﻿using FilmDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Contexts
{
    public class FilmContext : DbContext
    {
        public Dbset<FilmModel> Films { get; set; }

        protected override void OnConfiguring
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbContextOptions.UserSqlServer(cs);
    }
}
