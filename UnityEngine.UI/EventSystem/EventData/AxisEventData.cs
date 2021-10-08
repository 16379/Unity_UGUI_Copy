namespace UnityEngine.EventSystems
{
    /// <summary>
    /// 与轴事件（控制器/键盘）关联的事件数据。
    /// </summary>
    public class AxisEventData : BaseEventData
    {
        /// <summary>
        /// 与此事件关联的原始输入向量。
        /// </summary>
        public Vector2 moveVetor { get; set; }

       public MoveDirection moveDir { get; set; }

        public AxisEventData(EventSystem eventSystem) : base(eventSystem)
        {
            moveVetor = Vector2.zero;
            moveDir = MoveDirection.None;
        }
    }
}
