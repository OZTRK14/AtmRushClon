using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyGate : MonoBehaviour
{
    public Material[] AltinMaterial;
    public Material[] elmasMaterial;
   
   
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            other.tag = "AltýnCollected";
            MeshRenderer temp = other.GetComponent<MeshRenderer>();




            temp.materials = AltinMaterial;
        }
        else if (other.CompareTag("AltýnCollected"))
        {
            other.tag = "ElmasCollected";
            MeshRenderer temp = other.GetComponent<MeshRenderer>();
            temp.materials = elmasMaterial;
        }
        //var AllMoneys = Collect.instance.moneylist;
        //float TimePos = 0;
        //Sequence sequence = DOTween.Sequence();
        //for (int i = 1; i < AllMoneys.Count; i++)
        //{

        //    var x = i;
        //    if (AllMoneys.Count - 1-x>= 1)
        //    {
        //        Tween z = AllMoneys[AllMoneys.Count - 1-x ].transform.DOScale(1.2f, .1f);
        //        Tween y = AllMoneys[AllMoneys.Count - 1-x ].transform.DOScale(1f, .1f).SetDelay(0.8f);


        //        sequence.Insert(TimePos, z).Insert(TimePos + .1f, y);
        //        TimePos += 0.08f;
        //    }

        //}
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
