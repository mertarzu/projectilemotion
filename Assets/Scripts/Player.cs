using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] ObjectSpawner objectSpawner;
    [SerializeField] UIController uIController;
    [SerializeField] TargetInputController targetInputController;
    [SerializeField] Transform startTransform;
    [SerializeField] Transform finalTransform;
    bool isFinal;
    
    void  onTargetSelected(Vector3 target)
    {
        if (!isFinal)
        {
            startTransform.position = target;
            isFinal = true;
        }
        else
        {
            finalTransform.position = target;
            Ball ballItem = objectSpawner.Spawn();

            if(ballItem != null)
            {
                ballItem.ProjectileMotion(startTransform, finalTransform, uIController.MaxHeight, uIController.Time);
            }
          
            isFinal = false;
        }
      
    }


    public void Initialize()
    {
        targetInputController.OnTriggerInput = onTargetSelected;         
    }

}
