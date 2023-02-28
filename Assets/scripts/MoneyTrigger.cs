using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyTrigger : MonoBehaviour
{
    public Collect Collectsc;
    public float BorderPositive = 3.2f;
    public float BorderNegative = -3.2f;
    public bool Test=true;

    private void Start()
    {
        Test = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collect") && Test == true)
        {
            
            

            other.transform.tag = "Collected";
            MakeAllMoneyScale();

            other.transform.parent = Collectsc.CollectOb;
            Collectsc.Check();
            
            Collect.instance.moneylist.Add(other.transform);
            

        }
        if (other.CompareTag("AltýnCollect") && Test == true)
        {



            other.transform.tag = "AltýnCollected";
            MakeAllMoneyScale();

            other.transform.parent = Collectsc.CollectOb;
            Collectsc.Check();

            Collect.instance.moneylist.Add(other.transform);


        }
        if(other.CompareTag("Band"))
        {
            transform.SetParent(null);
            transform.DOMoveX(transform.position.x - 10, 1);
            transform.DOMoveZ(transform.position.z +2, 1);
        }


    }

    public void MakeAllMoneyScale()
    {
        var AllMoneys =Collectsc.moneylist;
        float TimePos = 0;
        Sequence sequence = DOTween.Sequence();
        for (int i = 1; i < AllMoneys.Count; i++)
        {
            
                var x = i;
            if (AllMoneys.Count - 1 - x >=1) {
                Tween z = AllMoneys[AllMoneys.Count - 1 - x].transform.DOScale(1.2f, .1f);
                Tween y = AllMoneys[AllMoneys.Count - 1 - x].transform.DOScale(1f, .1f).SetDelay(0.02f);


                sequence.Insert(TimePos, z).Insert(TimePos + .1f, y);
                TimePos += 0.04f;
            }
            
        }
    }
}
