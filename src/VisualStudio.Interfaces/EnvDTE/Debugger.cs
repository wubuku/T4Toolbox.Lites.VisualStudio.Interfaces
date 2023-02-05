#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The EnvDTE.Debugger object is used to interrogate and manipulate the state
    //     of the debugger and the program being debugged.
    [Guid("338FB9A0-BAE5-11D2-8AD1-00C04F79E479")]
    //[TypeLibType(4160)]
    public interface Debugger
    {
        // Summary:
        //     Gets a collection of bound breakpoints that were last simultaneously hit.
        //
        // Returns:
        //     A EnvDTE.Breakpoints collection.
        [DispId(111)]
        Breakpoints AllBreakpointsLastHit { get; }
        //
        // Summary:
        //     Gets the last breakpoint hit.
        //
        // Returns:
        //     A EnvDTE.Breakpoint object.
        [DispId(110)]
        Breakpoint BreakpointLastHit { get; }
        //
        // Summary:
        //     Gets a collection of breakpoints.
        //
        // Returns:
        //     A EnvDTE.Breakpoints collection.
        [DispId(100)]
        Breakpoints Breakpoints { get; }
        ////
        //// Summary:
        ////     Gets the current mode of the debugger within the context of the integrated
        ////     development environment (IDE).
        ////
        //// Returns:
        ////     A EnvDTE.dbgDebugMode value.
        //[DispId(102)]
        //dbgDebugMode CurrentMode { get; }
        ////
        //// Summary:
        ////     Sets or gets the active process.
        ////
        //// Returns:
        ////     A EnvDTE.Process object.
        //[DispId(103)]
        //Process CurrentProcess { get; set; }
        //
        // Summary:
        //     Sets or gets the active program.
        //
        // Returns:
        //     The active EnvDTE.Program.
        [DispId(104)]
        Program CurrentProgram { get; set; }
        ////
        //// Summary:
        ////     Sets or gets the current stack frame.
        ////
        //// Returns:
        ////     A EnvDTE.StackFrame object.
        //[DispId(106)]
        //StackFrame CurrentStackFrame { get; set; }
        ////
        //// Summary:
        ////     Sets or gets the current thread being debugged.
        ////
        //// Returns:
        ////     A EnvDTE.Thread object.
        //[DispId(105)]
        //Thread CurrentThread { get; set; }
        ////
        //// Summary:
        ////     Gets the list of processes currently being debugged.
        ////
        //// Returns:
        ////     A EnvDTE.Processes collection.
        //[DispId(112)]
        //Processes DebuggedProcesses { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(200)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets or sets whether expressions are output in hexadecimal or decimal format.
        //
        // Returns:
        //     true if hexadecimal format, otherwise false.
        [DispId(107)]
        bool HexDisplayMode { get; set; }
        //
        // Summary:
        //     Gets or sets whether expressions are evaluated in hexadecimal or decimal
        //     format.
        //
        // Returns:
        //     true if hexadecimal format, otherwise false.
        [DispId(108)]
        bool HexInputMode { get; set; }
        ////
        //// Summary:
        ////     Gets a list of languages that the debugger supports.
        ////
        //// Returns:
        ////     A EnvDTE.Languages collection.
        //[DispId(101)]
        //Languages Languages { get; }
        ////
        //// Summary:
        ////     Gets the last reason that a program was broken. If the program is running
        ////     it returns DBG_REASON_NONE.
        ////
        //// Returns:
        ////     A EnvDTE.dbgEventReason value.
        //[DispId(109)]
        //dbgEventReason LastBreakReason { get; }
        ////
        //// Summary:
        ////     Gets the list of processes currently running on this machine.
        ////
        //// Returns:
        ////     A EnvDTE.Processes collection.
        //[DispId(113)]
        //Processes LocalProcesses { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Debugger object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(201)]
        DTE Parent { get; }

        // Summary:
        //     Causes the given process to pause its execution so that its current state
        //     can be analyzed.
        //
        // Parameters:
        //   WaitForBreakMode:
        //     Set to true to return only when the debugger has entered break mode. Set
        //     to false to break and return immediately. See Breaking Execution for more
        //     information.
        [DispId(7)]
        void Break(bool WaitForBreakMode = true);
        //
        // Summary:
        //     Detaches from all attached programs.
        [DispId(2)]
        void DetachAll();
        //
        // Summary:
        //     Executes the specified statement. If the TreatAsExpression flag is true,
        //     then the string is interpreted as an expression, and output is sent to the
        //     Command Window.
        //
        // Parameters:
        //   Statement:
        //     The statement to execute.
        //
        //   Timeout:
        //     The timeout period, in milliseconds.
        //
        //   TreatAsExpression:
        //     The treat as expression. True if the string is to be interpreted as an expression;
        //     otherwise False.
        [DispId(11)]
        void ExecuteStatement(string Statement, int Timeout = -1, bool TreatAsExpression = false);
        ////
        //// Summary:
        ////     Evaluates an expression based on the current stack frame. If the expression
        ////     can be parsed but not evaluated, an object is returned but will not contain
        ////     a valid value.
        ////
        //// Parameters:
        ////   ExpressionText:
        ////     The expression text to be evaluated.
        ////
        ////   UseAutoExpandRules:
        ////     true if the auto expand rules should be used; otherwise, false.
        ////
        ////   Timeout:
        ////     The timeout period, in milliseconds.
        ////
        //// Returns:
        ////     A EnvDTE.Expression object.
        //[DispId(1)]
        //Expression GetExpression(string ExpressionText, bool UseAutoExpandRules = false, int Timeout = -1);
        //
        // Summary:
        //     Starts executing the program from the current statement.
        //
        // Parameters:
        //   WaitForBreakOrEnd:
        //     Set to true if this function call should wait until either Break mode or
        //     Design mode is entered before returning. Set to false if you want this call
        //     to return immediately after causing the debugger to begin execution. Upon
        //     return, the debugger could be in Design, Break, or Run modes. See Execution
        //     Control for more information.
        [DispId(6)]
        void Go(bool WaitForBreakOrEnd = true);
        //
        // Summary:
        //     Executes the program to the current position of the source file cursor.
        //
        // Parameters:
        //   WaitForBreakOrEnd:
        //     Set to true if this function call should wait until either Break mode or
        //     Design mode is entered before returning. Set to false if you want this call
        //     to return immediately after causing the debugger to begin execution. Upon
        //     return the debugger could be in Design, Break, or Run modes.See Stepping
        //     for more information.
        [DispId(10)]
        void RunToCursor(bool WaitForBreakOrEnd = true);
        //
        // Summary:
        //     Sets the next instruction to be executed, according to the cursor position
        //     in the current source file.
        [DispId(9)]
        void SetNextStatement();
        //
        // Summary:
        //     Steps into the next function call, if possible.
        //
        // Parameters:
        //   WaitForBreakOrEnd:
        //     Set to true if this function call should wait until either Break mode or
        //     Design mode is entered before returning. Set to false if you want this call
        //     to return immediately after causing the debugger to begin execution. Upon
        //     return the debugger could be in Design, Break, or Run modes.
        [DispId(3)]
        void StepInto(bool WaitForBreakOrEnd = true);
        //
        // Summary:
        //     Steps out of the current function.
        //
        // Parameters:
        //   WaitForBreakOrEnd:
        //     Set to true if this function call should wait until either Break mode or
        //     Design mode is entered before returning. Set to false if you want this call
        //     to return immediately after causing the debugger to begin execution. Upon
        //     return the debugger could be in Design, Break, or Run modes.
        [DispId(5)]
        void StepOut(bool WaitForBreakOrEnd = true);
        //
        // Summary:
        //     Steps over the next function call.
        //
        // Parameters:
        //   WaitForBreakOrEnd:
        //     Set to true if this function call should wait until either Break mode or
        //     Design mode is entered before returning. Set to false if you want this call
        //     to return immediately after causing the debugger to begin execution. Upon
        //     return the debugger could be in Design, Break, or Run modes.
        [DispId(4)]
        void StepOver(bool WaitForBreakOrEnd = true);
        //
        // Summary:
        //     Stops debugging, terminating, or detaching from all attached processes.
        //
        // Parameters:
        //   WaitForDesignMode:
        //     Set to true if the debugging session should stop only when it reaches design
        //     mode. Set to false if you intend to stop debugging, but you need to perform
        //     other tasks in the macro even before the debugger enters Design mode.
        [DispId(8)]
        void Stop(bool WaitForDesignMode = true);
        //
        // Summary:
        //     Terminates all processes.
        [DispId(300)]
        void TerminateAll();
    }
}
