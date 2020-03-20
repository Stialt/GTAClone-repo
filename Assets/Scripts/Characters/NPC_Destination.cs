using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Destination : MonoBehaviour
{

    public int trigNum = 0;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            //Debug.Log("BLABLA, trigNum is " + trigNum);

            if (trigNum == 0)
            {
                int x = -40, y = 5, z = -8;
                //Debug.Log("New coords are: " + x + ", " + y + ", " + z + ".");

                this.gameObject.transform.localPosition = new Vector3(x,y,z);
                trigNum = 1;
            }
            else if (trigNum == 1)
            {
                this.gameObject.transform.localPosition = new Vector3(-40, 5, 69);
                trigNum = 2;
            }
            else if (trigNum == 2)
            {
                this.gameObject.transform.localPosition = new Vector3(21, 5, 70);
                trigNum = 3;
            }
            else if (trigNum == 3)
            {
                this.gameObject.transform.localPosition = new Vector3(21, 5, -9);
                trigNum = 0;
            }
        }

    }
}
