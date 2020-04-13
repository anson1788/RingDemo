using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionController : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        //Debug.Log("Hello: " + mesh.mesh.bounds.size.x);
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            anim.Play("InboundOut");
           /*
            boneTransform.localScale = new Vector3(boneTransform.localScale.x, boneTransform.localScale.y+0.1f, boneTransform.localScale.z-0.06f);
            RCube.transform.position= new Vector3(RCube.transform.position.x+0.1f, RCube.transform.position.y, RCube.transform.position.z);
            LCube.transform.position= new Vector3(LCube.transform.position.x-0.1f, LCube.transform.position.y, LCube.transform.position.z);
            */
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            anim.Play("Inbound");
           // float dis= sphere.transform.localScale.z*0.001f;
           /*
            boneTransform.localScale = new Vector3(boneTransform.localScale.x, boneTransform.localScale.y-0.1f, boneTransform.localScale.z+0.06f);
            RCube.transform.position= new Vector3(RCube.transform.position.x-0.1f, RCube.transform.position.y, RCube.transform.position.z);
            LCube.transform.position= new Vector3(LCube.transform.position.x+0.1f, LCube.transform.position.y, LCube.transform.position.z);
           */
        }
    }
}
