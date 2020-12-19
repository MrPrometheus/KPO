using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public static class SortedAlg
    {
        // СОртировка рассечкой, модифицированный метод пузырьковой сортировки
        public static void CircleSort(IList<int> items)
        {
            // Необходимо сравнивать элементы стоящие на четгых и нечетных позициях
            int temp;
            // содать цикл по всем элементам
            for(var i = 0; i < items.Count; i++) {
                // Добавить сравнение, если позиция элемента четная
                if(i % 2 == 0) {
                    //ТО нужно пробежаться с помощью цикла по всем четным позициям
                    for(var j = 1; j < items.Count - 1; j += 2) {
                        // поменять местами если необходимо
                        if(items[j] > items[j + 1])
                        {
                            temp = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = temp;
                        }
                    }
                } else {
                    //ИНАЧЕ нужно пробежаться по всем нечетным поцизиям
                    for(var j = 0; j < items.Count - 1; j += 2) {
                        // поменять элементы если необходимо
                        if (items[j] > items[j + 1])
                        {
                            temp = items[j];
                            items[j] = items[j + 1];
                            items[j + 1] = temp;
                        }
                    }
                }

            }

        }

        public static void GnomSort(IList<int> items)
        {
            int temp;
            int i = 1;
            int j = 2;
            while(i < items.Count)
            {
                if(items[i - 1] < items[i])
                {
                    i = j;
                    j = j + 1;
                } else
                {
                    temp = items[i];
                    items[i] = items[i - 1];
                    items[i - 1] = temp;

                    i = i - 1;
                    if( i == 0)
                    {
                        i = j;
                        j = j + 1;
                    }
                }
            }
        }
    }
}
