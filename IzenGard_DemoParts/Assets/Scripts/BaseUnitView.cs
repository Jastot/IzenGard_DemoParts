using System;
using UnityEngine;
using UnityEngine.AI;

namespace DefaultNamespace
{
    public class BaseUnitView: MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _navMeshAgent;
        [NonSerialized] public Vector3 pointWhereToGo;
        public NavMeshAgent navMeshAgent => _navMeshAgent;
        public Action<BaseUnitView> AtThePosition = delegate {};

        public void SetThePointWhereToGo()
        {
            _navMeshAgent.SetDestination(pointWhereToGo);
        }
    }
}