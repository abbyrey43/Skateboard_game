
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skateboard : MonoBehaviour {
    private static Vector3 position;
    public Transform hazard;
public Transform obstacle;
public Transform[] manyHazards;
public Vector3 playerStart;
   

    void Start()
{

}
   
void Update()
{
        
            Vector3 newPos = skateboard.position;



            if (Input.GetKeyDown(KeyCode.W))
            {

                transform.position += new Vector3(0f, 0f, 1f);

                newPos += new Vector3(0f, 0f, 1f);

            }


            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0f, 0f, -1f);
                newPos += new Vector3(0f, 0f, -1f);
            }


            if (hazard.position == transform.position)
                if (Input.GetKeyDown(KeyCode.A))
                {
                    newPos += new Vector3(-1f, 0f, 0f);
                }
            if (Input.GetKeyDown(KeyCode.D))
            {
                newPos += new Vector3(1f, 0f, 0f);
            }

            if (obstacle.position != newPos)
            {
                transform.position = newPos;
            }

            for (int i = 0; i < manyHazards.Length; i++) { 
            transform.position = playerStart; 
            if (manyHazards[i].position == transform.position) 
            { 
                transform.position = playerStart; 
            }
        }
    }
}