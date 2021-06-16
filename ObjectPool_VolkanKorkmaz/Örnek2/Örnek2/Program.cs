using Microsoft.Extensions.ObjectPool;
using System;

namespace Örnek2
{
    class ExampleObject
    {
        public ExampleObject()
        {
            Console.WriteLine($"{nameof(ExampleObject)} nesnesi oluşturulmuştur. Id : {_id}");
        }
        public ExampleObject(int id)
        {
            _id = id;
            Console.WriteLine($"{nameof(ExampleObject)} nesnesi oluşturulmuştur. Id : {_id}");
        }

        public void Write() => Console.WriteLine($"Id : {_id}");
        int _id;

        static void Main(string[] args)
        {
            DefaultObjectPoolProvider objectPoolProvider = new DefaultObjectPoolProvider();
            ObjectPool<ExampleObject> objectPool = objectPoolProvider.Create(new DefaultPooledObjectPolicy<ExampleObject>());//Constructor parametresiz olmalı.
            ExampleObject object1 = objectPool.Get();
            object1.Write();
            objectPool.Return(object1);

            ExampleObject object2 = objectPool.Get();
            object2.Write();
            objectPool.Return(object2);
        }
    }
}
