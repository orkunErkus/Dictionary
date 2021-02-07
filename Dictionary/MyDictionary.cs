using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {

        TKey[] Key;
        TValue[] Value;
      
        public MyDictionary()
        {
            Key = new TKey[0];
            Value = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempArray1 = Key; // referans numarası uçmasın deger tutucu
            TValue[] tempArray2 = Value;
            

            Key = new TKey[Key.Length + 1];
            Value = new TValue[Value.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)  // deger tutucudan degerleri geri almak
            {
                Key[i] = tempArray1[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)  
            {
                Value[i] = tempArray2[i];
            }
            Value[Value.Length - 1] = value;
            Key[Key.Length - 1] = key;
        }
    }
}
