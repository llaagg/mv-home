using System.Threading.Tasks;
using MV.Forms;
using MV.Interfaces;

namespace Home
{
    internal class HomeVerse : IVerse
    {
        private Label _textLine;

        private string _number = "";

        
        public Task Start()
        {
            var toolbar = new HFrame();

            var framed = new Framed("Dialer", CreateDialer, this.Context, toolbar);
            var framed1 = new Framed("Exits", () => new Label("A"), this.Context, toolbar);

            this.Context.Show(toolbar);

            return Task.CompletedTask;
        }

        private VFrame CreateDialer()
        {
            var dialerFrame = new VFrame();
            
            var topFrame = new HFrame();
            _textLine = new Label();
            topFrame.Add(_textLine);
            topFrame.Add(AddRemoveButton());
            dialerFrame.Add(topFrame);
            

            var dialer = new VFrame();
            for (int x = 0; x < 3; x++)
            {
                var row = new HFrame();
                for (int y = 0; y < 3; y++)
                {
                    int number = x + (y * 3) + 1;
                    row.Add(this.AddNumberButton(number));
                }

                dialer.Add(row);
            }

            var lastRow = new HFrame();
            lastRow.Add(new Label("≣"));
            lastRow.Add(AddNumberButton(0));
            dialer.Add(lastRow);

            dialerFrame.Add(dialer);
            return dialerFrame;
        }

        private IElement AddRemoveButton()
        {
            var b = new Button("<-");
            b.Clicked += () =>
            {
                if (_number.Length > 0)
                {
                    _number = _number.Substring(0, _number.Length - 1);
                    this._textLine.Text = _number;
                    this.Context.Update(this._textLine);
                }
            };
            return b;
        }

        private IElement AddNumberButton(int number)
        {
            var b = new Button(number.ToString());
            b.Clicked += () =>
            {
                _number += number.ToString();
                this._textLine.Text = _number;
                this.Context.Update(this._textLine);
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