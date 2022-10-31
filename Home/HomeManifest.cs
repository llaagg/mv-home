using System.Collections.Generic;
using MV.Interfaces;
using MV.Models;

namespace Home
{
    public class HomeManifest : IManifest
    {
        private readonly HomeVerse _verse = new HomeVerse();

        public VerseDefinition Definition()
        {
            return new VerseDefinition()
            {
                E = new List<VerseReference>()
                {
                    new VerseReference{
                        GH="https://github.com/llaagg/mv-home", // self
                        N= '0',
                        Name = new I18NString("Home")
                    },
                    new VerseReference{
                        GH=@"https://github.com/llaagg/mv-doc",
                        N= '0',
                        Name = new I18NString("Docs")
                    },
                },
                Name = new I18NString("Home")
            };
        }
        
        public IVerse Verse()
        {
            return this._verse;
        }
    }
}