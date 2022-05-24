using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByndyusoftTest
{
    internal class ArrayExt
    {
        public ArrayExt() { }

        /// <summary>
        /// Вычисление суммы двух наименьших чисел массива.
        /// В ТЗ не сказан тип чисел массива, поэтому double.
        /// </summary>
        /// <param name="array">Массив чисел с длиной не менее двух элементов.</param>
        /// <returns>Сумма двух минимальных элементов массива.</returns>
        /// <exception cref="ArgumentException">Недостаточная длина массива</exception>
        public static double CalcSum2Min(double?[]? array)
        {
            if (array == null)
                throw new ArgumentNullException("Массив не может быть пустым");
            if (array.Length < 2)
                throw new ArgumentException("Для поиска длина массива должна быть не менее двух элементов.");
            if (array[0] == null || array[1] == null)
                throw new NullReferenceException("Массив не может содержать null значения");

            double? min1 = array[0];
            double? min2 = array[1];
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == null)
                    throw new NullReferenceException("Массив не может содержать null значения");

                if (array[i] < min1)
                {
                    min1 = array[i];
                }
                else if (array[i] < min2)
                {
                    min2 = array[i];
                }
            }
            return (double)(min1 + min2);
        }
    }
}
