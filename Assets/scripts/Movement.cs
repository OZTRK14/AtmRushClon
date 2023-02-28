using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    

    Rigidbody rb;
    Animator ra;
  

   //* public float hiz = 20f;
    public float Speed = 8f;
    public float BorderPositive = 3.2f;
    public float BorderNegative = -3.2f;
   
    Vector3 pos;
    
    void Start()
    {
        ra = GetComponent<Animator>();
    }


    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) *Time.deltaTime * Speed);
        if (Input.GetMouseButton(0))           
            
         {

            

            pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
            Vector3 newPos = UnityEngine.Camera.main.ScreenToWorldPoint(pos);
            transform.position = new Vector3(newPos.x, transform.position.y, transform.position.z);
          
        }
        if(Input.GetMouseButtonDown(0))
        {
            ra.SetBool("run", true);
        }
       








        #region sýnýr
        if (transform.position.x > BorderPositive)
        {
            transform.position = (new Vector3(BorderPositive, transform.position.y, transform.position.z));
        }
        if (transform.position.x < BorderNegative)
        {
            transform.position = (new Vector3(BorderNegative, transform.position.y, transform.position.z));
        }

      

    }


        #endregion

    



}


