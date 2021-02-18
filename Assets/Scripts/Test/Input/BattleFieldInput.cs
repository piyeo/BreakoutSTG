using UnityEngine;
using UnityEngine.EventSystems;

public class BattleFieldInput : InputTestBase, IDragHandler
{
    private PlayerManager playerManager;

    void Start()
    {
        playerManager = transform.root.gameObject.GetComponent<PlayerManager>();
    }
    public void OnDrag(PointerEventData data)
	{
		playerManager.Move(data.delta.x * 0.01f, data.delta.y * 0.01f);
	}
}
