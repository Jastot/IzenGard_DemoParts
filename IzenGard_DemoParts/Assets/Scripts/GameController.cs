using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        private List<BaseUnit> _baseUnits;
        private List<BaseUnitView> _baseUnitViews;

        private void Awake()
        {
            _baseUnits = new List<BaseUnit>();
        }

        private void Start()
        {
            _baseUnitViews = GetComponentsInChildren<BaseUnitView>().ToList();
           foreach (var view in _baseUnitViews)
           {
               _baseUnits.Add(new BaseUnit());
               view.AtThePosition += GiveCommand;
           }
        }

        private void Update()
        {
            foreach (var view in _baseUnitViews)
            {
                if (view.navMeshAgent.remainingDistance < 1)
                {
                    view.AtThePosition?.Invoke(view);
                }
            }
        }

        private void OnDestroy()
        {
            foreach (var view in _baseUnitViews)
            {
                view.AtThePosition -= GiveCommand;
            }
        }
        
        
        private void GiveCommand(BaseUnitView view)
        {
            view.pointWhereToGo = new Vector3(Random.Range(-6.0f, 6.0f),0,Random.Range(-6.0f, 6.0f));
            view.SetThePointWhereToGo();
        }
    }
}