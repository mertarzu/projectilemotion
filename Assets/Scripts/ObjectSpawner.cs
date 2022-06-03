using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    ObjectPooler<Ball> objectPooler;

    [SerializeField] Ball ballPrefab;
    int amountToPool = 2;
    int additionAmountToPool = 2;
    int tempAmountToPool;
    public void Initialize()
    {
        objectPooler = new ObjectPooler<Ball>(ballPrefab, amountToPool);
        foreach (Ball obj in objectPooler.PooledObjects)
        {
            obj.gameObject.SetActive(false);
        }

    }

    public Ball Spawn()
    {
     
        Ball ball = objectPooler.GetPooledObject();

        if (ball == null && tempAmountToPool < additionAmountToPool)
        {
            objectPooler.AddPooledObject();
            ball = objectPooler.GetPooledObject();
            ++tempAmountToPool;
        }

        return ball;
           
    }

}
