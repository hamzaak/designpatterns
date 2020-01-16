/*
    ### SINGLETON ###
    ---------------------------------------------------------------------------------------------------
    Sometimes we need to have only one instance of our class 
    for example a single DB connection shared by multiple objects as creating 
    a separate DB connection for every object may be costly. 
    Similarly, there can be a single configuration manager 
    or error manager in an application that handles all problems instead of creating multiple managers.

    Definition: The singleton pattern is a design pattern that restricts the instantiation of a class to one object.
*/

using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;

            Console.WriteLine("Hello World!");
        }
    }

    /*
    
    // 1. NO THREAD SAFETY
    sealed class Singleton
    {
        private static Singleton instance;
       
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }

        }

        // lazy initialization
        private Singleton() {}
    }
    
    // 2. THREAD SAFE BUT PERFORMANCE ISSUE: since a lock is required every time an instance is requested
    sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object padlock = new object(); // For thread safety

        public static Singleton Instance
        {
            get
            {
                lock(padlock) {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }

        }

        // lazy initialization
        private Singleton() {}
    }

    // 3. THREAD SAFE USING DOUBLE CHECK LOCKING: 
    // the thread is locked on a shared object and checks whether an instance has been created or not with double checking.
    sealed class Singleton
    {
        private static Singleton instance;
        private static readonly object padlock = new object(); // For thread safety

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }

        }
        Singleton() { }
    }

    // 4. THREAD SAFE WITHOUT USING LOCKS and LAZY INSTANTIATION
    public sealed class Singleton  
    {  
        private static readonly Singleton instance = new Singleton();  
        // This type of implementation has a static constructor, so it executes only once per Application Domain.
        static Singleton()  
        {  
        }  
        private Singleton()  
        {  
        }  
        public static Singleton Instance  
        {  
            get  
            {  
                return instance;  
            }  
        }
    }  
    
    // 5. Fully lazy instantiation: Nested classes
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }

    */

    // 6. Fully laziness with .NET 4 (or higher) and Lazy<T> type 
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private Singleton()
        {
        }
    }

}
