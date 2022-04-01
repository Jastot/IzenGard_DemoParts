using System;
using UnityEngine;
using UnityEngine.AI;

namespace DefaultNamespace
{
    public class UnitMove: MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _navMeshAgent;
        [NonSerialized] public Vector3 pointWhereToGo;
        public NavMeshAgent navMeshAgent => _navMeshAgent;
        public Action<UnitMove> AtThePosition = delegate {};//will be delete (only for test)

        public void SetThePointWhereToGo()
        {
            _navMeshAgent.SetDestination(pointWhereToGo);
        }
    }
}