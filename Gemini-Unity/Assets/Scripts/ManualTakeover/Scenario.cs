using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : ExtendedMonoBehaviour {
    private const float TAKEOVER_FORCE = 20000, SHUTDOWN_TIME = 20;

    public int spawnAmount = 5, tripCount = 3;
    public float stepDelay = 5, manualTakeoverDelay = 10;

    private FerryController ferry;
    private FerryTrip trip;
    private float manualTakeoverAtTime;

    public bool Playing { get; private set; }

    private void Start() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        ferry = player.GetComponent<FerryController>();
        trip = player.GetComponent<FerryTrip>();

        trip.OnEndReached.AddListener(() => {
            Schedule(Step, stepDelay);
        });

        ferry.OnConnectToDock.AddListener(() => { 
            if (Playing && ferry.ManualControl) {
                Playing = false;
                Debug.Log("Scenario completed");
                Schedule(Application.Quit, SHUTDOWN_TIME);
                
            }
        });

        player.GetComponent<EmbarkPassenger>().OnBoardingCompleted.AddListener(trip.Play);

        Schedule(Play, 1);
    }

    public void Play() {
        if (Playing || ferry.dock == null) return;
        ferry.ManualControl = false;
        Playing = true;
        Step();

        Debug.Log("Playing scenario");
    }

    private void Step() {
        if (tripCount > 0) {
            tripCount--;
            trip.Play();

            if (tripCount == 0) manualTakeoverAtTime = Time.time + stepDelay + manualTakeoverDelay;
        }
    }

    private void Update() {
        if (!Playing) return;

        if (Input.GetKeyDown(KeyCode.G) || (!ferry.ManualControl && tripCount == 0 && Time.time > manualTakeoverAtTime)) {
            ManualTakeover();
        }
    }

    private void ManualTakeover() {
        trip.Playing = false;
        ferry.ManualControl = true;
        ferry.GetComponent<Rigidbody>().AddForce(ferry.transform.forward * TAKEOVER_FORCE);
        Debug.Log("Manual takeover");
    }
}
