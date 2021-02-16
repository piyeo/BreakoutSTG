using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerManager : ActorManager
{
    [SerializeField]
    private PlayerFactory factory;

    [SerializeField]
    private Vector3 spawnPosition = Vector3.zero;

    public void Awake()
    {
        this.factory.Create();
        this.addActor();
        this.SetUp(spawnPosition);
    }

    public override void addActor()
    {
        actors.Add(factory.GetObjPlayer().GetComponent<ActorBase>());
    }

    //攻撃
    //移動
    //衝突
    //死亡
}
