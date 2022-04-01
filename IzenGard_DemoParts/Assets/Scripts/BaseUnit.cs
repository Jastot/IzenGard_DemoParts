using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.AI;

public class BaseUnit
{
    // model for future
    public virtual void SetStateMachine(UnitStates unitStates)
    {
        switch (unitStates)
        {
            case UnitStates.IDLE:
                //Anim state, looking for target, waiting destination
                break;
            
            case UnitStates.MOVING:
                //AnimState
                break;
            
            case UnitStates.DEAD:
                //AnimeState, destroy
                break;
        }
    }
    
    
}
