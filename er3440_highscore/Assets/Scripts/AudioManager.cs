using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //the static instance that holds the sole object of this Singleton
    public static AudioManager audioInstance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //check to see if someone has set the instance
        if (audioInstance == null)
        {
            //if they haven't this is the instance
            audioInstance = this;
            //and keep it around in other scenes
            DontDestroyOnLoad(this);
        }
        else //otherwise, if there is an existing instance
        {
            //destroy the new instance that was just created
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

