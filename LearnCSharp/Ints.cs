using System.Collections;

namespace LearnCSharp
{
    public class Ints : IEnumerable
    {
        int[] _values;

        public Ints(params int[] values)
        {
            _values = values;
        }

        public IEnumerator GetEnumerator()
        {

            //return _values.Cast<object>().GetEnumerator();

            foreach (var item in _values)
            {
                yield return item;
            }



        }


    }






}
