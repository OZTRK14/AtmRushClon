using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointWall : MonoBehaviour
{
    BoxCollider bc;
   public Collider Player;
   public bool Test = false;
    public UnityEngine.UI.Button btn;

    public Animator ar;
    int level;
    public float LerpSpeed;

    private void Start()
    {
        LerpSpeed = 10f;
    }
    private void Update()
    {
        level = Collect.instance.Sayac / 10;

        if (Test ==true)
        {
           //* Debug.Log("test baþarýlý");
            Player.transform.rotation = new Quaternion(transform.rotation.x, 180, transform.rotation.z, transform.rotation.w);
            Vector3 temp = Player.transform.position;           
           //* Debug.Log("temp :" + temp.y);
            temp.y = Mathf.MoveTowards(Player.transform.position.y, level, LerpSpeed*Time.deltaTime );
           //* Debug.Log("speed" + LerpSpeed);
            Player.transform.position = temp;
            //*Debug.Log("player transform position:" + temp);
            if(Player.transform.position.y==level&&level>2)               
            {
                btn.gameObject.SetActive(true);
                Debug.Log("Tebrikler");
                

            }
            else if (Player.transform.position.y==level&&level<2)
            {
                btn.gameObject.SetActive(true);
                Debug.Log("Tekrar deneyin");
             
            }

        }




    }
    private void  OnTriggerEnter (Collider player)
    {
        Test = true;
       

        ar = player.GetComponent<Animator>();
        player.GetComponent<BoxCollider>().isTrigger = false;
       //*other.transform.position = new Vector3(transform.position.x, level, transform.position.z-1f);
        
       
       

        Destroy(player.GetComponent<Movement>());
        ar.SetBool("run", false);
       

    }


  

    

    
   

}




