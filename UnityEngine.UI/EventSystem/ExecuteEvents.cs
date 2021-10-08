using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.EventSystems
{
    public static class ExecuteEvents
    {
        public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);

        public static T ValidateEventData<T>(BaseEventData data) where T :class
        {
            if ((data as T) == null)
                throw new ArgumentException("");
            return data as T;
        }

        private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler = Execute;
        private static void Execute(IPointerEnterHandler handler,BaseEventData eventData)
        {
            handler.OnPointerEnter(ValidateEventData<PointerEventData>(eventData));
        }

        //private static readonly EventFunction<IPointerExitHandler>




    }
}
