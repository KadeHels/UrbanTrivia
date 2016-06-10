using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UrbanTrivia.App_Code;

/// <summary>
/// Summary description for WordContext
/// </summary>
public class WordContext : DbContext
{
    public WordContext() 
        : base("WordConnection")
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DbSet<UrbanWord> Words { get; set; }
}