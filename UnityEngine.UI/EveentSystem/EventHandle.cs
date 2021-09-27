using System;
namespace UnityEngine.EventSystems
{
    [Flags]
    ///跟踪事件状态的枚举。
    public enum EventHandle
    {
        Unused = 0,
        Used = 1
    }
}