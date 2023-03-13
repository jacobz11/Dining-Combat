using Assets.Scripts.Player.PickUpItem;
using System.Collections;
using UnityEngine;

public class AiThrew :ThrowingGameObj
{
    private GameObject m_FoodToThrow;

    [SerializeField]
    [Range(0.5f, 5f)]
    public float m_TimeToThrew;
    [SerializeField]
    private GameManager m_GameManager;
    [SerializeField]
    private GameObject m_Pleyer;
    [SerializeField]
    [Range(50f, 9000f)]
    private float m_ForceMulti;

    public override float ForceMulti 
    { 
        get => m_ForceMulti;
        set => m_ForceMulti = value;
    }

    void Update()
    {
        if (m_FoodToThrow == null)
        {
            SetGameFoodObj(m_GameManager.SpawnGameFoodObj());
            StartCoroutine(ShotAtThePlayer());
        }
    }

    private Vector3 calaV3()
    {
        Vector3 v = m_Pleyer.gameObject.transform.position - this.gameObject.transform.position;
        Debug.DrawRay(this.gameObject.transform.position, v, Color.red, 5);

        return v;
    }

    public IEnumerator ShotAtThePlayer()
    {
        yield return new WaitForSeconds(m_TimeToThrew);
        ThrowObj();
    }

    internal override void SetGameFoodObj(GameObject i_GameObject)
    {
        m_FoodToThrow = i_GameObject;
        m_FoodToThrow.transform.position = transform.position - transform.forward;

        GameFoodObj obj = i_GameObject.GetComponent<GameFoodObj>();

        if (obj != null)
        {
            obj.SetHolderFoodObj(this);
        }
    }

    internal override void ThrowObj()
    {
        float lineToPleyr = Vector3.Distance(transform.position, m_Pleyer.transform.position);

        m_FoodToThrow.GetComponent<GameFoodObj>().ThrowFood(m_ForceMulti, calaV3());
        m_FoodToThrow = null;
    }

    public override Transform GetPoint()
    {
        return this.transform;
    }
}
