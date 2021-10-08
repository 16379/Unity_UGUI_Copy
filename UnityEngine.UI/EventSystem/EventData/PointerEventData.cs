using System;
using System.Text;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    /// <summary>
    /// ÿ�������¼����ᴴ������һ�������а������������Ϣ��
    /// </summary>
    public class PointerEventData : BaseEventData
    {
        public enum InputButton
        {
            Left = 0,
            Right = 1,
            Middle = 2,
        }
        /// <summary>
        /// ����֡�İ�ť״̬��
        /// </summary>
        public enum FramePressState
        {
            /// <summary>
            /// ����
            /// </summary>
            Pressed,
            /// <summary>
            /// ̧��
            /// </summary>
            Released,
            /// <summary>
            /// ��ͬһ̧֡��Ͱ���
            /// </summary>
            PressedAndReleased,
            /// <summary>
            /// ����һ֡��ͬ
            /// </summary>
            NotChanged,
        }
        /// <summary>
        /// ���ա�OnPointReferer���Ķ���
        /// </summary>
        public GameObject pointerEnter { get; set; }
        //���ա�OnPointerDown���Ķ���
        private GameObject m_PointerPress;
        /// <summary>
        /// �ϴΰ����¼���ԭʼ��Ϸ��������ζ�����ǡ����¡�����Ϸ���󣬼�ʹ�������޷����հ����¼���
        /// </summary>
        public GameObject lastPress { get; private set; }
        /// <summary>
        /// ��ʹ�޷�����press�¼���Ҳ����press�Ķ���
        /// </summary>
        public GameObject rawPointerPress { get; set; }
        /// <summary>
        /// ���ա�OnDrag���Ķ���
        /// </summary>
        public GameObject pointerDrag { get; set; }
        /// <summary>
        /// �뵱ǰ�¼�������RaycastResult��
        /// </summary>
        public RaycastResult pointerCurrentRaycast { get; set; }
        /// <summary>
        /// ��ָ�밴�¹�����RaycastResult��
        /// </summary>
        public RaycastResult pointerPressRaycast { get; set; }

        public List<GameObject> hovered = new List<GameObject>();
        /// <summary>
        /// �Ƿ���Ե����˿��
        /// </summary>
        public bool eligibleForClick { get; set; }
        /// <summary>
        /// ���°�ť��ID
        /// </summary>
        public int pointerId { get; set; }
        /// <summary>
        /// ��ǰ��ť��λ��
        /// </summary>
        public Vector2 position { get; set; }
        /// <summary>
        /// �ϴθ��º��ָ��������
        /// </summary>
        public Vector2 delta { get; set; }
        /// <summary>
        /// ��ť��λ��
        /// </summary>
        public Vector2 pressPosition { get; set; }

        /// <summary>
        /// ����ռ����Ͷ�䵽��Ļ�ϻ��������λ��
        /// </summary>
        [Obsolete("ʹ��PointerCurrentyCast.worldPosition��pointerPressRaycast.worldPosition")]
        public Vector3 worldPosition { get; set; }

        /// <summary>
        /// Ͷ�䵽��Ļ�ϵĹ��߻������������ռ䷨��
        /// </summary>
        [Obsolete("ʹ��pointerCurrentRaycast.worldNormal��pointerPressRaycast.worldNormal")]
        public Vector3 worldNormal { get; set; }
        /// <summary>
        /// �ϴη��͵����¼���ʱ�䡣����˫��
        /// </summary>
        public float clickTime { get; set; }

    }
}