using UnityEngine;
using UnityEngine.EventSystems;

namespace UniSimpleProfiler.Internal
{
    /// <summary>
    /// UI をドラッグできるようにするコンポーネント
    /// A component that allows you to drag
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class Dragable : MonoBehaviour, IDragHandler
    {
        //====================================================================================
        // 変数(SerializeField)
        // variable
        //====================================================================================
        [SerializeField, HideInInspector]
        private RectTransform m_rectTransform = null;

        //====================================================================================
        // 関数 function
        //====================================================================================
        /// <summary>
        /// リセットされる時に呼び出されます
        /// Called when reset
        /// </summary>
        private void Reset()
        {
            m_rectTransform = GetComponent<RectTransform>();
        }

        /// <summary>
        /// ドラッグ中に呼び出されます
        /// Called while dragging
        /// </summary>
        public void OnDrag(PointerEventData e)
        {
            m_rectTransform.position += new Vector3(e.delta.x, e.delta.y, 0f);
        }
    }
}
