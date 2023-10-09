using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurePatientsQuestStep : QuestStep
{
    // TODO: Connect to patients being cured script
    private int patientsCured = 0;
    private int patientsToCure = 5;

    private void OnEnable() {
        GameEventsManager.instance.miscEvents.onPatientCured += PatientCured;
    }

    private void OnDisable() {
        GameEventsManager.instance.miscEvents.onPatientCured -= PatientCured;
    }

    private void PatientCured(){
        if (patientsCured < patientsToCure) patientsCured++;

        if (patientsCured >= patientsToCure) FinishQuestStep();
    }
}
