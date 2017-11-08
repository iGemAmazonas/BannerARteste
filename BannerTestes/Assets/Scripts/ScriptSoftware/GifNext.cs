using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GifNext : MonoBehaviour {
    public Animator gifAnimator;

    public void gifUp()
    {
        gifAnimator.SetTrigger("ClicUP");
    }
    public void gifDown()
    {
        gifAnimator.SetTrigger("ClicDown");
    }
    public void reloding()
    {
  
    }

}
