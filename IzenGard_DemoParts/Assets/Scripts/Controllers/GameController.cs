using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        // This is Test-controller!
        private List<BaseUnit> _baseUnits;
        private List<UnitMove> _baseUnitMoves;
        private List<UnitAnimation> _baseUnitAnimations;

        private void Awake()
        {
            _baseUnits = new List<BaseUnit>();
        }

        private void Start()
        {
            _baseUnitMoves = GetComponentsInChildren<UnitMove>().ToList();
            _baseUnitAnimations = GetComponentsInChildren<UnitAnimation>().ToList();
           foreach (var view in _baseUnitMoves)
           {
               _baseUnits.Add(new BaseUnit());
               view.AtThePosition += GiveCommand;
           }
        }

        private void Update()
        {
            foreach (var view in _baseUnitMoves)
            {
                if (view.navMeshAgent.remainingDistance < 1)
                {
                    view.AtThePosition?.Invoke(view);
                }
            }
        }

        private void OnDestroy()
        {
            foreach (var view in _baseUnitMoves)
            {
                view.AtThePosition -= GiveCommand;
            }
        }
        
        
        private void GiveCommand(UnitMove view)
        {
            view.pointWhereToGo = new Vector3(Random.Range(-6.0f, 6.0f),0,Random.Range(-6.0f, 6.0f));
            view.SetThePointWhereToGo();
        }
    }
}