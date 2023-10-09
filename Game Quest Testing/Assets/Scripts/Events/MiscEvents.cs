using System;

public class MiscEvents
{
    public event Action onPatientCured;

    public void PatientCured(){
        if (onPatientCured != null) onPatientCured();
    }

    // ? Can be adjusted for more events
}
