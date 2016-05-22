using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Menus.Lib;

namespace Menus.Model
{
    public class CompositeIterator : IIterator<MenuComponent>
    {
        IIterator<MenuComponent> _firstIterator;
        Stack<IIterator<MenuComponent>> _stack = new Stack<IIterator<MenuComponent>>();

        public CompositeIterator(IIterator<MenuComponent> iterator)
        {
            // The iterator of the top-level composite we're going to iterate over is passed in.
            // We throw that in the data structure.
            _stack.Push(iterator);
            _firstIterator = iterator;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool HasNext()
        {
            // To see if there is a next element, we check to see if the stack is empty; if so, there isn't.
            if (_stack.Count == 0)
            {
                return false;
            }
            else
            {
                // Otherwise, we get the iterator off the top of the stack and see if it has a next element.
                // If it doesn't we pop it off the stack and call MoveNext() recursively.
                IIterator<MenuComponent> iterator = _stack.Peek();
                if (!iterator.HasNext())
                {
                    _stack.Pop(); ;
                    return HasNext();
                }
                else
                {
                    // Otherwise, there is a next element and we return true.
                    return true;
                }
            }
        }

        public MenuComponent Next()
        {
            // When the client wants to get the next element, we make sure there is one by calling MoveNext()
            if (HasNext())
            {
                // If there is a next element, we get the current iterator off the stack and gets its next element
                IIterator<MenuComponent> iterator = _stack.Peek();
                MenuComponent component = iterator.Next();

                // We then throw that component's iterator on the stack.
                // If the component is a Menu, it will iterate over all its items.
                // If the component is a MenuItem, we will get the NullIterator, and no iteration happens.
                _stack.Push(component.CreateIterator());

                // We then return the component.
                return component;
            }
            else
            {
                return null;
            }
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            _stack.Clear();
            _stack.Push(_firstIterator);
        }
    }
}
