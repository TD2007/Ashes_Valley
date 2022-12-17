using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : Interactable
{
    // Start is called before the first frame update
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp() {
        Debug.Log("Picking up");
        Destroy(gameObject);
    }


}
