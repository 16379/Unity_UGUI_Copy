using System;
using System.Text;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    /// <summary>
    /// 每个触摸事件都会创建其中一个，其中包含所有相关信息。
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
        /// 给定帧的按钮状态。
        /// </summary>
        public enum FramePressState
        {
            /// <summary>
            /// 按下
            /// </summary>
            Pressed,
            /// <summary>
            /// 抬起
            /// </summary>
            Released,
            /// <summary>
            /// 在同一帧抬起和按下
            /// </summary>
            PressedAndReleased,
            /// <summary>
            /// 与上一帧相同
            /// </summary>
            NotChanged,
        }
        /// <summary>
        /// 接收“OnPointReferer”的对象。
        /// </summary>
        public GameObject pointerEnter { get; set; }
        //接收“OnPointerDown”的对象。
        private GameObject m_PointerPress;
        /// <summary>
        /// 上次按下事件的原始游戏对象。这意味着它是“按下”的游戏对象，即使它本身无法接收按下事件。
        /// </summary>
        public GameObject lastPress { get; private set; }
        /// <summary>
        /// 即使无法处理press事件，也发生press的对象。
        /// </summary>
        public GameObject rawPointerPress { get; set; }
        /// <summary>
        /// 接收“OnDrag”的对象
        /// </summary>
        public GameObject pointerDrag { get; set; }
        /// <summary>
        /// 与当前事件关联的RaycastResult。
        /// </summary>
        public RaycastResult pointerCurrentRaycast { get; set; }
        /// <summary>
        /// 与指针按下关联的RaycastResult。
        /// </summary>
        public RaycastResult pointerPressRaycast { get; set; }

        public List<GameObject> hovered = new List<GameObject>();
        /// <summary>
        /// 是否可以单击此框架
        /// </summary>
        public bool eligibleForClick { get; set; }
        /// <summary>
        /// 按下按钮的ID
        /// </summary>
        public int pointerId { get; set; }
        /// <summary>
        /// 当前按钮的位置
        /// </summary>
        public Vector2 position { get; set; }
        /// <summary>
        /// 上次更新后的指针增量。
        /// </summary>
        public Vector2 delta { get; set; }
        /// <summary>
        /// 按钮的位置
        /// </summary>
        public Vector2 pressPosition { get; set; }

        /// <summary>
        /// 世界空间光线投射到屏幕上击中物体的位置
        /// </summary>
        [Obsolete("使用PointerCurrentyCast.worldPosition或pointerPressRaycast.worldPosition")]
        public Vector3 worldPosition { get; set; }

        /// <summary>
        /// 投射到屏幕上的光线击中物体的世界空间法线
        /// </summary>
        [Obsolete("使用pointerCurrentRaycast.worldNormal或pointerPressRaycast.worldNormal")]
        public Vector3 worldNormal { get; set; }
        /// <summary>
        /// 上次发送单击事件的时间。用于双击
        /// </summary>
        public float clickTime { get; set; }

    }
}