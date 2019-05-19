using System;
using System.CodeDom;
using System.Collections;
using System.Runtime.InteropServices;

namespace Ejercicios
{
    public class CommonStack : IStack
    {
        private ArrayList _stackList = new ArrayList();
        private int _size = 0;

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object can't be null");
            _stackList.Add(obj);
            _size++;
        }

        public object Pop()
        {
            if (_size == 0)
                throw new InvalidOperationException("Stack is empty, not object can be popped");

            object removed = _stackList[_size - 1];
            _stackList.RemoveAt(_size - 1);
            _size--;
            return removed;
        }

        public void Clear()
        {
            _stackList.Clear();
            _size = 0;
        }
    }

    public interface IStack
    {
        void Push(object obj);
        object Pop();
        void Clear();
    }

    public class Stack
    {
        private readonly IStack _stack;


        public Stack(IStack stack)
        {
            _stack = stack;
        }

        public void Push(object obj)
        {
            _stack.Push(obj);
        }

        public object Pop()
        {
            return _stack.Pop();
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}