using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(ray,out hit)){
                //print(hit.collider.gameObject.name);
                //print(hit.point);

                var clickMove = hit.collider.gameObject.GetComponent<clickMove>();

                clickMove.OnClick(hit.point);
            }
        }
    }
}
