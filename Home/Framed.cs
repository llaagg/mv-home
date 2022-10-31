using System;
using MV.Forms;
using MV.Interfaces;

namespace Home
{
    public class Framed
    {
        private readonly IMetaVerseRunner _context;
        private readonly Frame _parentComponent;
        private readonly IElement _element = null;
        private bool _visible;
        private readonly HFrame toolbar;

        public Framed(string dialer,
            Func<IElement> createDialer,
            IMetaVerseRunner context, 
            Frame parentComponent)
        {
            _context = context;
            _parentComponent = parentComponent;
            _element = createDialer();

            var b = new Button("=");
            b.Clicked += () =>
            {
                this.Toggle();
            };

            toolbar = new HFrame();
            toolbar.Add(new Label(dialer));
            toolbar.Add(b);

            parentComponent.Add(toolbar);
        }
        
        private void Toggle()
        {
            _visible = !_visible;
            if (this._visible)
            {
                _context.Show(_element);
            }
            else
            {
                _context.Hide(this._element);
            }
        }
    }
}