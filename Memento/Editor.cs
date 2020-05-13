using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Editor
    {


        public string Content { get; set; }


        public void Restore(EditorState state)
        {
            Content = state.Content;

        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

    }
}
