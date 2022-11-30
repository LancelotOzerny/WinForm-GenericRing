using System.Collections;
using System.Collections.Generic;

namespace GenericRingForm
{
    public class GenericRing<T> : IEnumerable<T>
    {
        private Node<T> _firstElement = null;
        private Node<T> _lastElement = null;
        private Node<T> _currentElement = null;

        private int _count = 0;
        private int _maxNodesCount;

        /// <summary>
        /// Свойство, которое позволяет получить текущее количество элементов в кольцевом списке
        /// </summary>
        public int Count { get => _count; }

        /// <summary>
        /// Свойство, которое позволяет получить максимальное количество элементов кольцевого списка
        /// </summary>
        public int MaxCount { get => _maxNodesCount; }

        /// <summary>
        /// конструктор по умолчанию, принимающий максимальное количество элементов кольцевого списка
        /// </summary>
        /// <param name="maxItemsCount"></param>
        public GenericRing(int maxItemsCount)
        {
            _maxNodesCount = maxItemsCount;
        }

        /// <summary>
        /// Метод, который позволяет добавить в список новый элемент
        /// </summary>
        /// <param name="data">Значение нового элемента</param>
        public void Push(T data)
        {
            // Т. К. Список постоянного размера, то проверяем не выходим ли за пределы
            if (Count >= MaxCount)
            {
                throw new System.Exception("Ошибка при добавлении элемента: Добавляемый элемент превышает максимальное количество элементов.");
            }

            // Создаем элемент
            Node<T> node = new Node<T>(data);

            // Если это первый элемент
            if (_firstElement == null)
            {
                // То ставим его в качестве первого элемента
                _firstElement = node;

                // И делаем ссылку на самого себя. Список ведь кольцевой
                _firstElement.Next = _firstElement;
            }
            else
            {
                // Если элемент второй (_lstElement == null)
                if (_lastElement == null)
                {
                    // то добавляем перому ссылку на него
                    _firstElement.Next = node;
                    
                    // и текущему ставим значение
                    _lastElement = node;
                }

                // если более элемент по счету второй и далее, то
                _lastElement.Next = node; // у последнего элемента будет занчение ДАННОГО элемента
                _lastElement = node; // теперь последним будет данный
                _lastElement.Next = _firstElement; // и ставим новому элементу ссылку на первый

                // т.к. элементы передаются по ссылке, то получается
                // ->первый элемент -> ... -> последний элемент -> первый элемент (добавить новый)
                // ->первый элемент -> ... -> последний (ранее) элемент -> новый (последний сейчас) элемент -> первый элемент            }
            }
            _count++;
        }
        
        /// <summary>
        /// Метод, позволяющий получить следующий элемент в кольцевом списке (первый, если впервые)
        /// </summary>
        /// <returns>текущий элемент</returns>
        public T Head()
        {

            // Если элементов нет - выводим ошибку
            if (Count == 0)
            {
                throw new System.Exception("Ошибка при получении текущего значения. Кольцо пустое!");
            }
                   
            // Если элемент null - делаем Next
            if (_currentElement == null)
            {
                Next();
            }

            return _currentElement.Value;
        }

        public void Next()
        {
            // Если вызываем впервые, то возвращаем первый элемент
            if (_currentElement == null)
            {
                _currentElement = _firstElement;
            }
            // иначе следующий
            else
            {
                _currentElement = _currentElement.Next;
            }
        }

        /// <summary>
        /// Метод, который позволяет получить элемент по индексу
        /// </summary>
        /// <param name="index">индекс искомого элемента</param>
        /// <returns>значение полчаемого элемента</returns>
        public T Get(int index)
        {
            // Если выходим за пределы списка
            if (index < 0 || index >= Count)
            {
                throw new System.Exception("Элемента с таким индексом не существует. Проверьте индекс!");
            }

            // Создаем результат и перебираем его index-раз
            Node<T> element = _firstElement;
            for (int i = 0; i < index; ++i)
            {
                element = element.Next;
            }

            return element.Value;
        }





        // реализация интерфейса IEnumerable<T>. Можно было бы через Get, но... 
        // Одному уже сказали сделать через интерфейс)
        // А сам этот интерфейс позволяет использовать foreach оператор
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _firstElement;
            do
            {
                if (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }
            }
            while (current != _firstElement);
        }
    }
}
