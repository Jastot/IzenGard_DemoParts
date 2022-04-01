using UnityEngine;

namespace DefaultNamespace
{
    public class UnitAnimation: MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void SetAnimationState(string animationName)
        {
            //_animator.Play(animationName);
        }
    }
}