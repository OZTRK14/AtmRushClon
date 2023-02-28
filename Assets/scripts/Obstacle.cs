using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle : MonoBehaviour
{
    public Transform Obstcle;
    public Collect Ca;
    public Movement Movement;






    private void OnTriggerEnter(Collider other)
    {

        print("sdfghjk");


        if (other.CompareTag("Collected")||other.CompareTag("AltýnCollected"))
        {
            int a = Collect.instance.moneylist.IndexOf(other.transform);
            int b = Ca.moneylist.Count;
            for (int i = a; i < b; i++)
            {
                if (i >= 1 && other.CompareTag("Collected"))
                {
                    var x = Ca.moneylist[Ca.moneylist.Count - 1];
                    x.tag = "Collect";
                    Ca.moneylist.Remove(x);

                    x.transform.SetParent(null);
                    x.GetComponent<MoneyTrigger>().Test = false;

                    Vector3 obsTransform = Obstcle.transform.position;
                    obsTransform.x = Random.Range(-3f, 3f);
                    x.transform.DOJump(obsTransform + new Vector3(0, 0, Random.Range(8, 20)), .3f, 1, 1f).OnComplete(() =>
                    {

                        print("ssss");
                        x.GetComponent<MoneyTrigger>().Test = true;
                    });
                }
                if (i >= 1 && other.CompareTag("AltýnCollected"))
                {
                    var x = Ca.moneylist[Ca.moneylist.Count - 1];
                    x.tag = "AltýnCollect";
                    Ca.moneylist.Remove(x);

                    x.transform.SetParent(null);
                    x.GetComponent<MoneyTrigger>().Test = false;

                    Vector3 obsTransform = Obstcle.transform.position;
                    obsTransform.x = Random.Range(-3f, 3f);
                    x.transform.DOJump(obsTransform + new Vector3(0, 0, Random.Range(8, 20)), .3f, 1, 1f).OnComplete(() =>
                    {

                        print("ssss");
                        x.GetComponent<MoneyTrigger>().Test = true;
                    });
                }



            }
            Collect.instance.Check();






        }
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Crash());
            other.transform.DOMove(other.transform.position - new Vector3(0, 0, 5), 1).SetEase(Ease.OutBounce);
        }
    }

    IEnumerator Crash()
    {
        Movement.Speed = 0;
        yield return new WaitForSeconds(1.2f);
        Movement.Speed = 8f;
    }









}

