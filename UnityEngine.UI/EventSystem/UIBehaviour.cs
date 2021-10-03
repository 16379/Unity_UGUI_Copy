namespace UnityEngine.Systems
{
    ///保护Unity生命周期功能实现的基本行为。
    public abstract class UIBehaviour : MonoBehaviour
    {
        protected virtual void Awake(){

        }
        protected virtual void OnEnable()
        {

        }
        protected virtual void Start(){

        }
        protected virtual void OnDisable(){

        }
        protected virtual void OnDestroy(){

        }
        //如果游戏对象和组件处于活动状态，则返回true。
        public virtual bool IsActive(){
            return isActiveAndEnabled;
        }
        #if UNITY_EDITOR
        protected virtual void OnValidate(){

        }
        protected virtual void Reset(){

        }
        #endif
        ///如果关联的RectTransform的维度发生更改，则调用此回调。该调用还对所有子rect变换进行调用，即使子变换本身没有改变——这可能会改变，这取决于它的锚定。
        protected virtual void OnRectTransformDimensionsChange(){

        }
        protected virtual void OnBeforeTransformParentChanged(){

        }
        protected virtual void OnTransformParentChanged(){

        }
        protected virtual void OnDidApplyAnimationProperties(){

        }
        protected virtual void OnCanvasGroupChanged(){

        }

        ///父画布的状态更改时调用
        protected virtual void OnCanvasHierarchyChanged(){

        }
        ///如果本身已经被销毁 则返回true
        ///当父画布被启用、禁用或嵌套画布的重写或更改时，将调用此函数。
        ///例如，您可以使用它来修改画布下可能依赖于父画布的对象-例如，如果画布被禁用，您可能希望停止对UI元素的某些处理。
        public bool IsDestroyed(){
            ///已销毁对象的Unity本机端的变通方法，但通过接口访问不会调用重载==
            return this == null;
        }



    }
}