using DefaultNamespace;

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
