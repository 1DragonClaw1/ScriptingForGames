using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class ParticleTrigger : MonoBehaviour
{
    private ParticleSystem particleSystem; // Reference the particle system
    public int particleAmount = 10; // Exposed variable for particle amount

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if player triggered the event
        {
            particleSystem.Emit(particleAmount); //Emit the specified amount of particles
        }
    }
}
