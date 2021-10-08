using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    [RequireComponent(typeof(EventSystem))]
    //引发事件并将其发送到GameObjects的基本模块。
    //输入模块是EventSystem的一个组件，负责引发事件并将其发送到GameObjects进行处理。
    //BaseInputModule是EventSystem中所有输入模块继承自的类。提供的模块示例有TouchInputModule和StandaloneInputModule
    //，如果它们不适合您的项目，您可以通过扩展BaseInputModule来创建自己的模块。
    public abstract class BaseInputModule : UIBehaviour
    {
        [NonSerialized]
        protected List<RaycastResult> m_RaycastResultCache = new List<RaycastResult>();
        private AxisEventData m_AxisEventData;

        private EventSystem m_EventSystem;
        private BaseEventData m_BaseEventData;

        protected BaseInput m_InputOverride;
        private BaseInput m_DefaultInput;

        /// <summary>
        /// 输入模块使用的当前基本输入。
        /// </summary>
        public BaseInput input
        {
            get
            {
                if(m_InputOverride != null)
                {
                    return m_InputOverride;
                }
                if (m_DefaultInput == null)
                {
                    var inputs = GetComponents<BaseInput>();
                    foreach (var baseInput in inputs)
                    {
                        //我们不想使用任何从BaseInput派生的类作为默认类。
                        if (baseInput != null && baseInput.GetType() == typeof(BaseInput))
                        {
                            m_DefaultInput = baseInput;
                            break;
                        }
                    }
                }
                return m_DefaultInput;
            }
        }
        /// <summary>
        /// 用于覆盖输入模块的默认BaseInput。
        /// 有了它，就可以用自己的输入系统绕过输入系统，但仍然使用相同的输入模块。
        /// 例如，这可以用于将假输入输入到UI或与不同输入系统的接口中。
        /// </summary>
        public BaseInput inputOverride
        {
            get { return m_InputOverride; }
            set { m_InputOverride = value; }
        }

        protected EventSystem eventSystem
        {
            get { return m_EventSystem;}
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            m_EventSystem = GetComponent<EventSystem>();
            m_EventSystem.UpdateModules();
        }








    }
}