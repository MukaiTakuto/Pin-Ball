using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{

    private HingeJoint myHingeJoint;
    private float defaultAngle = 20;
    private float flickAngle = -20;
    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);        
    }

    // Update is called once per frame
    void Update()
    {
  for (int i = 0; i < Input.touchCount; ++i)
  {

        if(Input.touchCount > 0)
        {
        Touch touch = Input.GetTouch(i);

        if ((touch.phase == TouchPhase.Began) &&  (Input.mousePosition.x <= Screen.width / 2) && (Input.mousePosition.x >= Screen.width / 2) && tag == "LeftFripperTag" && tag == "RightFripperTag")
                {
                    
                        SetAngle (this.flickAngle);
                }
                if ((touch.phase == TouchPhase.Ended) &&  (Input.mousePosition.x <= Screen.width / 2) &&   (Input.mousePosition.x >= Screen.width / 2) &&tag == "LeftFripperTag" && tag == "RightFripperTag")
                {
                    
                        SetAngle (this.flickAngle);
                }
                
                else{


            

        if ((touch.phase == TouchPhase.Began) &&  (Input.mousePosition.x <= Screen.width / 2) && tag == "LeftFripperTag")
                {
                    
                        SetAngle (this.flickAngle);
                }
        if ((touch.phase == TouchPhase.Began) &&  (Input.mousePosition.x >= Screen.width / 2) && tag == "RightFripperTag")
                {
                        SetAngle (this.flickAngle);
                }
        if ((touch.phase == TouchPhase.Ended) &&  (Input.mousePosition.x <= Screen.width / 2) && tag == "LeftFripperTag")
                {
                        SetAngle (this.defaultAngle);
                }
        if ((touch.phase == TouchPhase.Ended) &&  (Input.mousePosition.x <= Screen.width / 2) && tag == "RightFripperTag")
                {
                        SetAngle (this.defaultAngle);
                }
        
  }
                }
    }
    }
    public void SetAngle (float angle)
        {
                JointSpring jointSpr = this.myHingeJoint.spring;
                jointSpr.targetPosition = angle;
                this.myHingeJoint.spring = jointSpr;
        }
}


// void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.RightArrow) && tag == && tag == "LeftFripperTag")
//                 {
                    
//                         SetAngle (this.flickAngle);
//                 }
//         if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
//                 {
//                         SetAngle (this.flickAngle);
//                 }
//         if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
//                 {
//                         SetAngle (this.defaultAngle);
//                 }
//         if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
//                 {
//                         SetAngle (this.defaultAngle);
//                 }
        
//     }