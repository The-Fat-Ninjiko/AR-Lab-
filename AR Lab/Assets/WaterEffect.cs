using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEffect : MonoBehaviour
{
    public Color color, df, target;
    public Renderer mat;
    public ParticleSystem particle;
    public GameObject particle2;
    public Transform trans;
    float timeLeft;
   
    public Vector3 v = new Vector3(0.00025f, 0.00025f, 0.00025f);
    private void OnEnable()
    {
        mat.materials[0].color = df;
        trans.localScale = v;
        particle.Play();
        if(particle2!=null)
        particle2.SetActive(true);
       
    }
    private void OnDisable()
    {
        mat.materials[0].color = df;
        particle.Stop();
    }

    // Start is called before the first frame update
    void Update() {
        if (timeLeft <= Time.deltaTime)
        {
          
            print("x");
            // transition complete
            // assign the target color

            //mat.materials[0].color = color;


            // start a new transition

            color = target;
           
            timeLeft = 8.0f;
            }
        else
        {
            print("x");
// transition in progress
// calculate interpolated color
mat.materials[0].color = Color.Lerp(mat.materials[0].color, color, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
}
