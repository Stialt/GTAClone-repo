using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Random_Destination : MonoBehaviour
{

    public int trigNum;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            Debug.Log("Previous trigNum is " + trigNum);
            int newNum = Random.Range(0, 4);
            while(newNum == trigNum)
            {
                newNum = Random.Range(0, 4);
            }

            trigNum = newNum;

            Debug.Log("Generated number is " + trigNum);

            if (trigNum == 0)
            {
                int x = 45, y = 5, z = -9;
                this.gameObject.transform.localPosition = new Vector3(x,y,z);
            }
            else if (trigNum == 1)
            {
                this.gameObject.transform.localPosition = new Vector3(44, 5, 96);
            }
            else if (trigNum == 2)
            {
                this.gameObject.transform.localPosition = new Vector3(20, 5, 117);
            }
            else if (trigNum == 3)
            {
                this.gameObject.transform.localPosition = new Vector3(-30, 5, 96);
            }
        }

    }
}
