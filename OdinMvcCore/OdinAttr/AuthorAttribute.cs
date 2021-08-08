using System;

namespace OdinPlugs.OdinWebApi.OdinMvcCore.OdinAttr
{
    public class AuthorAttribute : Attribute
    {
        public string AuthorName { get; set; }

        public AuthorAttribute(string authorName)
        {
            AuthorName = authorName;
        }
    }
}