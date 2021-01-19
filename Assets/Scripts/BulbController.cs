using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    
    public AutoSwitchController autoSwitch;
    public Animator bulbAnimator;

    // Start is called before the first frame update
    void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();
        autoSwitch = gameObject.GetComponent<AutoSwitchController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BulbLightOn()
    {

    }

    public void BulbLightOff()
    {
        
    }
}
