using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : ActorManager
{
    [SerializeField]
    private PlayerFactory factory = null;
    [SerializeField]
    private Vector3 spawnPosition = Vector3.zero;

    public ActorBase player { get; protected set; }
    public PlayerBase playerOption { get; protected set; }

    public void Awake()
    {
        this.factory.Create();
        this.addActor();
        this.SetUp(spawnPosition);
    }

    public override void addActor()
    {
        var _player = factory.GetCreatedPlayer().GetComponent<ActorBase>();
        player = _player;
        actors.Add(_player);
    }

    public void Move(float _x, float _y)
    {
        Vector3 screen_LeftBottom = Camera.main.ScreenToWorldPoint(Vector3.zero);
        Vector3 screen_RightTop = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        var playerPosition = player.GetPosition();
        var playerWidth = factory.objPlayerWidth;
        var playerHeight = factory.objPlayerHeight;
        var touchFieldHeight = factory.objTouchFieldHeight;
        if (playerPosition.x < screen_LeftBottom.x + playerWidth / 2)
        {
            if (_x < 0) _x = 0;
        }
        if(playerPosition.x > screen_RightTop.x - playerWidth/2)
        {
            if (_x > 0) _x = 0;
        }
        if(playerPosition.y < screen_LeftBottom.y + playerHeight / 2)
        {
            if (_y < 0) _y = 0;
        }
        if(playerPosition.y > screen_LeftBottom.y + touchFieldHeight - playerHeight / 2)
        {
            if (_y > 0) _y = 0;
        }
        player.AddPosition(_x, _y);
    }

    public void SetTouchField()
    {
        //タッチフィールドの位置調整
    }

    //攻撃
    //移動
    //衝突
    //死亡
}
