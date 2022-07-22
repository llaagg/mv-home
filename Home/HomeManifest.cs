namespace Home;

using System.Threading.Tasks;
using MV.Forms;
using MV.Interfaces;
using MV.Models;

public class HomeManifest : IManifest, IVerse
{
    private IMetaVerse ctx;

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
        //1. create UI
        //2. ask to show it

        
        

        var f = new VFrame();
        f.Add(new Label("Hello world"));
        f.Add(new Label("ma"));
        f.Add(new Label("kota"));
        f.Add(new Button("Zed"));
        var bt = new Button("z");
        bt.Clicked+=()=>{
            Console.WriteLine("ok");
        };
        f.Add(bt);
        
        this.ctx.Show(f);

        return Task.CompletedTask;
    }

    public IVerse Verse()
    {
        return this;
    }
}

