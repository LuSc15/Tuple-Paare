namespace Tuple_Paare
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
            Console.WriteLine("Aufgabe 1:");

            Aufgabe1();
            Console.WriteLine("\nAufgabe 2:");
                Aufgabe2();
            }



            #region Aufgabe1
            public static void Aufgabe1()
            {
                int[] arr = { 9, 42, 60, 33, 38, 7, 7, 11 };
                string[] arr2 = { "a", "b", "c", "d", "e" };
                Paare(arr);
            Console.WriteLine();
                Paare(arr2);
            }
            private static (T, T)[] Paare<T>(T[] arr)
            {
                (T, T)[] tuppleArr = new (T, T)[arr.Length / 2];

                int ende = arr.Length;
                if (arr.Length % 2 == 1)
                {
                    ende = arr.Length - 1;
                }
                for (int i = 0; i < ende; i += 2)
                {
                    Console.Write("Tupel Nr." + (i / 2 + 1));
                    Console.WriteLine((arr[i], arr[i + 1]));
                    tuppleArr[i / 2] = (arr[i], arr[i + 1]);
                }
                return tuppleArr;
            }
            #endregion
            #region Aufgabe2
            public static void Aufgabe2()
            {
                int[] erstesArr = { 21, 65, 6, 1, 14, 58, 56, 38, 18, 2 };
                int[] zweitesArr = { 95, 1, 86, 32, 66, 27, 67, 10, 54, 55, 999 };
            Console.WriteLine("Array 1:");
            foreach(int i in erstesArr) Console.Write(i+",");
            Console.Write("\b \n");
            Console.WriteLine("Array 2:");
            foreach (int i in zweitesArr) Console.Write(i+",");
            Console.Write("\b \n");
            PaareReißverschluss(erstesArr, zweitesArr);

            }
            //public static (T,T)[] PaareRV<T>(T[] arr1, T[] arr2)
            //{
            //    int länge = arr1.Length > arr2.Length ? arr2.Length : arr1.Length;
            //    (T, T)[]tupleArr = new (T, T)[länge];
            //    for(int i = 0; i<länge;i++)
            //    {
            //        tupleArr[i] = (arr1[i], arr2[i]);
            //        Console.WriteLine(tupleArr[i]);
            //    }
            //    return tupleArr;
            //}

            //public static (A, B)[] PaareReißverschluss<A,B>(A[] arr1, B[] arr2) where A : INumber<A> where B : INumber<B> 
            //{
            //    int länge = arr1.Length > arr2.Length ? arr2.Length : arr1.Length;
            //    var tupleArr = new (A, B)[länge];
            //    for (int i = 0; i < länge; i++)
            //    {
            //        var tuple = (Wert1: arr1[i], Wert2: arr2[i]);
            //        tupleArr[i] = tuple;
            //        Console.WriteLine(tupleArr[i]);
            //    }

            //    return tupleArr;
            //}



            public static (A,B)[] PaareReißverschluss<A,B>(A[] arr1, B[] arr2)
            {
                int länge = Math.Min(arr1.Length, arr2.Length);
                var tupleArr = new (A, B)[länge];

             // var namedTupleArr = new (Wert1: A,Wert2: B)[länge];

            for (int i = 0; i < länge; i++)
                {
                    var tuple = (Wert1: arr1[i], Wert2: arr2[i]);
                    tupleArr[i] = tuple;
                    Console.WriteLine(tupleArr[i]);
             //    Console.WriteLine(tuple.Wert1);
            }

                return tupleArr;
            }
            #endregion
    }
}


   

