using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting_Algo
{
    public abstract class SortCreator
    {
        public abstract ISorts FactoryMethod();

        public ISorts Operation() 
        {
            return FactoryMethod();
        }
    }

    public class ConcreteCreatorB : SortCreator
    {
        public override ISorts FactoryMethod()
        {
            return new BubbleSort();
        }
    }

    public class ConcreteCreatorI : SortCreator
    {
        public override ISorts FactoryMethod()
        {
            return new InsertionSort();
        }
    }

    public class ConcreteCreatorS : SortCreator
    {
        public override ISorts FactoryMethod()
        {
            return new SelectionSort();
        }
    }

    public class ConcreteCreatorM : SortCreator
    {
        public override ISorts FactoryMethod()
        {
            return new MergeSort();
        }
    }
}
