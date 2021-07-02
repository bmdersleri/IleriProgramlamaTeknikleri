using System;
using System.Collections.Concurrent;

namespace Örnek1
{
    
    class ObjectPool<T>
    {
        private readonly ConcurrentBag<T> _objects;
        private readonly Func<T> _objectGenerator;
        public ObjectPool(Func<T> objectGenerator)
        {
            _objectGenerator = objectGenerator ?? throw new ArgumentException(nameof(objectGenerator));
            _objects = new ConcurrentBag<T>();
        }

        public T Get() => _objects.TryTake(out T item) ? item : _objectGenerator();
        public void Return(T item) => _objects.Add(item);
    }
    class ExampleObject
    {
        int _id;
        public ExampleObject(int id)
        {
            _id = id;
            Console.WriteLine($"{nameof(ExampleObject)} nesnesi oluşturulmuştur. Id : {_id}");
        }

        public void Write()
        {
            Console.WriteLine($"Id : {_id}");
        } 
            
        

        static void Main(string[] args)
        {
            ObjectPool<ExampleObject> objectPool = new ObjectPool<ExampleObject>(() => new ExampleObject(1));
            ExampleObject object1 = objectPool.Get();
            object1.Write();
            objectPool.Return(object1);

            ExampleObject object2 = objectPool.Get();
            object2.Write();
            objectPool.Return(object2);
        }
    }

}
