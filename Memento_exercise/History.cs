using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento_exercise
{
    class History
    {
        public List<DocumentState> DocumentStates { get; set; } = new List<DocumentState>();

        public DocumentState Pop()
        {
            var lastState = DocumentStates.Last();
            DocumentStates.RemoveAt(DocumentStates.Count - 1);
            return lastState;
        }

        public void Push(DocumentState state)
        {
            DocumentStates.Add(state);
        }
    }
}
