// Combustion on mouse click -- change event if needed // Fire effect used from Cosyio at www.youtube.com/watch?v=JTGv_maOyHk  // INSTRUCTIONS: // - Drop script onto combustible object  // - Drop "Combustion" prefab in "Particles" section of the script  // This script inherits behaviour from Break script and all Break functions and variables (except private) are visible to it    using System.Collections; using System.Collections.Generic; using UnityEngine;  public class Combust : Break {      public bool eternalBurn = false;     public float temperature;     public float maxTemperature;     public float conductiveness;     public ParticleSystem particles; // Reference to particle system     public bool spontaniousBurn = false;      // burn function describes basic behaviour of a burning object     //public GameObject buoyancy = GameObject.getCom     public buoyancy buoyancy;     public GameObject fire;      public void Start()
    {
        if (spontaniousBurn) burn();         fire = GameObject.Find("combustion");         fire.SetActive(false);  
    }      public void burn()     {
        // Where the flame particle system will be displayed
        //Vector3 combustionPos = transform.position;
        fire.SetActive(true);
        Vector3 combustionPos = new Vector3(0, 0, 0);         buoyancy = GetComponent<buoyancy>();         GameObject particle = Instantiate(particles.gameObject);         //print(particle.transform.position);         //fire = GameObject.Find("combustion");         //Vector3 particlePos = GameObject.Find("combustion").transform.position;         //fire = GameObject.Find("combustion");          //particle.transform.position = transform.position;         particle.transform.position = combustionPos;          if (buoyancy != null && (!buoyancy.isSubmerged || buoyancy == null))         {             if (!eternalBurn && temperature >= maxTemperature)             {                 Destroy(particle, 6);                  Invoke("explode", 5);             }              if (temperature < maxTemperature)             {                 temperature += 1 * conductiveness;             }

            //When the temperature gets above 5, the object receives tag "Burning"
            if (temperature > 5)             {                 gameObject.tag = "Burning";             }         }       } 

    // Combustible object gets on fire on collision with a burning object
    // the heat transfer is dependant of how conductive the object is
    public void OnCollisionEnter(Collision other)     {         if (other.gameObject.CompareTag("Burning"))         {             this.temperature += 10 * this.conductiveness;             burn();         }          if (other.gameObject.CompareTag("ActivePlayer"))
        {
            print("fireburning");             if (Input.GetKeyDown(KeyCode.U))
            {
                burn();
            }
        }     }

    // Combustible object gets on fire staying in contact with a burning object
    public void OnTriggerStay(Collider other)     {         if (Vector3.Distance(other.transform.position, this.transform.position) < 50 && (other.gameObject.layer != LayerMask.NameToLayer("Water")))         {             burn();         }      }

    // FOR TESTING PURPOSES
    //Sets a combustible object on fire when its temperature gets abpve 5
    // temperature increases by 1 on each mouse click
    private void OnMouseDown()     {         print("clicked");         if (!buoyancy.isSubmerged)         {             temperature += 1;         }         if (temperature > 5)         {             burn();         }     }  } 