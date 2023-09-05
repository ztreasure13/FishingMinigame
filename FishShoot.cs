using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShoot : MonoBehaviour
{
    public AudioClip throwSound;
    public Rigidbody fishPrefab;
    public float fishSpeed = 15.0f;
    float fishTimer;
    float fishFlyTime;

    // Start is called before the first frame update
    void Start()
    {
        fishTimer = 0.0f;
        fishFlyTime = Random.Range(2.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        fishTimer += Time.deltaTime;
        if (fishTimer > fishFlyTime)
        {//start if 2
            Rigidbody newFish = Instantiate(fishPrefab, transform.position, transform.rotation) as Rigidbody;
            newFish.name = "Fish";//Naming fish
            newFish.velocity = transform.forward * fishSpeed;
            AudioSource.PlayClipAtPoint(throwSound, transform.position);
            fishFlyTime = Random.Range(2.0f, 5.0f);
            fishTimer = 0.0f;
        }//end if 2
    }
}
