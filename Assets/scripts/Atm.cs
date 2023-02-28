using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atm : MonoBehaviour

{


    public Collect Coll;




    private void OnTriggerEnter(Collider other)
    {

        int a = Coll.moneylist.IndexOf(other.transform);
        int b = Coll.moneylist.Count;
        if (other.CompareTag("Collected") || other.CompareTag("AltýnCollected") || other.CompareTag("ElmasCollected"))
        {

            for (int i = a; i < b; i++)
            {
                if (i >= 1)
                {
                    var x = Coll.moneylist[Coll.moneylist.Count - 1];
                    Collect.instance.moneylist.Remove(x);
                    Destroy(x.gameObject);

                    if (x.CompareTag("Collected"))
                    {
                        Coll.Sayac += 1;


                    }
                    else if (x.CompareTag("AltýnCollected"))
                    {
                        Coll.Sayac += +2;
                    }
                    else if (x.CompareTag("ElmasCollected"))
                    {
                        Coll.Sayac += +3;
                    }
                       

                    CanvasController.instance.MoneyText.text = " $ " + Coll.Sayac.ToString();
                    AtmCanvas.instance.AtmText.text = " $ " + Coll.Sayac.ToString();
                    Atm2Canvas.instance.Atm2Text.text = " $ " + Coll.Sayac.ToString();
                }






            }
            Debug.Log(Coll.Sayac);








        }


    }
}

