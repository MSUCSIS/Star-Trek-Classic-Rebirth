using UnityEngine;
using System.Collections;

public class PhaserShoot : MonoBehaviour
{
    
    public Transform Phasers1;
    public Transform target;
    public LineRenderer lineRenderer;

    //DPS = Damage per shot, TBS = time between shot
    public int DPS = 10;
    float TBS = 1.0f;
    public float range = 100f;
    
    
    public Transform beamHitFXPrefab;

    //initilization
    void start()
        {
               
        }

    void Update()
        {
            /*if(target == null)
                {
                    lineRenderer.enabled = false;
                    return;
                }*/
        lineRenderer.enabled = true;

        /*if (!IsWithinRange())
            return;
            */
        }

    /* void Update()
         {
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;

         if (Physics.Raycast(ray, out hit, 100))
             Debug.DrawLine(ray.origin, hit.point);
         }
         */
}
