// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Debugger.Interop.CorDebug
{
	public static class CorDebugExtensionMethods
	{
		static void ProcessOutParameter(object parameter)
		{
		}
		
		public static void CanLaunchOrAttach(this CorDebugClass instance, uint dwProcessId, int win32DebuggingEnabled)
		{
			instance.CanLaunchOrAttach(dwProcessId, win32DebuggingEnabled);
		}
		
		public static ICorDebugProcess CreateProcess(this CorDebugClass instance, string lpApplicationName, string lpCommandLine, ref _SECURITY_ATTRIBUTES lpProcessAttributes, ref _SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, uint lpStartupInfo,
		uint lpProcessInformation, CorDebugCreateProcessFlags debuggingFlags)
		{
			ICorDebugProcess ppProcess;
			instance.CreateProcess(lpApplicationName, lpCommandLine, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation,
			debuggingFlags, out ppProcess);
			ProcessOutParameter(lpProcessAttributes);
			ProcessOutParameter(lpThreadAttributes);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcess DebugActiveProcess(this CorDebugClass instance, uint id, int win32Attach)
		{
			ICorDebugProcess ppProcess;
			instance.DebugActiveProcess(id, win32Attach, out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcessEnum EnumerateProcesses(this CorDebugClass instance)
		{
			ICorDebugProcessEnum ppProcess;
			instance.EnumerateProcesses(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcess GetProcess(this CorDebugClass instance, uint dwProcessId)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(dwProcessId, out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static void Initialize(this CorDebugClass instance)
		{
			instance.Initialize();
		}
		
		public static void SetManagedHandler(this CorDebugClass instance, ICorDebugManagedCallback pCallback)
		{
			instance.SetManagedHandler(pCallback);
		}
		
		public static void SetUnmanagedHandler(this CorDebugClass instance, ICorDebugUnmanagedCallback pCallback)
		{
			instance.SetUnmanagedHandler(pCallback);
		}
		
		public static void Terminate(this CorDebugClass instance)
		{
			instance.Terminate();
		}
		
		public static void CanLaunchOrAttach(this EmbeddedCLRCorDebugClass instance, uint dwProcessId, int win32DebuggingEnabled)
		{
			instance.CanLaunchOrAttach(dwProcessId, win32DebuggingEnabled);
		}
		
		public static ICorDebugProcess CreateProcess(this EmbeddedCLRCorDebugClass instance, string lpApplicationName, string lpCommandLine, ref _SECURITY_ATTRIBUTES lpProcessAttributes, ref _SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, uint lpStartupInfo,
		uint lpProcessInformation, CorDebugCreateProcessFlags debuggingFlags)
		{
			ICorDebugProcess ppProcess;
			instance.CreateProcess(lpApplicationName, lpCommandLine, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation,
			debuggingFlags, out ppProcess);
			ProcessOutParameter(lpProcessAttributes);
			ProcessOutParameter(lpThreadAttributes);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcess DebugActiveProcess(this EmbeddedCLRCorDebugClass instance, uint id, int win32Attach)
		{
			ICorDebugProcess ppProcess;
			instance.DebugActiveProcess(id, win32Attach, out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcessEnum EnumerateProcesses(this EmbeddedCLRCorDebugClass instance)
		{
			ICorDebugProcessEnum ppProcess;
			instance.EnumerateProcesses(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcess GetProcess(this EmbeddedCLRCorDebugClass instance, uint dwProcessId)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(dwProcessId, out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static void Initialize(this EmbeddedCLRCorDebugClass instance)
		{
			instance.Initialize();
		}
		
		public static void SetManagedHandler(this EmbeddedCLRCorDebugClass instance, ICorDebugManagedCallback pCallback)
		{
			instance.SetManagedHandler(pCallback);
		}
		
		public static void SetUnmanagedHandler(this EmbeddedCLRCorDebugClass instance, ICorDebugUnmanagedCallback pCallback)
		{
			instance.SetUnmanagedHandler(pCallback);
		}
		
		public static void Terminate(this EmbeddedCLRCorDebugClass instance)
		{
			instance.Terminate();
		}
		
		public static void Initialize(this ICorDebug instance)
		{
			instance.Initialize();
		}
		
		public static void Terminate(this ICorDebug instance)
		{
			instance.Terminate();
		}
		
		public static void SetManagedHandler(this ICorDebug instance, ICorDebugManagedCallback pCallback)
		{
			instance.SetManagedHandler(pCallback);
		}
		
		public static void SetUnmanagedHandler(this ICorDebug instance, ICorDebugUnmanagedCallback pCallback)
		{
			instance.SetUnmanagedHandler(pCallback);
		}
		
		public static ICorDebugProcess CreateProcess(this ICorDebug instance, string lpApplicationName, string lpCommandLine, ref _SECURITY_ATTRIBUTES lpProcessAttributes, ref _SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, uint lpStartupInfo,
		uint lpProcessInformation, CorDebugCreateProcessFlags debuggingFlags)
		{
			ICorDebugProcess ppProcess;
			instance.CreateProcess(lpApplicationName, lpCommandLine, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation,
			debuggingFlags, out ppProcess);
			ProcessOutParameter(lpProcessAttributes);
			ProcessOutParameter(lpThreadAttributes);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcess DebugActiveProcess(this ICorDebug instance, uint id, int win32Attach)
		{
			ICorDebugProcess ppProcess;
			instance.DebugActiveProcess(id, win32Attach, out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcessEnum EnumerateProcesses(this ICorDebug instance)
		{
			ICorDebugProcessEnum ppProcess;
			instance.EnumerateProcesses(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugProcess GetProcess(this ICorDebug instance, uint dwProcessId)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(dwProcessId, out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static void CanLaunchOrAttach(this ICorDebug instance, uint dwProcessId, int win32DebuggingEnabled)
		{
			instance.CanLaunchOrAttach(dwProcessId, win32DebuggingEnabled);
		}
		
		public static void Stop(this ICorDebugAppDomain instance, uint dwTimeoutIgnored)
		{
			instance.Stop(dwTimeoutIgnored);
		}
		
		public static void Continue(this ICorDebugAppDomain instance, int fIsOutOfBand)
		{
			instance.Continue(fIsOutOfBand);
		}
		
		public static int IsRunning(this ICorDebugAppDomain instance)
		{
			int pbRunning;
			instance.IsRunning(out pbRunning);
			return pbRunning;
		}
		
		public static int HasQueuedCallbacks(this ICorDebugAppDomain instance, ICorDebugThread pThread)
		{
			int pbQueued;
			instance.HasQueuedCallbacks(pThread, out pbQueued);
			return pbQueued;
		}
		
		public static ICorDebugThreadEnum EnumerateThreads(this ICorDebugAppDomain instance)
		{
			ICorDebugThreadEnum ppThreads;
			instance.EnumerateThreads(out ppThreads);
			ProcessOutParameter(ppThreads);
			return ppThreads;
		}
		
		public static void SetAllThreadsDebugState(this ICorDebugAppDomain instance, CorDebugThreadState state, ICorDebugThread pExceptThisThread)
		{
			instance.SetAllThreadsDebugState(state, pExceptThisThread);
		}
		
		public static void Detach(this ICorDebugAppDomain instance)
		{
			instance.Detach();
		}
		
		public static void Terminate(this ICorDebugAppDomain instance, uint exitCode)
		{
			instance.Terminate(exitCode);
		}
		
		public static ICorDebugErrorInfoEnum CanCommitChanges(this ICorDebugAppDomain instance, uint cSnapshots, ref ICorDebugEditAndContinueSnapshot pSnapshots)
		{
			ICorDebugErrorInfoEnum pError;
			instance.CanCommitChanges(cSnapshots, ref pSnapshots, out pError);
			ProcessOutParameter(pSnapshots);
			ProcessOutParameter(pError);
			return pError;
		}
		
		public static ICorDebugErrorInfoEnum CommitChanges(this ICorDebugAppDomain instance, uint cSnapshots, ref ICorDebugEditAndContinueSnapshot pSnapshots)
		{
			ICorDebugErrorInfoEnum pError;
			instance.CommitChanges(cSnapshots, ref pSnapshots, out pError);
			ProcessOutParameter(pSnapshots);
			ProcessOutParameter(pError);
			return pError;
		}
		
		public static ICorDebugProcess GetProcess(this ICorDebugAppDomain instance)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugAssemblyEnum EnumerateAssemblies(this ICorDebugAppDomain instance)
		{
			ICorDebugAssemblyEnum ppAssemblies;
			instance.EnumerateAssemblies(out ppAssemblies);
			ProcessOutParameter(ppAssemblies);
			return ppAssemblies;
		}
		
		public static ICorDebugModule GetModuleFromMetaDataInterface(this ICorDebugAppDomain instance, object pIMetaData)
		{
			ICorDebugModule ppModule;
			instance.GetModuleFromMetaDataInterface(pIMetaData, out ppModule);
			ProcessOutParameter(ppModule);
			return ppModule;
		}
		
		public static ICorDebugBreakpointEnum EnumerateBreakpoints(this ICorDebugAppDomain instance)
		{
			ICorDebugBreakpointEnum ppBreakpoints;
			instance.EnumerateBreakpoints(out ppBreakpoints);
			ProcessOutParameter(ppBreakpoints);
			return ppBreakpoints;
		}
		
		public static ICorDebugStepperEnum EnumerateSteppers(this ICorDebugAppDomain instance)
		{
			ICorDebugStepperEnum ppSteppers;
			instance.EnumerateSteppers(out ppSteppers);
			ProcessOutParameter(ppSteppers);
			return ppSteppers;
		}
		
		public static int IsAttached(this ICorDebugAppDomain instance)
		{
			int pbAttached;
			instance.IsAttached(out pbAttached);
			return pbAttached;
		}
		
		public static void GetName(this ICorDebugAppDomain instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetName(cchName, out pcchName, szName);
		}
		
		public static ICorDebugValue GetObject(this ICorDebugAppDomain instance)
		{
			ICorDebugValue ppObject;
			instance.GetObject(out ppObject);
			ProcessOutParameter(ppObject);
			return ppObject;
		}
		
		public static void Attach(this ICorDebugAppDomain instance)
		{
			instance.Attach();
		}
		
		public static uint GetID(this ICorDebugAppDomain instance)
		{
			uint pId;
			instance.GetID(out pId);
			return pId;
		}
		
		public static ICorDebugType GetArrayOrPointerType(this ICorDebugAppDomain2 instance, uint elementType, uint nRank, ICorDebugType pTypeArg)
		{
			ICorDebugType ppType;
			instance.GetArrayOrPointerType(elementType, nRank, pTypeArg, out ppType);
			ProcessOutParameter(ppType);
			return ppType;
		}
		
		public static ICorDebugType GetFunctionPointerType(this ICorDebugAppDomain2 instance, uint nTypeArgs, ref ICorDebugType ppTypeArgs)
		{
			ICorDebugType ppType;
			instance.GetFunctionPointerType(nTypeArgs, ref ppTypeArgs, out ppType);
			ProcessOutParameter(ppTypeArgs);
			ProcessOutParameter(ppType);
			return ppType;
		}
		
		public static void Skip(this ICorDebugAppDomainEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugAppDomainEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugAppDomainEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugAppDomainEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugAppDomainEnum instance, uint celt, IntPtr values)
		{
			uint pceltFetched;
			instance.Next(celt, values, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugArrayValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugArrayValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugArrayValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugArrayValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static int IsValid(this ICorDebugArrayValue instance)
		{
			int pbValid;
			instance.IsValid(out pbValid);
			return pbValid;
		}
		
		public static ICorDebugValueBreakpoint CreateRelocBreakpoint(this ICorDebugArrayValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateRelocBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static uint GetElementType(this ICorDebugArrayValue instance)
		{
			uint pType;
			instance.GetElementType(out pType);
			return pType;
		}
		
		public static uint GetRank(this ICorDebugArrayValue instance)
		{
			uint pnRank;
			instance.GetRank(out pnRank);
			return pnRank;
		}
		
		public static uint GetCount(this ICorDebugArrayValue instance)
		{
			uint pnCount;
			instance.GetCount(out pnCount);
			return pnCount;
		}
		
		public static void GetDimensions(this ICorDebugArrayValue instance, uint cdim, IntPtr dims)
		{
			instance.GetDimensions(cdim, dims);
		}
		
		public static int HasBaseIndicies(this ICorDebugArrayValue instance)
		{
			int pbHasBaseIndicies;
			instance.HasBaseIndicies(out pbHasBaseIndicies);
			return pbHasBaseIndicies;
		}
		
		public static void GetBaseIndicies(this ICorDebugArrayValue instance, uint cdim, IntPtr indicies)
		{
			instance.GetBaseIndicies(cdim, indicies);
		}
		
		public static ICorDebugValue GetElement(this ICorDebugArrayValue instance, uint cdim, IntPtr indices)
		{
			ICorDebugValue ppValue;
			instance.GetElement(cdim, indices, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue GetElementAtPosition(this ICorDebugArrayValue instance, uint nPosition)
		{
			ICorDebugValue ppValue;
			instance.GetElementAtPosition(nPosition, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugProcess GetProcess(this ICorDebugAssembly instance)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ICorDebugAppDomain GetAppDomain(this ICorDebugAssembly instance)
		{
			ICorDebugAppDomain ppAppDomain;
			instance.GetAppDomain(out ppAppDomain);
			ProcessOutParameter(ppAppDomain);
			return ppAppDomain;
		}
		
		public static ICorDebugModuleEnum EnumerateModules(this ICorDebugAssembly instance)
		{
			ICorDebugModuleEnum ppModules;
			instance.EnumerateModules(out ppModules);
			ProcessOutParameter(ppModules);
			return ppModules;
		}
		
		public static void GetCodeBase(this ICorDebugAssembly instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetCodeBase(cchName, out pcchName, szName);
		}
		
		public static void GetName(this ICorDebugAssembly instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetName(cchName, out pcchName, szName);
		}
		
		public static int IsFullyTrusted(this ICorDebugAssembly2 instance)
		{
			int pbFullyTrusted;
			instance.IsFullyTrusted(out pbFullyTrusted);
			return pbFullyTrusted;
		}
		
		public static void Skip(this ICorDebugAssemblyEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugAssemblyEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugAssemblyEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugAssemblyEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugAssemblyEnum instance, uint celt, IntPtr values)
		{
			uint pceltFetched;
			instance.Next(celt, values, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugBoxValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugBoxValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugBoxValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugBoxValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static int IsValid(this ICorDebugBoxValue instance)
		{
			int pbValid;
			instance.IsValid(out pbValid);
			return pbValid;
		}
		
		public static ICorDebugValueBreakpoint CreateRelocBreakpoint(this ICorDebugBoxValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateRelocBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static ICorDebugObjectValue GetObject(this ICorDebugBoxValue instance)
		{
			ICorDebugObjectValue ppObject;
			instance.GetObject(out ppObject);
			ProcessOutParameter(ppObject);
			return ppObject;
		}
		
		public static void Activate(this ICorDebugBreakpoint instance, int bActive)
		{
			instance.Activate(bActive);
		}
		
		public static int IsActive(this ICorDebugBreakpoint instance)
		{
			int pbActive;
			instance.IsActive(out pbActive);
			return pbActive;
		}
		
		public static void Skip(this ICorDebugBreakpointEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugBreakpointEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugBreakpointEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugBreakpointEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugBreakpointEnum instance, uint celt, IntPtr breakpoints)
		{
			uint pceltFetched;
			instance.Next(celt, breakpoints, out pceltFetched);
			return pceltFetched;
		}
		
		public static ICorDebugThread GetThread(this ICorDebugChain instance)
		{
			ICorDebugThread ppThread;
			instance.GetThread(out ppThread);
			ProcessOutParameter(ppThread);
			return ppThread;
		}
		
		public static void GetStackRange(this ICorDebugChain instance, out ulong pStart, out ulong pEnd)
		{
			instance.GetStackRange(out pStart, out pEnd);
		}
		
		public static ICorDebugContext GetContext(this ICorDebugChain instance)
		{
			ICorDebugContext ppContext;
			instance.GetContext(out ppContext);
			ProcessOutParameter(ppContext);
			return ppContext;
		}
		
		public static ICorDebugChain GetCaller(this ICorDebugChain instance)
		{
			ICorDebugChain ppChain;
			instance.GetCaller(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugChain GetCallee(this ICorDebugChain instance)
		{
			ICorDebugChain ppChain;
			instance.GetCallee(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugChain GetPrevious(this ICorDebugChain instance)
		{
			ICorDebugChain ppChain;
			instance.GetPrevious(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugChain GetNext(this ICorDebugChain instance)
		{
			ICorDebugChain ppChain;
			instance.GetNext(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static int IsManaged(this ICorDebugChain instance)
		{
			int pManaged;
			instance.IsManaged(out pManaged);
			return pManaged;
		}
		
		public static ICorDebugFrameEnum EnumerateFrames(this ICorDebugChain instance)
		{
			ICorDebugFrameEnum ppFrames;
			instance.EnumerateFrames(out ppFrames);
			ProcessOutParameter(ppFrames);
			return ppFrames;
		}
		
		public static ICorDebugFrame GetActiveFrame(this ICorDebugChain instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetActiveFrame(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugRegisterSet GetRegisterSet(this ICorDebugChain instance)
		{
			ICorDebugRegisterSet ppRegisters;
			instance.GetRegisterSet(out ppRegisters);
			ProcessOutParameter(ppRegisters);
			return ppRegisters;
		}
		
		public static CorDebugChainReason GetReason(this ICorDebugChain instance)
		{
			CorDebugChainReason pReason;
			instance.GetReason(out pReason);
			ProcessOutParameter(pReason);
			return pReason;
		}
		
		public static void Skip(this ICorDebugChainEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugChainEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugChainEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugChainEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugChainEnum instance, uint celt, ICorDebugChain[] chains)
		{
			uint pceltFetched;
			instance.Next(celt, chains, out pceltFetched);
			ProcessOutParameter(chains);
			return pceltFetched;
		}
		
		public static ICorDebugModule GetModule(this ICorDebugClass instance)
		{
			ICorDebugModule pModule;
			instance.GetModule(out pModule);
			ProcessOutParameter(pModule);
			return pModule;
		}
		
		public static uint GetToken(this ICorDebugClass instance)
		{
			uint pTypeDef;
			instance.GetToken(out pTypeDef);
			return pTypeDef;
		}
		
		public static ICorDebugValue GetStaticFieldValue(this ICorDebugClass instance, uint fieldDef, ICorDebugFrame pFrame)
		{
			ICorDebugValue ppValue;
			instance.GetStaticFieldValue(fieldDef, pFrame, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugType GetParameterizedType(this ICorDebugClass2 instance, uint elementType, uint nTypeArgs, ICorDebugType[] ppTypeArgs)
		{
			ICorDebugType ppType;
			instance.GetParameterizedType(elementType, nTypeArgs, ppTypeArgs, out ppType);
			ProcessOutParameter(ppTypeArgs);
			ProcessOutParameter(ppType);
			return ppType;
		}
		
		public static void SetJMCStatus(this ICorDebugClass2 instance, int bIsJustMyCode)
		{
			instance.SetJMCStatus(bIsJustMyCode);
		}
		
		public static int IsIL(this ICorDebugCode instance)
		{
			int pbIL;
			instance.IsIL(out pbIL);
			return pbIL;
		}
		
		public static ICorDebugFunction GetFunction(this ICorDebugCode instance)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunction(out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static ulong GetAddress(this ICorDebugCode instance)
		{
			ulong pStart;
			instance.GetAddress(out pStart);
			return pStart;
		}
		
		public static uint GetSize(this ICorDebugCode instance)
		{
			uint pcBytes;
			instance.GetSize(out pcBytes);
			return pcBytes;
		}
		
		public static ICorDebugFunctionBreakpoint CreateBreakpoint(this ICorDebugCode instance, uint offset)
		{
			ICorDebugFunctionBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(offset, out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static uint GetCode(this ICorDebugCode instance, uint startOffset, uint endOffset, uint cBufferAlloc, IntPtr buffer)
		{
			uint pcBufferSize;
			instance.GetCode(startOffset, endOffset, cBufferAlloc, buffer, out pcBufferSize);
			return pcBufferSize;
		}
		
		public static uint GetVersionNumber(this ICorDebugCode instance)
		{
			uint nVersion;
			instance.GetVersionNumber(out nVersion);
			return nVersion;
		}
		
		public static void GetILToNativeMapping(this ICorDebugCode instance, uint cMap, out uint pcMap, IntPtr map)
		{
			instance.GetILToNativeMapping(cMap, out pcMap, map);
		}
		
		public static void GetEnCRemapSequencePoints(this ICorDebugCode instance, uint cMap, out uint pcMap, IntPtr offsets)
		{
			instance.GetEnCRemapSequencePoints(cMap, out pcMap, offsets);
		}
		
		public static void Skip(this ICorDebugCodeEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugCodeEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugCodeEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugCodeEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugCodeEnum instance, uint celt, IntPtr values)
		{
			uint pceltFetched;
			instance.Next(celt, values, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugContext instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugContext instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugContext instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugContext instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static ICorDebugClass GetClass(this ICorDebugContext instance)
		{
			ICorDebugClass ppClass;
			instance.GetClass(out ppClass);
			ProcessOutParameter(ppClass);
			return ppClass;
		}
		
		public static ICorDebugValue GetFieldValue(this ICorDebugContext instance, ICorDebugClass pClass, uint fieldDef)
		{
			ICorDebugValue ppValue;
			instance.GetFieldValue(pClass, fieldDef, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugFunction GetVirtualMethod(this ICorDebugContext instance, uint memberRef)
		{
			ICorDebugFunction ppFunction;
			instance.GetVirtualMethod(memberRef, out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static ICorDebugContext GetContext(this ICorDebugContext instance)
		{
			ICorDebugContext ppContext;
			instance.GetContext(out ppContext);
			ProcessOutParameter(ppContext);
			return ppContext;
		}
		
		public static int IsValueClass(this ICorDebugContext instance)
		{
			int pbIsValueClass;
			instance.IsValueClass(out pbIsValueClass);
			return pbIsValueClass;
		}
		
		public static object GetManagedCopy(this ICorDebugContext instance)
		{
			object ppObject;
			instance.GetManagedCopy(out ppObject);
			ProcessOutParameter(ppObject);
			return ppObject;
		}
		
		public static void SetFromManagedCopy(this ICorDebugContext instance, object pObject)
		{
			instance.SetFromManagedCopy(pObject);
		}
		
		public static void Stop(this ICorDebugController instance, uint dwTimeoutIgnored)
		{
			instance.Stop(dwTimeoutIgnored);
		}
		
		public static void Continue(this ICorDebugController instance, int fIsOutOfBand)
		{
			instance.Continue(fIsOutOfBand);
		}
		
		public static int IsRunning(this ICorDebugController instance)
		{
			int pbRunning;
			instance.IsRunning(out pbRunning);
			return pbRunning;
		}
		
		public static int HasQueuedCallbacks(this ICorDebugController instance, ICorDebugThread pThread)
		{
			int pbQueued;
			instance.HasQueuedCallbacks(pThread, out pbQueued);
			return pbQueued;
		}
		
		public static ICorDebugThreadEnum EnumerateThreads(this ICorDebugController instance)
		{
			ICorDebugThreadEnum ppThreads;
			instance.EnumerateThreads(out ppThreads);
			ProcessOutParameter(ppThreads);
			return ppThreads;
		}
		
		public static void SetAllThreadsDebugState(this ICorDebugController instance, CorDebugThreadState state, ICorDebugThread pExceptThisThread)
		{
			instance.SetAllThreadsDebugState(state, pExceptThisThread);
		}
		
		public static void Detach(this ICorDebugController instance)
		{
			instance.Detach();
		}
		
		public static void Terminate(this ICorDebugController instance, uint exitCode)
		{
			instance.Terminate(exitCode);
		}
		
		public static ICorDebugErrorInfoEnum CanCommitChanges(this ICorDebugController instance, uint cSnapshots, ref ICorDebugEditAndContinueSnapshot pSnapshots)
		{
			ICorDebugErrorInfoEnum pError;
			instance.CanCommitChanges(cSnapshots, ref pSnapshots, out pError);
			ProcessOutParameter(pSnapshots);
			ProcessOutParameter(pError);
			return pError;
		}
		
		public static ICorDebugErrorInfoEnum CommitChanges(this ICorDebugController instance, uint cSnapshots, ref ICorDebugEditAndContinueSnapshot pSnapshots)
		{
			ICorDebugErrorInfoEnum pError;
			instance.CommitChanges(cSnapshots, ref pSnapshots, out pError);
			ProcessOutParameter(pSnapshots);
			ProcessOutParameter(pError);
			return pError;
		}
		
		public static Guid CopyMetaData(this ICorDebugEditAndContinueSnapshot instance, IStream pIStream)
		{
			Guid pMvid;
			instance.CopyMetaData(pIStream, out pMvid);
			return pMvid;
		}
		
		public static Guid GetMvid(this ICorDebugEditAndContinueSnapshot instance)
		{
			Guid pMvid;
			instance.GetMvid(out pMvid);
			return pMvid;
		}
		
		public static uint GetRoDataRVA(this ICorDebugEditAndContinueSnapshot instance)
		{
			uint pRoDataRVA;
			instance.GetRoDataRVA(out pRoDataRVA);
			return pRoDataRVA;
		}
		
		public static uint GetRwDataRVA(this ICorDebugEditAndContinueSnapshot instance)
		{
			uint pRwDataRVA;
			instance.GetRwDataRVA(out pRwDataRVA);
			return pRwDataRVA;
		}
		
		public static void SetPEBytes(this ICorDebugEditAndContinueSnapshot instance, IStream pIStream)
		{
			instance.SetPEBytes(pIStream);
		}
		
		public static void SetILMap(this ICorDebugEditAndContinueSnapshot instance, uint mdFunction, uint cMapSize, ref _COR_IL_MAP map)
		{
			instance.SetILMap(mdFunction, cMapSize, ref map);
			ProcessOutParameter(map);
		}
		
		public static void SetPESymbolBytes(this ICorDebugEditAndContinueSnapshot instance, IStream pIStream)
		{
			instance.SetPESymbolBytes(pIStream);
		}
		
		public static void Skip(this ICorDebugEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static void Skip(this ICorDebugErrorInfoEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugErrorInfoEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugErrorInfoEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugErrorInfoEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugErrorInfoEnum instance, uint celt, IntPtr errors)
		{
			uint pceltFetched;
			instance.Next(celt, errors, out pceltFetched);
			return pceltFetched;
		}
		
		public static void CallFunction(this ICorDebugEval instance, ICorDebugFunction pFunction, uint nArgs, ICorDebugValue[] ppArgs)
		{
			instance.CallFunction(pFunction, nArgs, ppArgs);
			ProcessOutParameter(ppArgs);
		}
		
		public static void NewObject(this ICorDebugEval instance, ICorDebugFunction pConstructor, uint nArgs, ref ICorDebugValue ppArgs)
		{
			instance.NewObject(pConstructor, nArgs, ref ppArgs);
			ProcessOutParameter(ppArgs);
		}
		
		public static void NewObjectNoConstructor(this ICorDebugEval instance, ICorDebugClass pClass)
		{
			instance.NewObjectNoConstructor(pClass);
		}
		
		public static void NewString(this ICorDebugEval instance, string @string)
		{
			instance.NewString(@string);
		}
		
		public static void NewArray(this ICorDebugEval instance, uint elementType, ICorDebugClass pElementClass, uint rank, ref uint dims, ref uint lowBounds)
		{
			instance.NewArray(elementType, pElementClass, rank, ref dims, ref lowBounds);
		}
		
		public static int IsActive(this ICorDebugEval instance)
		{
			int pbActive;
			instance.IsActive(out pbActive);
			return pbActive;
		}
		
		public static void Abort(this ICorDebugEval instance)
		{
			instance.Abort();
		}
		
		public static ICorDebugValue GetResult(this ICorDebugEval instance)
		{
			ICorDebugValue ppResult;
			instance.GetResult(out ppResult);
			ProcessOutParameter(ppResult);
			return ppResult;
		}
		
		public static ICorDebugThread GetThread(this ICorDebugEval instance)
		{
			ICorDebugThread ppThread;
			instance.GetThread(out ppThread);
			ProcessOutParameter(ppThread);
			return ppThread;
		}
		
		public static ICorDebugValue CreateValue(this ICorDebugEval instance, uint elementType, ICorDebugClass pElementClass)
		{
			ICorDebugValue ppValue;
			instance.CreateValue(elementType, pElementClass, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static void CallParameterizedFunction(this ICorDebugEval2 instance, ICorDebugFunction pFunction, uint nTypeArgs, ICorDebugType[] ppTypeArgs, uint nArgs, ICorDebugValue[] ppArgs)
		{
			instance.CallParameterizedFunction(pFunction, nTypeArgs, ppTypeArgs, nArgs, ppArgs);
			ProcessOutParameter(ppTypeArgs);
			ProcessOutParameter(ppArgs);
		}
		
		public static ICorDebugValue CreateValueForType(this ICorDebugEval2 instance, ICorDebugType pType)
		{
			ICorDebugValue ppValue;
			instance.CreateValueForType(pType, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static void NewParameterizedObject(this ICorDebugEval2 instance, ICorDebugFunction pConstructor, uint nTypeArgs, ICorDebugType[] ppTypeArgs, uint nArgs, ICorDebugValue[] ppArgs)
		{
			instance.NewParameterizedObject(pConstructor, nTypeArgs, ppTypeArgs, nArgs, ppArgs);
			ProcessOutParameter(ppTypeArgs);
			ProcessOutParameter(ppArgs);
		}
		
		public static void NewParameterizedObjectNoConstructor(this ICorDebugEval2 instance, ICorDebugClass pClass, uint nTypeArgs, ICorDebugType[] ppTypeArgs)
		{
			instance.NewParameterizedObjectNoConstructor(pClass, nTypeArgs, ppTypeArgs);
			ProcessOutParameter(ppTypeArgs);
		}
		
		public static void NewParameterizedArray(this ICorDebugEval2 instance, ICorDebugType pElementType, uint rank, ref uint dims, ref uint lowBounds)
		{
			instance.NewParameterizedArray(pElementType, rank, ref dims, ref lowBounds);
		}
		
		public static void NewStringWithLength(this ICorDebugEval2 instance, string @string, uint uiLength)
		{
			instance.NewStringWithLength(@string, uiLength);
		}
		
		public static void RudeAbort(this ICorDebugEval2 instance)
		{
			instance.RudeAbort();
		}
		
		public static ICorDebugChain GetChain(this ICorDebugFrame instance)
		{
			ICorDebugChain ppChain;
			instance.GetChain(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugCode GetCode(this ICorDebugFrame instance)
		{
			ICorDebugCode ppCode;
			instance.GetCode(out ppCode);
			ProcessOutParameter(ppCode);
			return ppCode;
		}
		
		public static ICorDebugFunction GetFunction(this ICorDebugFrame instance)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunction(out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static uint GetFunctionToken(this ICorDebugFrame instance)
		{
			uint pToken;
			instance.GetFunctionToken(out pToken);
			return pToken;
		}
		
		public static void GetStackRange(this ICorDebugFrame instance, out ulong pStart, out ulong pEnd)
		{
			instance.GetStackRange(out pStart, out pEnd);
		}
		
		public static ICorDebugFrame GetCaller(this ICorDebugFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCaller(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugFrame GetCallee(this ICorDebugFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCallee(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugStepper CreateStepper(this ICorDebugFrame instance)
		{
			ICorDebugStepper ppStepper;
			instance.CreateStepper(out ppStepper);
			ProcessOutParameter(ppStepper);
			return ppStepper;
		}
		
		public static void Skip(this ICorDebugFrameEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugFrameEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugFrameEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugFrameEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugFrameEnum instance, uint celt, ICorDebugFrame[] frames)
		{
			uint pceltFetched;
			instance.Next(celt, frames, out pceltFetched);
			ProcessOutParameter(frames);
			return pceltFetched;
		}
		
		public static ICorDebugModule GetModule(this ICorDebugFunction instance)
		{
			ICorDebugModule ppModule;
			instance.GetModule(out ppModule);
			ProcessOutParameter(ppModule);
			return ppModule;
		}
		
		public static ICorDebugClass GetClass(this ICorDebugFunction instance)
		{
			ICorDebugClass ppClass;
			instance.GetClass(out ppClass);
			ProcessOutParameter(ppClass);
			return ppClass;
		}
		
		public static uint GetToken(this ICorDebugFunction instance)
		{
			uint pMethodDef;
			instance.GetToken(out pMethodDef);
			return pMethodDef;
		}
		
		public static ICorDebugCode GetILCode(this ICorDebugFunction instance)
		{
			ICorDebugCode ppCode;
			instance.GetILCode(out ppCode);
			ProcessOutParameter(ppCode);
			return ppCode;
		}
		
		public static ICorDebugCode GetNativeCode(this ICorDebugFunction instance)
		{
			ICorDebugCode ppCode;
			instance.GetNativeCode(out ppCode);
			ProcessOutParameter(ppCode);
			return ppCode;
		}
		
		public static ICorDebugFunctionBreakpoint CreateBreakpoint(this ICorDebugFunction instance)
		{
			ICorDebugFunctionBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static uint GetLocalVarSigToken(this ICorDebugFunction instance)
		{
			uint pmdSig;
			instance.GetLocalVarSigToken(out pmdSig);
			return pmdSig;
		}
		
		public static uint GetCurrentVersionNumber(this ICorDebugFunction instance)
		{
			uint pnCurrentVersion;
			instance.GetCurrentVersionNumber(out pnCurrentVersion);
			return pnCurrentVersion;
		}
		
		public static void SetJMCStatus(this ICorDebugFunction2 instance, int bIsJustMyCode)
		{
			instance.SetJMCStatus(bIsJustMyCode);
		}
		
		public static int GetJMCStatus(this ICorDebugFunction2 instance)
		{
			int pbIsJustMyCode;
			instance.GetJMCStatus(out pbIsJustMyCode);
			return pbIsJustMyCode;
		}
		
		public static ICorDebugCodeEnum EnumerateNativeCode(this ICorDebugFunction2 instance)
		{
			ICorDebugCodeEnum ppCodeEnum;
			instance.EnumerateNativeCode(out ppCodeEnum);
			ProcessOutParameter(ppCodeEnum);
			return ppCodeEnum;
		}
		
		public static uint GetVersionNumber(this ICorDebugFunction2 instance)
		{
			uint pnVersion;
			instance.GetVersionNumber(out pnVersion);
			return pnVersion;
		}
		
		public static void Activate(this ICorDebugFunctionBreakpoint instance, int bActive)
		{
			instance.Activate(bActive);
		}
		
		public static int IsActive(this ICorDebugFunctionBreakpoint instance)
		{
			int pbActive;
			instance.IsActive(out pbActive);
			return pbActive;
		}
		
		public static ICorDebugFunction GetFunction(this ICorDebugFunctionBreakpoint instance)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunction(out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static uint GetOffset(this ICorDebugFunctionBreakpoint instance)
		{
			uint pnOffset;
			instance.GetOffset(out pnOffset);
			return pnOffset;
		}
		
		public static uint GetType(this ICorDebugGenericValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugGenericValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugGenericValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugGenericValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static void GetValue(this ICorDebugGenericValue instance, IntPtr pTo)
		{
			instance.GetValue(pTo);
		}
		
		public static void SetValue(this ICorDebugGenericValue instance, IntPtr pFrom)
		{
			instance.SetValue(pFrom);
		}
		
		public static uint GetType(this ICorDebugHandleValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugHandleValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugHandleValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugHandleValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static int IsNull(this ICorDebugHandleValue instance)
		{
			int pbNull;
			instance.IsNull(out pbNull);
			return pbNull;
		}
		
		public static ulong GetValue(this ICorDebugHandleValue instance)
		{
			ulong pValue;
			instance.GetValue(out pValue);
			return pValue;
		}
		
		public static void SetValue(this ICorDebugHandleValue instance, ulong value)
		{
			instance.SetValue(value);
		}
		
		public static ICorDebugValue Dereference(this ICorDebugHandleValue instance)
		{
			ICorDebugValue ppValue;
			instance.Dereference(out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue DereferenceStrong(this ICorDebugHandleValue instance)
		{
			ICorDebugValue ppValue;
			instance.DereferenceStrong(out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static CorDebugHandleType GetHandleType(this ICorDebugHandleValue instance)
		{
			CorDebugHandleType pType;
			instance.GetHandleType(out pType);
			ProcessOutParameter(pType);
			return pType;
		}
		
		public static void Dispose(this ICorDebugHandleValue instance)
		{
			instance.Dispose();
		}
		
		public static uint GetType(this ICorDebugHeapValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugHeapValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugHeapValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugHeapValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static int IsValid(this ICorDebugHeapValue instance)
		{
			int pbValid;
			instance.IsValid(out pbValid);
			return pbValid;
		}
		
		public static ICorDebugValueBreakpoint CreateRelocBreakpoint(this ICorDebugHeapValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateRelocBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static ICorDebugHandleValue CreateHandle(this ICorDebugHeapValue2 instance, CorDebugHandleType type)
		{
			ICorDebugHandleValue ppHandle;
			instance.CreateHandle(type, out ppHandle);
			ProcessOutParameter(ppHandle);
			return ppHandle;
		}
		
		public static ICorDebugChain GetChain(this ICorDebugILFrame instance)
		{
			ICorDebugChain ppChain;
			instance.GetChain(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugCode GetCode(this ICorDebugILFrame instance)
		{
			ICorDebugCode ppCode;
			instance.GetCode(out ppCode);
			ProcessOutParameter(ppCode);
			return ppCode;
		}
		
		public static ICorDebugFunction GetFunction(this ICorDebugILFrame instance)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunction(out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static uint GetFunctionToken(this ICorDebugILFrame instance)
		{
			uint pToken;
			instance.GetFunctionToken(out pToken);
			return pToken;
		}
		
		public static void GetStackRange(this ICorDebugILFrame instance, out ulong pStart, out ulong pEnd)
		{
			instance.GetStackRange(out pStart, out pEnd);
		}
		
		public static ICorDebugFrame GetCaller(this ICorDebugILFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCaller(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugFrame GetCallee(this ICorDebugILFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCallee(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugStepper CreateStepper(this ICorDebugILFrame instance)
		{
			ICorDebugStepper ppStepper;
			instance.CreateStepper(out ppStepper);
			ProcessOutParameter(ppStepper);
			return ppStepper;
		}
		
		public static void GetIP(this ICorDebugILFrame instance, out uint pnOffset, out CorDebugMappingResult pMappingResult)
		{
			instance.GetIP(out pnOffset, out pMappingResult);
			ProcessOutParameter(pMappingResult);
		}
		
		public static void SetIP(this ICorDebugILFrame instance, uint nOffset)
		{
			instance.SetIP(nOffset);
		}
		
		public static ICorDebugValueEnum EnumerateLocalVariables(this ICorDebugILFrame instance)
		{
			ICorDebugValueEnum ppValueEnum;
			instance.EnumerateLocalVariables(out ppValueEnum);
			ProcessOutParameter(ppValueEnum);
			return ppValueEnum;
		}
		
		public static ICorDebugValue GetLocalVariable(this ICorDebugILFrame instance, uint dwIndex)
		{
			ICorDebugValue ppValue;
			instance.GetLocalVariable(dwIndex, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValueEnum EnumerateArguments(this ICorDebugILFrame instance)
		{
			ICorDebugValueEnum ppValueEnum;
			instance.EnumerateArguments(out ppValueEnum);
			ProcessOutParameter(ppValueEnum);
			return ppValueEnum;
		}
		
		public static ICorDebugValue GetArgument(this ICorDebugILFrame instance, uint dwIndex)
		{
			ICorDebugValue ppValue;
			instance.GetArgument(dwIndex, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static uint GetStackDepth(this ICorDebugILFrame instance)
		{
			uint pDepth;
			instance.GetStackDepth(out pDepth);
			return pDepth;
		}
		
		public static ICorDebugValue GetStackValue(this ICorDebugILFrame instance, uint dwIndex)
		{
			ICorDebugValue ppValue;
			instance.GetStackValue(dwIndex, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static void CanSetIP(this ICorDebugILFrame instance, uint nOffset)
		{
			instance.CanSetIP(nOffset);
		}
		
		public static void RemapFunction(this ICorDebugILFrame2 instance, uint newILOffset)
		{
			instance.RemapFunction(newILOffset);
		}
		
		public static ICorDebugTypeEnum EnumerateTypeParameters(this ICorDebugILFrame2 instance)
		{
			ICorDebugTypeEnum ppTyParEnum;
			instance.EnumerateTypeParameters(out ppTyParEnum);
			ProcessOutParameter(ppTyParEnum);
			return ppTyParEnum;
		}
		
		public static ICorDebugChain GetChain(this ICorDebugInternalFrame instance)
		{
			ICorDebugChain ppChain;
			instance.GetChain(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugCode GetCode(this ICorDebugInternalFrame instance)
		{
			ICorDebugCode ppCode;
			instance.GetCode(out ppCode);
			ProcessOutParameter(ppCode);
			return ppCode;
		}
		
		public static ICorDebugFunction GetFunction(this ICorDebugInternalFrame instance)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunction(out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static uint GetFunctionToken(this ICorDebugInternalFrame instance)
		{
			uint pToken;
			instance.GetFunctionToken(out pToken);
			return pToken;
		}
		
		public static void GetStackRange(this ICorDebugInternalFrame instance, out ulong pStart, out ulong pEnd)
		{
			instance.GetStackRange(out pStart, out pEnd);
		}
		
		public static ICorDebugFrame GetCaller(this ICorDebugInternalFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCaller(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugFrame GetCallee(this ICorDebugInternalFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCallee(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugStepper CreateStepper(this ICorDebugInternalFrame instance)
		{
			ICorDebugStepper ppStepper;
			instance.CreateStepper(out ppStepper);
			ProcessOutParameter(ppStepper);
			return ppStepper;
		}
		
		public static CorDebugInternalFrameType GetFrameType(this ICorDebugInternalFrame instance)
		{
			CorDebugInternalFrameType pType;
			instance.GetFrameType(out pType);
			ProcessOutParameter(pType);
			return pType;
		}
		
		public static void GetName(this ICorDebugMDA instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetName(cchName, out pcchName, szName);
		}
		
		public static void GetDescription(this ICorDebugMDA instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetDescription(cchName, out pcchName, szName);
		}
		
		public static void GetXML(this ICorDebugMDA instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetXML(cchName, out pcchName, szName);
		}
		
		public static void GetFlags(this ICorDebugMDA instance, ref CorDebugMDAFlags pFlags)
		{
			instance.GetFlags(ref pFlags);
			ProcessOutParameter(pFlags);
		}
		
		public static uint GetOSThreadId(this ICorDebugMDA instance)
		{
			uint pOsTid;
			instance.GetOSThreadId(out pOsTid);
			return pOsTid;
		}
		
		public static void Breakpoint(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pBreakpoint)
		{
			instance.Breakpoint(pAppDomain, pThread, pBreakpoint);
		}
		
		public static void StepComplete(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pStepper, CorDebugStepReason reason)
		{
			instance.StepComplete(pAppDomain, pThread, pStepper, reason);
		}
		
		public static void Break(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr thread)
		{
			instance.Break(pAppDomain, thread);
		}
		
		public static void Exception(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, int unhandled)
		{
			instance.Exception(pAppDomain, pThread, unhandled);
		}
		
		public static void EvalComplete(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pEval)
		{
			instance.EvalComplete(pAppDomain, pThread, pEval);
		}
		
		public static void EvalException(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pEval)
		{
			instance.EvalException(pAppDomain, pThread, pEval);
		}
		
		public static void CreateProcess(this ICorDebugManagedCallback instance, IntPtr pProcess)
		{
			instance.CreateProcess(pProcess);
		}
		
		public static void ExitProcess(this ICorDebugManagedCallback instance, IntPtr pProcess)
		{
			instance.ExitProcess(pProcess);
		}
		
		public static void CreateThread(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr thread)
		{
			instance.CreateThread(pAppDomain, thread);
		}
		
		public static void ExitThread(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr thread)
		{
			instance.ExitThread(pAppDomain, thread);
		}
		
		public static void LoadModule(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pModule)
		{
			instance.LoadModule(pAppDomain, pModule);
		}
		
		public static void UnloadModule(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pModule)
		{
			instance.UnloadModule(pAppDomain, pModule);
		}
		
		public static void LoadClass(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr c)
		{
			instance.LoadClass(pAppDomain, c);
		}
		
		public static void UnloadClass(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr c)
		{
			instance.UnloadClass(pAppDomain, c);
		}
		
		public static void DebuggerError(this ICorDebugManagedCallback instance, IntPtr pProcess, int errorHR, uint errorCode)
		{
			instance.DebuggerError(pProcess, errorHR, errorCode);
		}
		
		public static void LogMessage(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, int lLevel, IntPtr pLogSwitchName, IntPtr pMessage)
		{
			instance.LogMessage(pAppDomain, pThread, lLevel, pLogSwitchName, pMessage);
		}
		
		public static void LogSwitch(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, int lLevel, uint ulReason, IntPtr pLogSwitchName, IntPtr pParentName)
		{
			instance.LogSwitch(pAppDomain, pThread, lLevel, ulReason, pLogSwitchName, pParentName);
		}
		
		public static void CreateAppDomain(this ICorDebugManagedCallback instance, IntPtr pProcess, IntPtr pAppDomain)
		{
			instance.CreateAppDomain(pProcess, pAppDomain);
		}
		
		public static void ExitAppDomain(this ICorDebugManagedCallback instance, IntPtr pProcess, IntPtr pAppDomain)
		{
			instance.ExitAppDomain(pProcess, pAppDomain);
		}
		
		public static void LoadAssembly(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pAssembly)
		{
			instance.LoadAssembly(pAppDomain, pAssembly);
		}
		
		public static void UnloadAssembly(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pAssembly)
		{
			instance.UnloadAssembly(pAppDomain, pAssembly);
		}
		
		public static void ControlCTrap(this ICorDebugManagedCallback instance, IntPtr pProcess)
		{
			instance.ControlCTrap(pProcess);
		}
		
		public static void NameChange(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread)
		{
			instance.NameChange(pAppDomain, pThread);
		}
		
		public static void UpdateModuleSymbols(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pModule, IntPtr pSymbolStream)
		{
			instance.UpdateModuleSymbols(pAppDomain, pModule, pSymbolStream);
		}
		
		public static void EditAndContinueRemap(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pFunction, int fAccurate)
		{
			instance.EditAndContinueRemap(pAppDomain, pThread, pFunction, fAccurate);
		}
		
		public static void BreakpointSetError(this ICorDebugManagedCallback instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pBreakpoint, uint dwError)
		{
			instance.BreakpointSetError(pAppDomain, pThread, pBreakpoint, dwError);
		}
		
		public static void FunctionRemapOpportunity(this ICorDebugManagedCallback2 instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pOldFunction, IntPtr pNewFunction, uint oldILOffset)
		{
			instance.FunctionRemapOpportunity(pAppDomain, pThread, pOldFunction, pNewFunction, oldILOffset);
		}
		
		public static void CreateConnection(this ICorDebugManagedCallback2 instance, IntPtr pProcess, uint dwConnectionId, IntPtr pConnName)
		{
			instance.CreateConnection(pProcess, dwConnectionId, pConnName);
		}
		
		public static void ChangeConnection(this ICorDebugManagedCallback2 instance, IntPtr pProcess, uint dwConnectionId)
		{
			instance.ChangeConnection(pProcess, dwConnectionId);
		}
		
		public static void DestroyConnection(this ICorDebugManagedCallback2 instance, IntPtr pProcess, uint dwConnectionId)
		{
			instance.DestroyConnection(pProcess, dwConnectionId);
		}
		
		public static void Exception(this ICorDebugManagedCallback2 instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pFrame, uint nOffset, CorDebugExceptionCallbackType dwEventType, uint dwFlags)
		{
			instance.Exception(pAppDomain, pThread, pFrame, nOffset, dwEventType, dwFlags);
		}
		
		public static void ExceptionUnwind(this ICorDebugManagedCallback2 instance, IntPtr pAppDomain, IntPtr pThread, CorDebugExceptionUnwindCallbackType dwEventType, uint dwFlags)
		{
			instance.ExceptionUnwind(pAppDomain, pThread, dwEventType, dwFlags);
		}
		
		public static void FunctionRemapComplete(this ICorDebugManagedCallback2 instance, IntPtr pAppDomain, IntPtr pThread, IntPtr pFunction)
		{
			instance.FunctionRemapComplete(pAppDomain, pThread, pFunction);
		}
		
		public static void MDANotification(this ICorDebugManagedCallback2 instance, IntPtr pController, IntPtr pThread, IntPtr pMDA)
		{
			instance.MDANotification(pController, pThread, pMDA);
		}
		
		public static ICorDebugProcess GetProcess(this ICorDebugModule instance)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static ulong GetBaseAddress(this ICorDebugModule instance)
		{
			ulong pAddress;
			instance.GetBaseAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugAssembly GetAssembly(this ICorDebugModule instance)
		{
			ICorDebugAssembly ppAssembly;
			instance.GetAssembly(out ppAssembly);
			ProcessOutParameter(ppAssembly);
			return ppAssembly;
		}
		
		public static void GetName(this ICorDebugModule instance, uint cchName, out uint pcchName, IntPtr szName)
		{
			instance.GetName(cchName, out pcchName, szName);
		}
		
		public static void EnableJITDebugging(this ICorDebugModule instance, int bTrackJITInfo, int bAllowJitOpts)
		{
			instance.EnableJITDebugging(bTrackJITInfo, bAllowJitOpts);
		}
		
		public static void EnableClassLoadCallbacks(this ICorDebugModule instance, int bClassLoadCallbacks)
		{
			instance.EnableClassLoadCallbacks(bClassLoadCallbacks);
		}
		
		public static ICorDebugFunction GetFunctionFromToken(this ICorDebugModule instance, uint methodDef)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunctionFromToken(methodDef, out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static ICorDebugFunction GetFunctionFromRVA(this ICorDebugModule instance, ulong rva)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunctionFromRVA(rva, out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static ICorDebugClass GetClassFromToken(this ICorDebugModule instance, uint typeDef)
		{
			ICorDebugClass ppClass;
			instance.GetClassFromToken(typeDef, out ppClass);
			ProcessOutParameter(ppClass);
			return ppClass;
		}
		
		public static ICorDebugModuleBreakpoint CreateBreakpoint(this ICorDebugModule instance)
		{
			ICorDebugModuleBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static ICorDebugEditAndContinueSnapshot GetEditAndContinueSnapshot(this ICorDebugModule instance)
		{
			ICorDebugEditAndContinueSnapshot ppEditAndContinueSnapshot;
			instance.GetEditAndContinueSnapshot(out ppEditAndContinueSnapshot);
			ProcessOutParameter(ppEditAndContinueSnapshot);
			return ppEditAndContinueSnapshot;
		}
		
		public static object GetMetaDataInterface(this ICorDebugModule instance, ref Guid riid)
		{
			object ppObj;
			instance.GetMetaDataInterface(ref riid, out ppObj);
			ProcessOutParameter(ppObj);
			return ppObj;
		}
		
		public static uint GetToken(this ICorDebugModule instance)
		{
			uint pToken;
			instance.GetToken(out pToken);
			return pToken;
		}
		
		public static int IsDynamic(this ICorDebugModule instance)
		{
			int pDynamic;
			instance.IsDynamic(out pDynamic);
			return pDynamic;
		}
		
		public static ICorDebugValue GetGlobalVariableValue(this ICorDebugModule instance, uint fieldDef)
		{
			ICorDebugValue ppValue;
			instance.GetGlobalVariableValue(fieldDef, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static uint GetSize(this ICorDebugModule instance)
		{
			uint pcBytes;
			instance.GetSize(out pcBytes);
			return pcBytes;
		}
		
		public static int IsInMemory(this ICorDebugModule instance)
		{
			int pInMemory;
			instance.IsInMemory(out pInMemory);
			return pInMemory;
		}
		
		public static void SetJMCStatus(this ICorDebugModule2 instance, int bIsJustMyCode, uint cTokens, ref uint pTokens)
		{
			instance.SetJMCStatus(bIsJustMyCode, cTokens, ref pTokens);
		}
		
		public static void ApplyChanges(this ICorDebugModule2 instance, uint cbMetadata, byte[] pbMetadata, uint cbIL, byte[] pbIL)
		{
			instance.ApplyChanges(cbMetadata, pbMetadata, cbIL, pbIL);
			ProcessOutParameter(pbMetadata);
			ProcessOutParameter(pbIL);
		}
		
		public static void SetJITCompilerFlags(this ICorDebugModule2 instance, uint dwFlags)
		{
			instance.SetJITCompilerFlags(dwFlags);
		}
		
		public static uint GetJITCompilerFlags(this ICorDebugModule2 instance)
		{
			uint pdwFlags;
			instance.GetJITCompilerFlags(out pdwFlags);
			return pdwFlags;
		}
		
		public static void ResolveAssembly(this ICorDebugModule2 instance, uint tkAssemblyRef, ref ICorDebugAssembly ppAssembly)
		{
			instance.ResolveAssembly(tkAssemblyRef, ref ppAssembly);
			ProcessOutParameter(ppAssembly);
		}
		
		public static void Activate(this ICorDebugModuleBreakpoint instance, int bActive)
		{
			instance.Activate(bActive);
		}
		
		public static int IsActive(this ICorDebugModuleBreakpoint instance)
		{
			int pbActive;
			instance.IsActive(out pbActive);
			return pbActive;
		}
		
		public static ICorDebugModule GetModule(this ICorDebugModuleBreakpoint instance)
		{
			ICorDebugModule ppModule;
			instance.GetModule(out ppModule);
			ProcessOutParameter(ppModule);
			return ppModule;
		}
		
		public static void Skip(this ICorDebugModuleEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugModuleEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugModuleEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugModuleEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugModuleEnum instance, uint celt, IntPtr modules)
		{
			uint pceltFetched;
			instance.Next(celt, modules, out pceltFetched);
			return pceltFetched;
		}
		
		public static ICorDebugChain GetChain(this ICorDebugNativeFrame instance)
		{
			ICorDebugChain ppChain;
			instance.GetChain(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugCode GetCode(this ICorDebugNativeFrame instance)
		{
			ICorDebugCode ppCode;
			instance.GetCode(out ppCode);
			ProcessOutParameter(ppCode);
			return ppCode;
		}
		
		public static ICorDebugFunction GetFunction(this ICorDebugNativeFrame instance)
		{
			ICorDebugFunction ppFunction;
			instance.GetFunction(out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static uint GetFunctionToken(this ICorDebugNativeFrame instance)
		{
			uint pToken;
			instance.GetFunctionToken(out pToken);
			return pToken;
		}
		
		public static void GetStackRange(this ICorDebugNativeFrame instance, out ulong pStart, out ulong pEnd)
		{
			instance.GetStackRange(out pStart, out pEnd);
		}
		
		public static ICorDebugFrame GetCaller(this ICorDebugNativeFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCaller(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugFrame GetCallee(this ICorDebugNativeFrame instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetCallee(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugStepper CreateStepper(this ICorDebugNativeFrame instance)
		{
			ICorDebugStepper ppStepper;
			instance.CreateStepper(out ppStepper);
			ProcessOutParameter(ppStepper);
			return ppStepper;
		}
		
		public static uint GetIP(this ICorDebugNativeFrame instance)
		{
			uint pnOffset;
			instance.GetIP(out pnOffset);
			return pnOffset;
		}
		
		public static void SetIP(this ICorDebugNativeFrame instance, uint nOffset)
		{
			instance.SetIP(nOffset);
		}
		
		public static ICorDebugRegisterSet GetRegisterSet(this ICorDebugNativeFrame instance)
		{
			ICorDebugRegisterSet ppRegisters;
			instance.GetRegisterSet(out ppRegisters);
			ProcessOutParameter(ppRegisters);
			return ppRegisters;
		}
		
		public static ICorDebugValue GetLocalRegisterValue(this ICorDebugNativeFrame instance, CorDebugRegister reg, uint cbSigBlob, uint pvSigBlob)
		{
			ICorDebugValue ppValue;
			instance.GetLocalRegisterValue(reg, cbSigBlob, pvSigBlob, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue GetLocalDoubleRegisterValue(this ICorDebugNativeFrame instance, CorDebugRegister highWordReg, CorDebugRegister lowWordReg, uint cbSigBlob, uint pvSigBlob)
		{
			ICorDebugValue ppValue;
			instance.GetLocalDoubleRegisterValue(highWordReg, lowWordReg, cbSigBlob, pvSigBlob, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue GetLocalMemoryValue(this ICorDebugNativeFrame instance, ulong address, uint cbSigBlob, uint pvSigBlob)
		{
			ICorDebugValue ppValue;
			instance.GetLocalMemoryValue(address, cbSigBlob, pvSigBlob, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue GetLocalRegisterMemoryValue(this ICorDebugNativeFrame instance, CorDebugRegister highWordReg, ulong lowWordAddress, uint cbSigBlob, uint pvSigBlob)
		{
			ICorDebugValue ppValue;
			instance.GetLocalRegisterMemoryValue(highWordReg, lowWordAddress, cbSigBlob, pvSigBlob, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue GetLocalMemoryRegisterValue(this ICorDebugNativeFrame instance, ulong highWordAddress, CorDebugRegister lowWordRegister, uint cbSigBlob, uint pvSigBlob)
		{
			ICorDebugValue ppValue;
			instance.GetLocalMemoryRegisterValue(highWordAddress, lowWordRegister, cbSigBlob, pvSigBlob, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static void CanSetIP(this ICorDebugNativeFrame instance, uint nOffset)
		{
			instance.CanSetIP(nOffset);
		}
		
		public static void Skip(this ICorDebugObjectEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugObjectEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugObjectEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugObjectEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugObjectEnum instance, uint celt, IntPtr objects)
		{
			uint pceltFetched;
			instance.Next(celt, objects, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugObjectValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugObjectValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugObjectValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugObjectValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static ICorDebugClass GetClass(this ICorDebugObjectValue instance)
		{
			ICorDebugClass ppClass;
			instance.GetClass(out ppClass);
			ProcessOutParameter(ppClass);
			return ppClass;
		}
		
		public static ICorDebugValue GetFieldValue(this ICorDebugObjectValue instance, ICorDebugClass pClass, uint fieldDef)
		{
			ICorDebugValue ppValue;
			instance.GetFieldValue(pClass, fieldDef, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugFunction GetVirtualMethod(this ICorDebugObjectValue instance, uint memberRef)
		{
			ICorDebugFunction ppFunction;
			instance.GetVirtualMethod(memberRef, out ppFunction);
			ProcessOutParameter(ppFunction);
			return ppFunction;
		}
		
		public static ICorDebugContext GetContext(this ICorDebugObjectValue instance)
		{
			ICorDebugContext ppContext;
			instance.GetContext(out ppContext);
			ProcessOutParameter(ppContext);
			return ppContext;
		}
		
		public static int IsValueClass(this ICorDebugObjectValue instance)
		{
			int pbIsValueClass;
			instance.IsValueClass(out pbIsValueClass);
			return pbIsValueClass;
		}
		
		public static object GetManagedCopy(this ICorDebugObjectValue instance)
		{
			object ppObject;
			instance.GetManagedCopy(out ppObject);
			ProcessOutParameter(ppObject);
			return ppObject;
		}
		
		public static void SetFromManagedCopy(this ICorDebugObjectValue instance, object pObject)
		{
			instance.SetFromManagedCopy(pObject);
		}
		
		public static void GetVirtualMethodAndType(this ICorDebugObjectValue2 instance, uint memberRef, out ICorDebugFunction ppFunction, out ICorDebugType ppType)
		{
			instance.GetVirtualMethodAndType(memberRef, out ppFunction, out ppType);
			ProcessOutParameter(ppFunction);
			ProcessOutParameter(ppType);
		}
		
		public static void Stop(this ICorDebugProcess instance, uint dwTimeoutIgnored)
		{
			instance.Stop(dwTimeoutIgnored);
		}
		
		public static void Continue(this ICorDebugProcess instance, int fIsOutOfBand)
		{
			instance.Continue(fIsOutOfBand);
		}
		
		public static int IsRunning(this ICorDebugProcess instance)
		{
			int pbRunning;
			instance.IsRunning(out pbRunning);
			return pbRunning;
		}
		
		public static int HasQueuedCallbacks(this ICorDebugProcess instance, ICorDebugThread pThread)
		{
			int pbQueued;
			instance.HasQueuedCallbacks(pThread, out pbQueued);
			return pbQueued;
		}
		
		public static ICorDebugThreadEnum EnumerateThreads(this ICorDebugProcess instance)
		{
			ICorDebugThreadEnum ppThreads;
			instance.EnumerateThreads(out ppThreads);
			ProcessOutParameter(ppThreads);
			return ppThreads;
		}
		
		public static void SetAllThreadsDebugState(this ICorDebugProcess instance, CorDebugThreadState state, ICorDebugThread pExceptThisThread)
		{
			instance.SetAllThreadsDebugState(state, pExceptThisThread);
		}
		
		public static void Detach(this ICorDebugProcess instance)
		{
			instance.Detach();
		}
		
		public static void Terminate(this ICorDebugProcess instance, uint exitCode)
		{
			instance.Terminate(exitCode);
		}
		
		public static ICorDebugErrorInfoEnum CanCommitChanges(this ICorDebugProcess instance, uint cSnapshots, ref ICorDebugEditAndContinueSnapshot pSnapshots)
		{
			ICorDebugErrorInfoEnum pError;
			instance.CanCommitChanges(cSnapshots, ref pSnapshots, out pError);
			ProcessOutParameter(pSnapshots);
			ProcessOutParameter(pError);
			return pError;
		}
		
		public static ICorDebugErrorInfoEnum CommitChanges(this ICorDebugProcess instance, uint cSnapshots, ref ICorDebugEditAndContinueSnapshot pSnapshots)
		{
			ICorDebugErrorInfoEnum pError;
			instance.CommitChanges(cSnapshots, ref pSnapshots, out pError);
			ProcessOutParameter(pSnapshots);
			ProcessOutParameter(pError);
			return pError;
		}
		
		public static uint GetID(this ICorDebugProcess instance)
		{
			uint pdwProcessId;
			instance.GetID(out pdwProcessId);
			return pdwProcessId;
		}
		
		public static uint GetHandle(this ICorDebugProcess instance)
		{
			uint phProcessHandle;
			instance.GetHandle(out phProcessHandle);
			return phProcessHandle;
		}
		
		public static ICorDebugThread GetThread(this ICorDebugProcess instance, uint dwThreadId)
		{
			ICorDebugThread ppThread;
			instance.GetThread(dwThreadId, out ppThread);
			ProcessOutParameter(ppThread);
			return ppThread;
		}
		
		public static ICorDebugObjectEnum EnumerateObjects(this ICorDebugProcess instance)
		{
			ICorDebugObjectEnum ppObjects;
			instance.EnumerateObjects(out ppObjects);
			ProcessOutParameter(ppObjects);
			return ppObjects;
		}
		
		public static int IsTransitionStub(this ICorDebugProcess instance, ulong address)
		{
			int pbTransitionStub;
			instance.IsTransitionStub(address, out pbTransitionStub);
			return pbTransitionStub;
		}
		
		public static int IsOSSuspended(this ICorDebugProcess instance, uint threadID)
		{
			int pbSuspended;
			instance.IsOSSuspended(threadID, out pbSuspended);
			return pbSuspended;
		}
		
		public static void GetThreadContext(this ICorDebugProcess instance, uint threadID, uint contextSize, IntPtr context)
		{
			instance.GetThreadContext(threadID, contextSize, context);
		}
		
		public static void SetThreadContext(this ICorDebugProcess instance, uint threadID, uint contextSize, IntPtr context)
		{
			instance.SetThreadContext(threadID, contextSize, context);
		}
		
		public static uint ReadMemory(this ICorDebugProcess instance, ulong address, uint size, IntPtr buffer)
		{
			uint read;
			instance.ReadMemory(address, size, buffer, out read);
			return read;
		}
		
		public static uint WriteMemory(this ICorDebugProcess instance, ulong address, uint size, IntPtr buffer)
		{
			uint written;
			instance.WriteMemory(address, size, buffer, out written);
			return written;
		}
		
		public static void ClearCurrentException(this ICorDebugProcess instance, uint threadID)
		{
			instance.ClearCurrentException(threadID);
		}
		
		public static void EnableLogMessages(this ICorDebugProcess instance, int fOnOff)
		{
			instance.EnableLogMessages(fOnOff);
		}
		
		public static void ModifyLogSwitch(this ICorDebugProcess instance, IntPtr pLogSwitchName, int lLevel)
		{
			instance.ModifyLogSwitch(pLogSwitchName, lLevel);
		}
		
		public static ICorDebugAppDomainEnum EnumerateAppDomains(this ICorDebugProcess instance)
		{
			ICorDebugAppDomainEnum ppAppDomains;
			instance.EnumerateAppDomains(out ppAppDomains);
			ProcessOutParameter(ppAppDomains);
			return ppAppDomains;
		}
		
		public static ICorDebugValue GetObject(this ICorDebugProcess instance)
		{
			ICorDebugValue ppObject;
			instance.GetObject(out ppObject);
			ProcessOutParameter(ppObject);
			return ppObject;
		}
		
		public static ICorDebugThread ThreadForFiberCookie(this ICorDebugProcess instance, uint fiberCookie)
		{
			ICorDebugThread ppThread;
			instance.ThreadForFiberCookie(fiberCookie, out ppThread);
			ProcessOutParameter(ppThread);
			return ppThread;
		}
		
		public static uint GetHelperThreadID(this ICorDebugProcess instance)
		{
			uint pThreadID;
			instance.GetHelperThreadID(out pThreadID);
			return pThreadID;
		}
		
		public static ICorDebugThread2 GetThreadForTaskID(this ICorDebugProcess2 instance, ulong taskid)
		{
			ICorDebugThread2 ppThread;
			instance.GetThreadForTaskID(taskid, out ppThread);
			ProcessOutParameter(ppThread);
			return ppThread;
		}
		
		public static _COR_VERSION GetVersion(this ICorDebugProcess2 instance)
		{
			_COR_VERSION version;
			instance.GetVersion(out version);
			ProcessOutParameter(version);
			return version;
		}
		
		public static uint SetUnmanagedBreakpoint(this ICorDebugProcess2 instance, ulong address, uint bufsize, IntPtr buffer)
		{
			uint bufLen;
			instance.SetUnmanagedBreakpoint(address, bufsize, buffer, out bufLen);
			return bufLen;
		}
		
		public static void ClearUnmanagedBreakpoint(this ICorDebugProcess2 instance, ulong address)
		{
			instance.ClearUnmanagedBreakpoint(address);
		}
		
		public static void SetDesiredNGENCompilerFlags(this ICorDebugProcess2 instance, uint pdwFlags)
		{
			instance.SetDesiredNGENCompilerFlags(pdwFlags);
		}
		
		public static uint GetDesiredNGENCompilerFlags(this ICorDebugProcess2 instance)
		{
			uint pdwFlags;
			instance.GetDesiredNGENCompilerFlags(out pdwFlags);
			return pdwFlags;
		}
		
		public static ICorDebugReferenceValue GetReferenceValueFromGCHandle(this ICorDebugProcess2 instance, uint handle)
		{
			ICorDebugReferenceValue pOutValue;
			instance.GetReferenceValueFromGCHandle(handle, out pOutValue);
			ProcessOutParameter(pOutValue);
			return pOutValue;
		}
		
		public static void Skip(this ICorDebugProcessEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugProcessEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugProcessEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugProcessEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugProcessEnum instance, uint celt, IntPtr processes)
		{
			uint pceltFetched;
			instance.Next(celt, processes, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugReferenceValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugReferenceValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugReferenceValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugReferenceValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static int IsNull(this ICorDebugReferenceValue instance)
		{
			int pbNull;
			instance.IsNull(out pbNull);
			return pbNull;
		}
		
		public static ulong GetValue(this ICorDebugReferenceValue instance)
		{
			ulong pValue;
			instance.GetValue(out pValue);
			return pValue;
		}
		
		public static void SetValue(this ICorDebugReferenceValue instance, ulong value)
		{
			instance.SetValue(value);
		}
		
		public static ICorDebugValue Dereference(this ICorDebugReferenceValue instance)
		{
			ICorDebugValue ppValue;
			instance.Dereference(out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ICorDebugValue DereferenceStrong(this ICorDebugReferenceValue instance)
		{
			ICorDebugValue ppValue;
			instance.DereferenceStrong(out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static ulong GetRegistersAvailable(this ICorDebugRegisterSet instance)
		{
			ulong pAvailable;
			instance.GetRegistersAvailable(out pAvailable);
			return pAvailable;
		}
		
		public static void GetRegisters(this ICorDebugRegisterSet instance, ulong mask, uint regCount, IntPtr regBuffer)
		{
			instance.GetRegisters(mask, regCount, regBuffer);
		}
		
		public static void SetRegisters(this ICorDebugRegisterSet instance, ulong mask, uint regCount, ref ulong regBuffer)
		{
			instance.SetRegisters(mask, regCount, ref regBuffer);
		}
		
		public static void GetThreadContext(this ICorDebugRegisterSet instance, uint contextSize, IntPtr context)
		{
			instance.GetThreadContext(contextSize, context);
		}
		
		public static void SetThreadContext(this ICorDebugRegisterSet instance, uint contextSize, IntPtr context)
		{
			instance.SetThreadContext(contextSize, context);
		}
		
		public static int IsActive(this ICorDebugStepper instance)
		{
			int pbActive;
			instance.IsActive(out pbActive);
			return pbActive;
		}
		
		public static void Deactivate(this ICorDebugStepper instance)
		{
			instance.Deactivate();
		}
		
		public static void SetInterceptMask(this ICorDebugStepper instance, CorDebugIntercept mask)
		{
			instance.SetInterceptMask(mask);
		}
		
		public static void SetUnmappedStopMask(this ICorDebugStepper instance, CorDebugUnmappedStop mask)
		{
			instance.SetUnmappedStopMask(mask);
		}
		
		public static void Step(this ICorDebugStepper instance, int bStepIn)
		{
			instance.Step(bStepIn);
		}
		
		public static void StepRange(this ICorDebugStepper instance, int bStepIn, IntPtr ranges, uint cRangeCount)
		{
			instance.StepRange(bStepIn, ranges, cRangeCount);
		}
		
		public static void StepOut(this ICorDebugStepper instance)
		{
			instance.StepOut();
		}
		
		public static void SetRangeIL(this ICorDebugStepper instance, int bIL)
		{
			instance.SetRangeIL(bIL);
		}
		
		public static void SetJMC(this ICorDebugStepper2 instance, int fIsJMCStepper)
		{
			instance.SetJMC(fIsJMCStepper);
		}
		
		public static void Skip(this ICorDebugStepperEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugStepperEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugStepperEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugStepperEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugStepperEnum instance, uint celt, IntPtr steppers)
		{
			uint pceltFetched;
			instance.Next(celt, steppers, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugStringValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugStringValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugStringValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugStringValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static int IsValid(this ICorDebugStringValue instance)
		{
			int pbValid;
			instance.IsValid(out pbValid);
			return pbValid;
		}
		
		public static ICorDebugValueBreakpoint CreateRelocBreakpoint(this ICorDebugStringValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateRelocBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static uint GetLength(this ICorDebugStringValue instance)
		{
			uint pcchString;
			instance.GetLength(out pcchString);
			return pcchString;
		}
		
		public static void GetString(this ICorDebugStringValue instance, uint cchString, out uint pcchString, IntPtr szString)
		{
			instance.GetString(cchString, out pcchString, szString);
		}
		
		public static ICorDebugProcess GetProcess(this ICorDebugThread instance)
		{
			ICorDebugProcess ppProcess;
			instance.GetProcess(out ppProcess);
			ProcessOutParameter(ppProcess);
			return ppProcess;
		}
		
		public static uint GetID(this ICorDebugThread instance)
		{
			uint pdwThreadId;
			instance.GetID(out pdwThreadId);
			return pdwThreadId;
		}
		
		public static uint GetHandle(this ICorDebugThread instance)
		{
			uint phThreadHandle;
			instance.GetHandle(out phThreadHandle);
			return phThreadHandle;
		}
		
		public static ICorDebugAppDomain GetAppDomain(this ICorDebugThread instance)
		{
			ICorDebugAppDomain ppAppDomain;
			instance.GetAppDomain(out ppAppDomain);
			ProcessOutParameter(ppAppDomain);
			return ppAppDomain;
		}
		
		public static void SetDebugState(this ICorDebugThread instance, CorDebugThreadState state)
		{
			instance.SetDebugState(state);
		}
		
		public static CorDebugThreadState GetDebugState(this ICorDebugThread instance)
		{
			CorDebugThreadState pState;
			instance.GetDebugState(out pState);
			ProcessOutParameter(pState);
			return pState;
		}
		
		public static CorDebugUserState GetUserState(this ICorDebugThread instance)
		{
			CorDebugUserState pState;
			instance.GetUserState(out pState);
			ProcessOutParameter(pState);
			return pState;
		}
		
		public static ICorDebugValue GetCurrentException(this ICorDebugThread instance)
		{
			ICorDebugValue ppExceptionObject;
			instance.GetCurrentException(out ppExceptionObject);
			ProcessOutParameter(ppExceptionObject);
			return ppExceptionObject;
		}
		
		public static void ClearCurrentException(this ICorDebugThread instance)
		{
			instance.ClearCurrentException();
		}
		
		public static ICorDebugStepper CreateStepper(this ICorDebugThread instance)
		{
			ICorDebugStepper ppStepper;
			instance.CreateStepper(out ppStepper);
			ProcessOutParameter(ppStepper);
			return ppStepper;
		}
		
		public static ICorDebugChainEnum EnumerateChains(this ICorDebugThread instance)
		{
			ICorDebugChainEnum ppChains;
			instance.EnumerateChains(out ppChains);
			ProcessOutParameter(ppChains);
			return ppChains;
		}
		
		public static ICorDebugChain GetActiveChain(this ICorDebugThread instance)
		{
			ICorDebugChain ppChain;
			instance.GetActiveChain(out ppChain);
			ProcessOutParameter(ppChain);
			return ppChain;
		}
		
		public static ICorDebugFrame GetActiveFrame(this ICorDebugThread instance)
		{
			ICorDebugFrame ppFrame;
			instance.GetActiveFrame(out ppFrame);
			ProcessOutParameter(ppFrame);
			return ppFrame;
		}
		
		public static ICorDebugRegisterSet GetRegisterSet(this ICorDebugThread instance)
		{
			ICorDebugRegisterSet ppRegisters;
			instance.GetRegisterSet(out ppRegisters);
			ProcessOutParameter(ppRegisters);
			return ppRegisters;
		}
		
		public static ICorDebugEval CreateEval(this ICorDebugThread instance)
		{
			ICorDebugEval ppEval;
			instance.CreateEval(out ppEval);
			ProcessOutParameter(ppEval);
			return ppEval;
		}
		
		public static ICorDebugValue GetObject(this ICorDebugThread instance)
		{
			ICorDebugValue ppObject;
			instance.GetObject(out ppObject);
			ProcessOutParameter(ppObject);
			return ppObject;
		}
		
		public static void GetActiveFunctions(this ICorDebugThread2 instance, uint cFunctions, out uint pcFunctions, IntPtr pFunctions)
		{
			instance.GetActiveFunctions(cFunctions, out pcFunctions, pFunctions);
		}
		
		public static uint GetConnectionID(this ICorDebugThread2 instance)
		{
			uint pdwConnectionId;
			instance.GetConnectionID(out pdwConnectionId);
			return pdwConnectionId;
		}
		
		public static ulong GetTaskID(this ICorDebugThread2 instance)
		{
			ulong pTaskId;
			instance.GetTaskID(out pTaskId);
			return pTaskId;
		}
		
		public static uint GetVolatileOSThreadID(this ICorDebugThread2 instance)
		{
			uint pdwTid;
			instance.GetVolatileOSThreadID(out pdwTid);
			return pdwTid;
		}
		
		public static void InterceptCurrentException(this ICorDebugThread2 instance, ICorDebugFrame pFrame)
		{
			instance.InterceptCurrentException(pFrame);
		}
		
		public static void Skip(this ICorDebugThreadEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugThreadEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugThreadEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugThreadEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugThreadEnum instance, uint celt, IntPtr threads)
		{
			uint pceltFetched;
			instance.Next(celt, threads, out pceltFetched);
			return pceltFetched;
		}
		
		public static uint GetType(this ICorDebugType instance)
		{
			uint ty;
			instance.GetType(out ty);
			return ty;
		}
		
		public static ICorDebugClass GetClass(this ICorDebugType instance)
		{
			ICorDebugClass ppClass;
			instance.GetClass(out ppClass);
			ProcessOutParameter(ppClass);
			return ppClass;
		}
		
		public static ICorDebugTypeEnum EnumerateTypeParameters(this ICorDebugType instance)
		{
			ICorDebugTypeEnum ppTyParEnum;
			instance.EnumerateTypeParameters(out ppTyParEnum);
			ProcessOutParameter(ppTyParEnum);
			return ppTyParEnum;
		}
		
		public static ICorDebugType GetFirstTypeParameter(this ICorDebugType instance)
		{
			ICorDebugType value;
			instance.GetFirstTypeParameter(out value);
			ProcessOutParameter(value);
			return value;
		}
		
		public static ICorDebugType GetBase(this ICorDebugType instance)
		{
			ICorDebugType pBase;
			instance.GetBase(out pBase);
			ProcessOutParameter(pBase);
			return pBase;
		}
		
		public static ICorDebugValue GetStaticFieldValue(this ICorDebugType instance, uint fieldDef, ICorDebugFrame pFrame)
		{
			ICorDebugValue ppValue;
			instance.GetStaticFieldValue(fieldDef, pFrame, out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static uint GetRank(this ICorDebugType instance)
		{
			uint pnRank;
			instance.GetRank(out pnRank);
			return pnRank;
		}
		
		public static void Skip(this ICorDebugTypeEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugTypeEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugTypeEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugTypeEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugTypeEnum instance, uint celt, ICorDebugType[] values)
		{
			uint pceltFetched;
			instance.Next(celt, values, out pceltFetched);
			ProcessOutParameter(values);
			return pceltFetched;
		}
		
		public static void DebugEvent(this ICorDebugUnmanagedCallback instance, uint pDebugEvent, int fOutOfBand)
		{
			instance.DebugEvent(pDebugEvent, fOutOfBand);
		}
		
		public static uint GetType(this ICorDebugValue instance)
		{
			uint pType;
			instance.GetType(out pType);
			return pType;
		}
		
		public static uint GetSize(this ICorDebugValue instance)
		{
			uint pSize;
			instance.GetSize(out pSize);
			return pSize;
		}
		
		public static ulong GetAddress(this ICorDebugValue instance)
		{
			ulong pAddress;
			instance.GetAddress(out pAddress);
			return pAddress;
		}
		
		public static ICorDebugValueBreakpoint CreateBreakpoint(this ICorDebugValue instance)
		{
			ICorDebugValueBreakpoint ppBreakpoint;
			instance.CreateBreakpoint(out ppBreakpoint);
			ProcessOutParameter(ppBreakpoint);
			return ppBreakpoint;
		}
		
		public static ICorDebugType GetExactType(this ICorDebugValue2 instance)
		{
			ICorDebugType ppType;
			instance.GetExactType(out ppType);
			ProcessOutParameter(ppType);
			return ppType;
		}
		
		public static void Activate(this ICorDebugValueBreakpoint instance, int bActive)
		{
			instance.Activate(bActive);
		}
		
		public static int IsActive(this ICorDebugValueBreakpoint instance)
		{
			int pbActive;
			instance.IsActive(out pbActive);
			return pbActive;
		}
		
		public static ICorDebugValue GetValue(this ICorDebugValueBreakpoint instance)
		{
			ICorDebugValue ppValue;
			instance.GetValue(out ppValue);
			ProcessOutParameter(ppValue);
			return ppValue;
		}
		
		public static void Skip(this ICorDebugValueEnum instance, uint celt)
		{
			instance.Skip(celt);
		}
		
		public static void Reset(this ICorDebugValueEnum instance)
		{
			instance.Reset();
		}
		
		public static ICorDebugEnum Clone(this ICorDebugValueEnum instance)
		{
			ICorDebugEnum ppEnum;
			instance.Clone(out ppEnum);
			ProcessOutParameter(ppEnum);
			return ppEnum;
		}
		
		public static uint GetCount(this ICorDebugValueEnum instance)
		{
			uint pcelt;
			instance.GetCount(out pcelt);
			return pcelt;
		}
		
		public static uint Next(this ICorDebugValueEnum instance, uint celt, IntPtr values)
		{
			uint pceltFetched;
			instance.Next(celt, values, out pceltFetched);
			return pceltFetched;
		}
		
		public static void RemoteRead(this ISequentialStream instance, out byte pv, uint cb, out uint pcbRead)
		{
			instance.RemoteRead(out pv, cb, out pcbRead);
			ProcessOutParameter(pv);
		}
		
		public static uint RemoteWrite(this ISequentialStream instance, ref byte pv, uint cb)
		{
			uint pcbWritten;
			instance.RemoteWrite(ref pv, cb, out pcbWritten);
			ProcessOutParameter(pv);
			return pcbWritten;
		}
		
		public static void RemoteRead(this IStream instance, out byte pv, uint cb, out uint pcbRead)
		{
			instance.RemoteRead(out pv, cb, out pcbRead);
			ProcessOutParameter(pv);
		}
		
		public static uint RemoteWrite(this IStream instance, ref byte pv, uint cb)
		{
			uint pcbWritten;
			instance.RemoteWrite(ref pv, cb, out pcbWritten);
			ProcessOutParameter(pv);
			return pcbWritten;
		}
		
		public static _ULARGE_INTEGER RemoteSeek(this IStream instance, _LARGE_INTEGER dlibMove, uint dwOrigin)
		{
			_ULARGE_INTEGER plibNewPosition;
			instance.RemoteSeek(dlibMove, dwOrigin, out plibNewPosition);
			ProcessOutParameter(plibNewPosition);
			return plibNewPosition;
		}
		
		public static void SetSize(this IStream instance, _ULARGE_INTEGER libNewSize)
		{
			instance.SetSize(libNewSize);
		}
		
		public static void RemoteCopyTo(this IStream instance, IStream pstm, _ULARGE_INTEGER cb, out _ULARGE_INTEGER pcbRead, out _ULARGE_INTEGER pcbWritten)
		{
			instance.RemoteCopyTo(pstm, cb, out pcbRead, out pcbWritten);
			ProcessOutParameter(pcbRead);
			ProcessOutParameter(pcbWritten);
		}
		
		public static void Commit(this IStream instance, uint grfCommitFlags)
		{
			instance.Commit(grfCommitFlags);
		}
		
		public static void Revert(this IStream instance)
		{
			instance.Revert();
		}
		
		public static void LockRegion(this IStream instance, _ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType)
		{
			instance.LockRegion(libOffset, cb, dwLockType);
		}
		
		public static void UnlockRegion(this IStream instance, _ULARGE_INTEGER libOffset, _ULARGE_INTEGER cb, uint dwLockType)
		{
			instance.UnlockRegion(libOffset, cb, dwLockType);
		}
		
		public static void Stat(this IStream instance, out tagSTATSTG pstatstg, uint grfStatFlag)
		{
			instance.Stat(out pstatstg, grfStatFlag);
			ProcessOutParameter(pstatstg);
		}
		
		public static IStream Clone(this IStream instance)
		{
			IStream ppstm;
			instance.Clone(out ppstm);
			ProcessOutParameter(ppstm);
			return ppstm;
		}
		
	}
}
