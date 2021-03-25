using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gemini.Core;
using System.Threading;
using System;

public static class Executor
{
    public static T Execute<T, V, U>(V func, U request)
        where T : new()
        where V : Delegate 
    {
        T response = new T();
        ManualResetEvent signalEvent = new ManualResetEvent(false);

        ThreadManager.ExecuteOnMainThread(() =>
        {
            response = (T)func.DynamicInvoke(request);
            signalEvent.Set();
        });

        // Wait for the event to be triggered from the action, signaling that the action is finished
        // This is required becaue we are reading and depending on state from a resource running on the
        // Unity main thread.
        signalEvent.WaitOne();
        signalEvent.Close();
        return response;
    }
}
