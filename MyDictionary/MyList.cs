using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<TKey,TValue>
    {

        TKey[] keyArray;
        TValue[] valueArray;

        TKey[] tempKeyArray;
        TValue[] tempValueArray;

        public MyList()
        {
            keyArray = new TKey[0];
            valueArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeyArray = keyArray;
            tempValueArray = valueArray;

            keyArray = new TKey[keyArray.Length + 1];
            valueArray = new TValue[valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
            }

            for (int i = 0; i < valueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }

            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value;

        }

        public TKey[] items1
        {
            get { return keyArray; }
        }

        public TValue[] items2
        {
            get { return valueArray; }
        }

    }
}
