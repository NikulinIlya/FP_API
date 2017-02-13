﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class Expression<T>
    {

        public static dynamic Value(List<T> arg1, params List<T>[] lists)
        {
            if (lists == null || lists.Length == 0)
            {
                return new ListArguments<T>(arg1);
            }
            else
            {
                List<List<T>> list = new List<List<T>>();
                list.Add(arg1);
                foreach (var l in lists)
                    list.Add(l);
                return new NListArguments<T>(list);
            }
        }

        public static IfThen<T> If(Func<dynamic,Boolean> cond)
        {
            return new IfThen<T>(cond);
        }
    }
}
