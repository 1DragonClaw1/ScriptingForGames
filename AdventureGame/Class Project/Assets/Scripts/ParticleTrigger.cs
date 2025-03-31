using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class ParticleTrigger : MonoBehaviour
{
    private ParticleSystem particleSystem; // Reference the particle system

    public int firstEmissionAmount = 10; // Exposed variable for first emission
    public int secondEmissionAmount = 20; // Exposed variable for second emission
    public int thirdEmissionAmount = 30; // Exposed variable for third emission
    public float delasyBetweenEmissions = 0.5f; // Delay time between the emissions

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if player triggered the event
        {
            StartCoroutine(EmitParticlesCoroutine()); 
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        // Frist emission
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(delasyBetweenEmissions);

        // Second emission
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delasyBetweenEmissions);

        // Third emission
        particleSystem.Emit(thirdEmissionAmount);
    }
}
