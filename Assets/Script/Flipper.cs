using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Flipper : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressPosition =45f;
    public float flipperDamper = 150f;
    public float hitStrenght = 10000f;
    HingeJoint joint;

    public string inputName;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint>();
        joint.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
        
        if (Input.GetAxis(inputName) == 1)
            spring.targetPosition = pressPosition;
        else
            spring.targetPosition = restPosition;
        joint.spring = spring;
        joint.useLimits = true;
        joint.useLimits = true;
    }
}
