using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    private CapsuleCollider2D PlayerCollider;
    private GameObject Player;
   
    [SerializeField] private float defDistanceRay = 100;
    public LineRenderer m_lineRenderer;
       public Transform lazerFirePoint;
    Transform m_transform;
    MeshCollider meshCollider;
    // Start is called before the first frame update
    private void Awake()
    {
        m_transform = GetComponent<Transform>();
        
       
    }
    private void Update()
    {
        ShootLaser();

        
    }
    // Update is called once per frame
    void ShootLaser()
    {

        Player = GameObject.Find("Player");
        PlayerCollider = Player.transform.GetComponent<CapsuleCollider2D>();
        if (Physics2D.Raycast(m_transform.position, transform.right))
        {
            RaycastHit2D _hit = Physics2D.Raycast(m_transform.position, transform.right);
            Draw2DRay(lazerFirePoint.position, _hit.point);
        }
        else
        {
            Draw2DRay(lazerFirePoint.position, lazerFirePoint.transform.right * defDistanceRay);
        }
    }
    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);
    }
}
