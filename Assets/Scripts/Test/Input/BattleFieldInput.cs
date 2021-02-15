using UnityEngine;
using UnityEngine.EventSystems;

public class BattleFieldInput : InputTestBase, IDragHandler
{
	public void OnDrag(PointerEventData data)
	{
		Debug.Log(data.delta.x);
		targetTransform.position += new Vector3(data.delta.x * 0.01f, data.delta.y * 0.01f, 0f);
	}
}
