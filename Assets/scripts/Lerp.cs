using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public float Speed;
    [Range(0, 2)]
    public float LerpSpeed = 0.002f;
    public Transform Target;

  

    private void Update()
    {
        Vector3 te = this.transform.position;
        te.z = Target.position.z+1f;
     
        transform.position = te;
        
        for (int i = 1; i < Collect.instance.moneylist.Count; i++)
        {
            
            Vector3 temp = Collect.instance.moneylist[i].position;            
            temp.x = Mathf.Lerp(temp.x, Collect.instance.moneylist[i - 1].position.x, LerpSpeed);
            Collect.instance.moneylist[i].position = temp;
        }

       



    }

   
}
