using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrbanTrivia.App_Code;

/// <summary>
/// Summary description for WordRepository
/// </summary>
public class WordRepository : IWordRepository
{
    public WordRepository()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public IQueryable<UrbanWord> GetUrbanWordById(int Id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<UrbanWord> GetUrbanWords()
    {
        throw new NotImplementedException();
    }
}