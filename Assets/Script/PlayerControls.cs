using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public float Speed;
    private Rigidbody2D _rigidbody;
    public Borders _borders;
    public GameObject Shot;
    public Transform SpawnShotPoint;
    public float firerate;
    private float nextfire;
    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            Instantiate(Shot, new Vector3(SpawnShotPoint.position.x, SpawnShotPoint.position.y, 0),
            Quaternion.Euler(0, 0, 0));     
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical, 0f);
        transform.position += direction * Speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, _borders.minx, _borders.maxx),
        Mathf.Clamp(transform.position.y, _borders.miny,_borders.maxy),transform.position.z);
       

    }
    [System.Serializable]
    public class Borders
    {
        public float miny, maxy, minx, maxx;
    }
}
