using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject block1;
    [SerializeField] GameObject block2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, block1.transform.position.x, block2.transform.position.x), gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
