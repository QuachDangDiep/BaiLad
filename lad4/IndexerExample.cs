using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lad4
{
    class IndexerExample
    {
        public int [] intList = new int[10];
        public int this [int index]{
            get{
                return intList[index];
            }
            set{
                intList[index] = value;
            }
        }
        class IndexerDemo{
            static void Main(){
                int i, j = 0;
                IndexerExample indexTest = new IndexerExample();
                for(i = 0; i < 10; i++){
                    indexTest[i] = j;
                    j++;
                }
                for(i = 0; i < 5; i++){
                    Console.WriteLine("indexTset[{0}] is {1}", i , indexTest[i]);
                    Console.ReadLine();
                }
            }
        }
    }
}