namespace Home;

using System.Threading.Tasks;
using MV.Forms;
using MV.Interfaces;
using MV.Models;

public class HomeManifest : IManifest, IVerse
{
    private IMetaVerse? ctx;

    public VerseDefinition Definition()
    {
        return new VerseDefinition()
        {
            E=new List<VerseReference>()
            {
                new VerseReference(){
                    GH="no-where",
                    N= '0',
                    Name = new I18NString("Watch")
                },
            },
            Name = new ("Hello world")
        };
    }

    public Task Init(IMetaVerse context)
    {
        this.ctx = context;
        return Task.CompletedTask;
    }

    public Task Loop()
    {
        return Task.CompletedTask;
    }

    public Task Start()
    {
        this.ctx.Show(new Frame());
        return Task.CompletedTask;
    }

    public IVerse Verse()
    {
        return this;
    }
}

