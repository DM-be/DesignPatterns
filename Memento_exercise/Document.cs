using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_exercise
{
    class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }    


        public DocumentState CreateState()
        {
            return new DocumentState
            {
                Content = Content,
                FontName = FontName,
                FontSize = FontSize
            };
        }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontSize = state.FontSize;
            FontName = state.FontName;
        }
    }
}
