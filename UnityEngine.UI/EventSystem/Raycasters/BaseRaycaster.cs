using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    /// <summary>
    /// 所有光线投射器的基类。
    /// 光线投射器负责对场景元素进行光线投射，以确定光标是否位于这些元素上。
    /// 默认光线投射器包括PhysicsRaycaster、Physics2DRaycaster、GraphicRaycaster。
    /// 可以通过扩展此类添加自定义光线投射器。
    /// </summary>
    public abstract class BaseRaycaster : UIBehaviour 
    {
        private BaseRaycaster m_RootRaycaster;
        /// <summary>
        /// 对现场进行光线投射。
        /// </summary>
        /// <param name="eventData">当前事件数据</param>
        /// <param name="resultAppendList">碰撞到的物体的名单</param>
        public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
        /// <summary>
        /// 将为此光线投射器生成光线的摄影机。
        /// </summary>
        public abstract Camera eventCamera { get; }

        [Obsolete("Please use sortOrderPriority and rederOrderPriority",false)]
        public virtual int priority
        {
            get { return 0; }
        }
        /// <summary>
        /// 基于排序顺序的光线投射器优先级。
        /// </summary>
        public virtual int sortOrderPriority
        {
            get { return int.MinValue; }
        }

        /// <summary>
        /// 基于渲染顺序的光线投射器优先级。
        /// </summary>
        public virtual int renderOrderPriority
        {
            get { return int.MinValue; }
        }
        /// <summary>
        /// 根画布上的光线投射器
        /// </summary>
        public BaseRaycaster rootRaycaster
        {
            get
            {
                if(m_RootRaycaster == null)
                {
                    var baseRaycasters = GetComponentsInParent<BaseRaycaster>();
                    if(baseRaycasters.Length != 0)
                    {
                        m_RootRaycaster = baseRaycasters[baseRaycasters.Length - 1];
                    }
                }
                return m_RootRaycaster;
            }
        }

        public override string ToString()
        {
            return "Name: " + gameObject + "\n" +
                "eventCamera: " + eventCamera + "\n" +
                "sortOrderPriority: " + sortOrderPriority + "\n" +
                "renderOrderPriority: " + renderOrderPriority;
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            RaycasterManager.AddRaycaster(this);
        }

        protected override void OnDisable()
        {
            RaycasterManager.RemoveRaycasters(this);
            base.OnDisable();
        }

        protected override void OnCanvasHierarchyChanged()
        {
            base.OnCanvasHierarchyChanged();
            m_RootRaycaster = null;
        }
        protected override void OnTransformParentChanged()
        {
            base.OnTransformParentChanged();
            m_RootRaycaster = null;
        }


    }

}