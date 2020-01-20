using System;
using System.Collections;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            AbsIterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.First();
            while(item != null) {
                Console.WriteLine(item);
                item = i.Next();
            }
            
            Console.ReadKey();
        }
    }

    public abstract class AbsIterator {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
    public abstract class Aggregate
    {
        public abstract AbsIterator CreateIterator();
    }

    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();
        public override AbsIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }

    public class ConcreteIterator: AbsIterator {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate){
            this._aggregate = aggregate;
        }
        public override object First(){
            return _aggregate[0];
        }
        public override object Next(){
            object ret=null;
            if(_current < _aggregate.Count -1) {
                ret = _aggregate[++_current];
            }
            return ret;
        }
        public override object CurrentItem(){
            return _aggregate[_current];
        }
        public override bool IsDone(){
            return _current >= _aggregate.Count;
        }
    }
}
