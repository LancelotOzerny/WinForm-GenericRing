using System;

namespace GenericRingForm
{
    public class Node<T>
    {
        private Node<T> _next;
        private T _value;

        /// <summary>
        /// Свойство, которое позволяет получить или изменить следующий элемент кольцевого списка
        /// </summary>
        public Node<T> Next 
        {
            get => _next; 
            set => _next = value; 
        }

        /// <summary>
        /// Свойство, которое позволяет получить значение кольцевого списка
        /// </summary>
        public T Value 
        { 
            get => _value; 
        }


        /// <summary>
        /// Конструктор с параметрами, который принимает в виде входных данных
        /// значение, которое будет хранить экземпляр класса
        /// При этом происходит обнуление (присваивание к null) у ссылки
        /// ведущей на следующий элемент
        /// </summary>
        /// <param name="value">значение, которое будет хранить экземпляр</param>
        public Node(T value)
        {
            this._value = value;
            this._next = null;
        }

        /// <summary>
        /// Конструктор с параметрами, который принимает в виде входных данных
        /// значение, которое будет хранить экземпляр класса и
        /// ссылку на следющий объект
        /// </summary>
        /// <param name="value">значение, которое будет хранить экземпляр</param>
        /// <param name="next">Ссылка на следющий элемент</param>
        public Node(T value, Node<T> next)
        {
            this._value = value;
            this._next = next;
        }
    }
}
