#region 程序集 Microsoft.VisualStudio.Shell.12.0, Version=12.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Decompiled with ICSharpCode.Decompiler 7.1.0.6543
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio
{
    public sealed class ErrorHandler
    {
        private static HashSet<Type> criticalExceptions;

        private ErrorHandler()
        {
        }

        public static bool Succeeded(int hr)
        {
            return hr >= 0;
        }

        public static bool Failed(int hr)
        {
            return hr < 0;
        }

        public static int ThrowOnFailure(int hr)
        {
            return ThrowOnFailure(hr, null);
        }

        public static int ThrowOnFailure(int hr, params int[] expectedHRFailure)
        {
            if (Failed(hr) && (expectedHRFailure == null || Array.IndexOf(expectedHRFailure, hr) < 0))
            {
                Marshal.ThrowExceptionForHR(hr);
            }

            return hr;
        }

        public static bool IsRejectedRpcCall(int hr)
        {
            if (hr != -2147417845 && hr != -2147417846)
            {
                return hr == -2147417847;
            }

            return true;
        }

        static ErrorHandler()
        {
            criticalExceptions = new HashSet<Type>();
            criticalExceptions.Add(typeof(StackOverflowException));
            criticalExceptions.Add(typeof(AccessViolationException));
            criticalExceptions.Add(typeof(AppDomainUnloadedException));
            criticalExceptions.Add(typeof(BadImageFormatException));
            criticalExceptions.Add(typeof(DivideByZeroException));
        }

        public static bool IsCriticalException(Exception ex)
        {
            return criticalExceptions.Contains(ex.GetType());
        }

        //public static int CallWithCOMConvention(Func<int> method, bool reportError = false)
        //{
        //    return CallWithCOMConvention(method, reportError, setShellErrorInfo: true);
        //}

        //internal static int CallWithCOMConvention(Func<int> method, bool reportError, bool setShellErrorInfo)
        //{
        //    try
        //    {
        //        return method();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (IsCriticalException(ex))
        //        {
        //            throw;
        //        }

        //        int hRForException = Marshal.GetHRForException(ex);
        //        if (setShellErrorInfo)
        //        {
        //            IVsUIShell vsUIShell = Package.GetGlobalService(typeof(SVsUIShell), setShellErrorInfo: false) as IVsUIShell;
        //            if (vsUIShell != null)
        //            {
        //                vsUIShell.SetErrorInfo(hRForException, ex.Message, 0u, null, ex.StackTrace);
        //                if (reportError)
        //                {
        //                    vsUIShell.ReportErrorInfo(hRForException);
        //                }
        //            }
        //        }

        //        return hRForException;
        //    }
        //}

        //public static int CallWithCOMConvention(Action method, bool reportError = false)
        //{
        //    return CallWithCOMConvention(delegate
        //    {
        //        method();
        //        return 0;
        //    }, reportError);
        //}
    }
}
