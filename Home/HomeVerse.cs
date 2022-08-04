using System.Threading.Tasks;
using MV.Forms;
using MV.Interfaces;

namespace Home
{
    internal class HomeVerse : IVerse
    {
        private IMetaVerse Context;

        public HomeVerse()
        {
        }
       
        public Task Init(IMetaVerse context)
        {
            this.Context = context;
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

            var dialer = new VFrame();
            for(int x=0;x<3;x++)
            {
                var row = new HFrame();
                for(int y=0;y<3;y++)
                {
                    int number = x + (y *3) + 1;
                    row.Add(new Label($"{number}"));
                }
                dialer.Add(row);
            }

            var lastRow = new HFrame();
            lastRow.Add(new Label($"0"));
            dialer.Add(lastRow);

            dialer.Add(new Button("Close"));

            this.Context.Show(dialer);

            return Task.CompletedTask;
        }
    }
}