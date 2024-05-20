using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrutivel : MonoBehaviour
{


    // Start is called before the first frame update
    public virtual void TomaDano()
    {
        //Debug.Log(name + " tomou dano");
        Kill();
    }

    public void Kill()
    {
        Destroy(gameObject);
    }

}
