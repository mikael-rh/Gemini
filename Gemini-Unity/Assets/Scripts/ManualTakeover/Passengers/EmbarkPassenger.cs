﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EmbarkPassenger : MonoBehaviour {
    public Vector3[] seats;

    private List<Passenger> passengers = new List<Passenger>();
    private FerryTrip ferryTrip;

    private void Start() {
        ferryTrip = GetComponent<FerryTrip>();
        ferryTrip.OnPlay.AddListener(() => { 
            foreach (Passenger passenger in passengers) {
                passenger.agent.enabled = false;
            }
        });
        ferryTrip.OnEndReached.AddListener(DisembarkAll);
    }

    private void Update() {
        if (ferryTrip.ferry.boarding) {
            bool boardingCompleted = true;
            foreach (Passenger passenger in passengers) {
                if (!passenger.ReachedDestination) {
                    boardingCompleted = false;
                    break;
                }
            }
            ferryTrip.ferry.boarding = !boardingCompleted;
        }
    }

    public bool CanEmbarkFrom(DockController dock) {
        return passengers.Count < seats.Length && !ferryTrip.Playing && ferryTrip.ferry.dock.Equals(dock);
    }

    public void Embark(Passenger passenger) {
        int seatIndex = passengers.Count;
        if (ferryTrip.reverse) seatIndex = seats.Length - seatIndex - 1;

        passenger.transform.SetParent(transform);
        passenger.SetDestination(transform.position + transform.rotation * seats[seatIndex]);
        passengers.Add(passenger);

        ferryTrip.ferry.boarding = true;
    }

    private void DisembarkAll() {
        if (ferryTrip.ferry.dock == null) return;

        foreach (Passenger passenger in passengers) {
            passenger.agent.enabled = true;
            ferryTrip.ferry.dock.IncomingPassenger(passenger);
        }
        passengers.Clear();
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.white;
        foreach (Vector3 seat in seats) {
            Gizmos.DrawSphere(transform.position + transform.rotation * seat, 0.5f);
        }
    }
}
