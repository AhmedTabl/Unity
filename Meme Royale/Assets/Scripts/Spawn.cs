using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private CardSelection cs;
    [SerializeField] private Camera cam;
    [SerializeField] GameObject[] prefab;

    private void Start()
    {
        cs = GetComponent<CardSelection>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

           Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {

                int sc = cs.selectedCard;
                GameObject g = Instantiate(prefab[sc]);
                g.transform.position = hit.point;
            
            }

        }
    }
}
