using UnityEngine;

public class Rotaor : MonoBehaviour
{

  
        public float rotationSpeed = 60f;

        void Update()
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
}
    // Start is called before the first frame update

    
