using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class ObjectPooler<T> where T :  MonoBehaviour, IPooledObject
{
 
    public List<T> PooledObjects = new List<T>();
    T sample;
    public ObjectPooler(T sample, int amountToPool)
    {
        this.sample = sample;
 
        for(int i=0; i< amountToPool; i++)
        {
            PooledObjects.Add(Create());
        }
    }
    
    public T Create()
    {
        T tempGameObject = GameObject.Instantiate(sample);
        
        return tempGameObject;
    }

    public T GetPooledObject()
    {
        T result = PooledObjects.Where(i => i.IsTaken == false).FirstOrDefault();
        return result;
    }
 
    public void AddPooledObject()
    {
        PooledObjects.Add(Create());
    }
}
