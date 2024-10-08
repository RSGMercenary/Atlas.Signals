﻿using Atlas.Signals.Slots;
using System;

namespace Atlas.Signals.Signals;

public class Signal : SignalBase<Slot, ISlot, Action>, ISignal, IDispatch
{
	public bool Dispatch() => Dispatch(slot => slot.Dispatch());
}

public class Signal<T1> : SignalBase<Slot<T1>, ISlot<T1>, Action<T1>>, ISignal<T1>, IDispatch<T1>
{
	public bool Dispatch(T1 item1) => Dispatch(slot => slot.Dispatch(item1));
}

public class Signal<T1, T2> : SignalBase<Slot<T1, T2>, ISlot<T1, T2>, Action<T1, T2>>, ISignal<T1, T2>, IDispatch<T1, T2>
{
	public bool Dispatch(T1 item1, T2 item2) => Dispatch(slot => slot.Dispatch(item1, item2));
}

public class Signal<T1, T2, T3> : SignalBase<Slot<T1, T2, T3>, ISlot<T1, T2, T3>, Action<T1, T2, T3>>, ISignal<T1, T2, T3>, IDispatch<T1, T2, T3>
{
	public bool Dispatch(T1 item1, T2 item2, T3 item3) => Dispatch(slot => slot.Dispatch(item1, item2, item3));
}

public class Signal<T1, T2, T3, T4> : SignalBase<Slot<T1, T2, T3, T4>, ISlot<T1, T2, T3, T4>, Action<T1, T2, T3, T4>>, ISignal<T1, T2, T3, T4>, IDispatch<T1, T2, T3, T4>
{
	public bool Dispatch(T1 item1, T2 item2, T3 item3, T4 item4) => Dispatch(slot => slot.Dispatch(item1, item2, item3, item4));
}