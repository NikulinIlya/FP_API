using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    interface IFunctionType<R>
    {
        R execute();
    }

    class FunctionType<R> : IFunctionType<R>
    {
        Func<R> func;
        public FunctionType(Func<R> func)
        {
            this.func = func;
        }

        R IFunctionType<R>.execute()
        {
            return func();
        }
    }

    class FunctionType<T,R> : IFunctionType<R>
    {
        Func<T,R> func;
        T arg;
        public FunctionType(Func<T, R> func, T arg)
        {
            this.func = func;
            this.arg = arg;
        }
        R IFunctionType<R>.execute()
        {
            return func(arg);
        }
    }

    class FunctionType<T1, T2, R> : IFunctionType<R>
    {
        Func<T1, T2, R> func;
        T1 arg1; T2 arg2;
        public FunctionType(Func<T1, T2,R> func,
            T1 arg1, T2 arg2)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
        }

        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2);
        }
    }

    class FunctionType<T1, T2, T3, R> : IFunctionType<R>
    {
        Func<T1, T2, T3, R> func;
        T1 arg1; T2 arg2; T3 arg3;
        public FunctionType(Func<T1, T2, T3, R> func,
            T1 arg1, T2 arg2, T3 arg3)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
        }
        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2, arg3);
        }
    }

    class FunctionType<T1, T2, T3, T4, R> : IFunctionType<R>
    {
        Func<T1, T2, T3, T4, R> func;
        T1 arg1; T2 arg2; T3 arg3; T4 arg4;
        public FunctionType(Func<T1, T2, T3, T4, R> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2, arg3, arg4);
        }
    }

    class FunctionType<T1, T2, T3, T4, T5, R> : IFunctionType<R>
    {
        Func<T1, T2, T3, T4, T5, R> func;
        T1 arg1; T2 arg2; T3 arg3; T4 arg4; T5 arg5;
        public FunctionType(Func<T1, T2, T3, T4, T5, R> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
            this.arg5 = arg5;
        }
        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2, arg3, arg4, arg5);
        }
    }

    class FunctionType<T1, T2, T3, T4, T5, T6, R> : IFunctionType<R>
    {
        Func<T1, T2, T3, T4, T5, T6, R> func;
        T1 arg1; T2 arg2; T3 arg3; T4 arg4; T5 arg5; T6 arg6;
        public FunctionType(Func<T1, T2, T3, T4, T5, T6,  R> func,
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
            this.arg5 = arg5;
            this.arg6 = arg6;
        }

        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    class FunctionType<T1, T2, T3, T4, T5, T6, T7, R> : IFunctionType<R>
    {
        Func<T1, T2, T3, T4, T5, T6, T7, R> func;
        T1 arg1; T2 arg2; T3 arg3; T4 arg4; T5 arg5; T6 arg6; T7 arg7;

        public FunctionType(Func<T1, T2, T3, T4, T5, T6, T7, R> func, 
            T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
            this.arg5 = arg5;
            this.arg6 = arg6;
            this.arg7 = arg7;
        }

        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }

    class FunctionType<T1, T2, T3, T4, T5, T6, T7, T8, R> : IFunctionType<R>
    {
        Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func;
        T1 arg1; T2 arg2; T3 arg3; T4 arg4; T5 arg5; T6 arg6; T7 arg7; T8 arg8;

        public FunctionType(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func,
          T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            this.func = func;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
            this.arg5 = arg5;
            this.arg6 = arg6;
            this.arg7 = arg7;
            this.arg8 = arg8;
        }
        R IFunctionType<R>.execute()
        {
            return func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }
}
