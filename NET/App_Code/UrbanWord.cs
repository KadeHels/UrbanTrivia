using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrbanTrivia.App_Code
{
    /// <summary>
    /// Summary description for Word
    /// </summary>
    public class UrbanWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Definition { get; set; }
        
        public UrbanWord()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}