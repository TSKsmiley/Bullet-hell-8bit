using UnityEngine;

namespace DefaultNamespace
{
    public class MoveBG : MonoBehaviour
    {
        public Transform tf;
        void FixedUpdate()
        {
            tf.Translate(Vector3.up * -.05f);
        }
    }
}