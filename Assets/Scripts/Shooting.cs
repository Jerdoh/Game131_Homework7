using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                
                MonoBehaviour[] mono;
                mono = objectHit.gameObject.GetComponents<MonoBehaviour>();

                foreach(MonoBehaviour item in mono)
                {
                    if(item is IDamage)
                    {
                        IDamage temp = item as IDamage;
                        temp.TakeDamage();
                        return;
                    }
                    if(item is IExplode)
                    {
                        IExplode temp = item as IExplode;
                        temp.Explode();
                        return;
                    }
                }
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                MonoBehaviour[] mono;
                mono = objectHit.gameObject.GetComponents<MonoBehaviour>();

                foreach(MonoBehaviour item in mono)
                {
                    if(item is IHeal)
                    {
                        IHeal temp = item as IHeal;
                        temp.Heal();
                        return;
                    }
                }
            }
        }
    }
}
