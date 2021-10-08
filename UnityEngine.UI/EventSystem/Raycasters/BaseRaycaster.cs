using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    /// <summary>
    /// ���й���Ͷ�����Ļ��ࡣ
    /// ����Ͷ��������Գ���Ԫ�ؽ��й���Ͷ�䣬��ȷ������Ƿ�λ����ЩԪ���ϡ�
    /// Ĭ�Ϲ���Ͷ��������PhysicsRaycaster��Physics2DRaycaster��GraphicRaycaster��
    /// ����ͨ����չ��������Զ������Ͷ������
    /// </summary>
    public abstract class BaseRaycaster : UIBehaviour 
    {
        private BaseRaycaster m_RootRaycaster;
        /// <summary>
        /// ���ֳ����й���Ͷ�䡣
        /// </summary>
        /// <param name="eventData">��ǰ�¼�����</param>
        /// <param name="resultAppendList">��ײ�������������</param>
        public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
        /// <summary>
        /// ��Ϊ�˹���Ͷ�������ɹ��ߵ���Ӱ����
        /// </summary>
        public abstract Camera eventCamera { get; }

        [Obsolete("Please use sortOrderPriority and rederOrderPriority",false)]
        public virtual int priority
        {
            get { return 0; }
        }
        /// <summary>
        /// ��������˳��Ĺ���Ͷ�������ȼ���
        /// </summary>
        public virtual int sortOrderPriority
        {
            get { return int.MinValue; }
        }

        /// <summary>
        /// ������Ⱦ˳��Ĺ���Ͷ�������ȼ���
        /// </summary>
        public virtual int renderOrderPriority
        {
            get { return int.MinValue; }
        }
        /// <summary>
        /// �������ϵĹ���Ͷ����
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