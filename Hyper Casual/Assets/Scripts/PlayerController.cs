using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float angle = 0;
    int zSpeed = 2;

    private Rigidbody rb;

    public GameObject panel;
    public GameObject effect;

    public RipplePostProcessor Ripple;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        Vector3 pos = transform.position;
        pos.z = Mathf.Cos(angle) * 5;
        pos.y = 0;
        transform.position = pos;
        angle += Time.deltaTime * zSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            zSpeed *= -1;
        }
    }

    private void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Obstacle")
        {
            Ripple.Rıpple();

            Time.timeScale = 0f;

            panel.SetActive(true);
        }
    }
}
