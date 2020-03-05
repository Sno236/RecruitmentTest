using System;
using System.Collections.Generic;
using System.Linq;

namespace GunvorRecruitment
{
    public class DifferenceFinder<T> where T : IEquatable<T>
    {
        public Differences<T> FindDifferences(IEnumerable<T> first, IEnumerable<T> second)
        {
            var objectsMissingFirst = new List<T>();
            var objectsMissingSecond = new List<T>();

            //var noMatch = first.Where(el => el.Bar.Id == matchId);
           objectsMissingFirst = second.Except(first.Select(s => s)).ToList();
           objectsMissingSecond = first.Except(second.Select(s => s)).ToList();
            //foreach (var element in first)
            //{
            //    bool found = false;

            //    foreach (var a in second)
            //    {
            //        if (element.Equals(a))
            //        {
            //            found = true;
            //            break;
            //        }
            //    } 

            //    if (!found)
            //    {
            //        objectsMissingSecond.Add(element);
            //    }
            //}

            //foreach (var element in second)
            //{
            //    bool found = false;

            //    foreach (var a in first)
            //    {
            //        if (element.Equals(a))
            //        {
            //            found = true;
            //            break;
            //        }
            //    }

            //    if (!found)
            //    {
            //        objectsMissingFirst.Add(element);
            //    }
            //}

            return new Differences<T>
                       {
                           ObjectsMissingInFirstList = new List<T>(objectsMissingFirst),
                           ObjectsMissingInSecondList = new List<T>(objectsMissingSecond)
                       };
        }
    }

    public class Differences<T>
    {
        public IEnumerable<T> ObjectsMissingInFirstList;
        public IEnumerable<T> ObjectsMissingInSecondList;
    }
}
