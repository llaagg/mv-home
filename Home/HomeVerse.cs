using System.Threading.Tasks;
using MV.Forms;
using MV.Interfaces;

namespace Home
{
    internal class HomeVerse : IVerse
    {
        private Label _textLine;

        private string _number = "";

        public HomeVerse()
        {
        }

        public Task Loop()
        {
            return Task.CompletedTask;
        }

        public Task Start()
        {
            //1. create UI
            //2. ask to show it

            _textLine =
                new Label();
                //new MV.Forms.Editor();
            this.Context.Show(_textLine);

            var dialer = new VFrame();
            for(int x=0;x<3;x++)
            {
                var row = new HFrame();
                for(int y=0;y<3;y++)
                {
                    int number = x + (y *3) + 1;
                    row.Add(this.AddNumberButton(number));
                }
                dialer.Add(row);
            }

            var lastRow = new HFrame();
            lastRow.Add(new Label($"0"));
            dialer.Add(lastRow);

            var b = new Button("Close");
            b.Clicked += () =>
            {
                Context.Show(new Button("a"));
            };
            dialer.Add(b);

            this.Context.Show(dialer);

            return Task.CompletedTask;
        }

        private IElement AddNumberButton(int number)
        {
            var b = new Button(number.ToString());
            b.Clicked += () =>
            {
                this._textLine.Text = _number + number.ToString();
                this.Context.Show(this._textLine);
            };
            return b;
        }

        public Task Init(IMetaVerseRunner context)
        {
            this.Context = context;
            return Task.CompletedTask;
        }

        public IMetaVerseRunner Context { get; set; }
    }
}