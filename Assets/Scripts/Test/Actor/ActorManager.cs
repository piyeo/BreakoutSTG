using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorManager : MonoBehaviour
{
    [SerializeField]
    protected List<ActorBase> actors = new List<ActorBase>();

    public void SetUp(Vector3 _position)
    {
        for(int i=0;i < actors.Count; i++)
        {
            actors[i].WakeUp(_position);
        }
    }

    public abstract void addActor();
}
