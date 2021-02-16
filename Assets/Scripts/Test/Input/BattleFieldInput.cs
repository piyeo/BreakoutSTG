using UnityEngine;
using UnityEngine.EventSystems;

public class BattleFieldInput : InputTestBase, IDragHandler
{
    public ActorBase player;
    void Start()
    {
    }
    public void OnDrag(PointerEventData data)
	{
		player.AddPosition(new Vector3(data.delta.x * 0.01f, data.delta.y * 0.01f, 0f));
	}
}
