using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class History
    {
        public List<EditorState> States { get; set; } = new List<EditorState>();

        
        public void Push(EditorState state)
        {
            States.Add(state);
        }

        public EditorState Pop()
        {
            var lastState = States.Last();
            States.RemoveAt(States.Count - 1 );
            return lastState;

        }
    }
}
