using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collect : MonoBehaviour
{
    public int Sayac;
    public int CollectCount;
    public Transform CollectOb;
    public List<Transform> moneylist=new List<Transform>();
    public static Collect instance;

    private void Awake()
    {
        instance = this;
    }
    
    private void Start()
    {
        CollectCount = 0;
        moneylist.Add(transform);   
    }
    private void Update()
    {
       
    }
    private void   OnTriggerEnter (Collider other)
    {

            
        if (other.CompareTag("Collect") )
        
        {
            other.transform.tag = "Collected";
            other.transform.parent = CollectOb;
            moneylist.Add(other.transform); 
            Check();
        }
        if (other.CompareTag("AltýnCollect"))

        {
            other.transform.tag = "AltýnCollected";
            other.transform.parent = CollectOb;
            moneylist.Add(other.transform);
            Check();
        }

    }
     public void Check()
    {
        CollectCount = CollectOb.childCount;
        for (int i = 0; i < CollectCount; i++)
        {
            CollectOb.GetChild(i).localPosition = new Vector3(CollectOb.GetChild(i).transform.position.x, 0, i * .8f);
        }
    }
    
      
    
    
}
















































