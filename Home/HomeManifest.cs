using System.Collections.Generic;
using MV.Interfaces;
using MV.Models;

namespace Home
{
    public class HomeManifest : IManifest
    {
        private IMetaVerse Context;

        private HomeVerse _verse = new HomeVerse();

        public VerseDefinition Definition()
        {
            return new VerseDefinition()
            {
                E = new List<VerseReference>()
                {
                    new VerseReference(){
                        GH="no-where",
                        N= '0',
                        Name = new I18NString("Watch")
                    },
                },
                Name = new I18NString("Hello world")
            };
        }
        
        public IVerse Verse()
        {
            return this._verse;
        }
    }
}