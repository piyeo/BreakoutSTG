using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField]
    GameObject objInstance = null;
    GameObject objPlayer = null;

    public float objPlayerWidth { get; private set; }
    public float objPlayerHeight { get; private set; }
    public float objTouchFieldHeight { get; private set; }

    public void Create()
    {
        Instantiate(objInstance,this.transform);
        objPlayer = this.transform.GetChild(0).Find("Player").gameObject;
        objPlayer.GetComponentInChildren<ActorBase>().Init();

        var objSize = objPlayer.transform.Find("Size").gameObject;
        objPlayerWidth = objSize.GetComponent<SpriteRenderer>().bounds.size.x;
        objPlayerHeight = objSize.GetComponent<SpriteRenderer>().bounds.size.y;
        var objTouchField = this.transform.GetChild(0).Find("TouchField").gameObject;
        objTouchFieldHeight = objTouchField.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    public GameObject GetCreatedPlayer()
    {
        return objPlayer;
    }
}
