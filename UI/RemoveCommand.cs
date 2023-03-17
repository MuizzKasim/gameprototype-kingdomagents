using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCommand : MonoBehaviour {

    public UI ui;

    private void Start()
    {
        ui = GameObject.Find("GameManager").GetComponent<UI>();
    }
    public void Remove()
    {
        //These features are not ready yet
        ui.RemoveCommand();
        Destroy(gameObject);
    }
}
