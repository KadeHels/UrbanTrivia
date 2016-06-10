using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrbanTrivia.App_Code;

/// <summary>
/// Summary description for IWordRepository
/// </summary>
public interface IWordRepository
{
    IQueryable<UrbanWord> GetUrbanWords();
    IQueryable<UrbanWord> GetUrbanWordById(int Id);
}