﻿using System.Collections.Generic;
using UnityEngine;

public class DockController : MonoBehaviour {
    public int spawnAmount;
    public GameObject[] passengerTemplates;
    public PassengerQueue queue;
    public Transform[] spawnAreas;

    private EmbarkPassenger boarder;
    private readonly List<Passenger> passengers = new List<Passenger>();

    /// <summary>
    /// Generates a random destination on the attached nav mesh
    /// </summary>
    /// <returns>Vector3</returns>
    private Vector3 RandomDestination() {
        Transform area = spawnAreas[Random.Range(0, spawnAreas.Length)];
        return area.position + area.rotation * new Vector3(
            Random.Range(-0.5f, 0.5f) * area.localScale.x,
            passengerTemplates[0].transform.localScale.y,
            Random.Range(-0.5f, 0.5f) * area.localScale.z);
    }

    private void Start() {
        boarder = GameObject.FindGameObjectWithTag("Player").GetComponent<EmbarkPassenger>();
        queue = GetComponentInChildren<PassengerQueue>();

        for (int i = 0; i < spawnAmount; i++) {
            GameObject instance = Instantiate(
                original: passengerTemplates[Random.Range(0, passengerTemplates.Length)],
                position: RandomDestination(),
                rotation: Quaternion.identity);
            IncomingPassenger(instance.GetComponent<Passenger>());
        }
    }

    void Update() {
        foreach (Passenger passenger in passengers) {
            if (!passenger.IsBusy) {
                passenger.SetDestination(RandomDestination(), Random.Range(15, 30));
            }
        }
    }

    public void MoveToQueue(bool instant = false) {
        if (passengers.Count == 0) return;

        Passenger passenger = passengers[0];
        queue.Enqueue(passenger);
        passengers.RemoveAt(0);

        if (instant) passenger.MoveToDestination();
    }

    public void EmbarkAll(bool instant = false) {
        while (queue.Count > 0 && boarder.CanEmbarkFrom(this)) {
            Passenger passenger = queue.Dequeue();
            boarder.Embark(passenger);

            if (instant) passenger.MoveToDestination();
        }
    }

    public void IncomingPassenger(Passenger passenger) {
        passenger.transform.SetParent(transform);
        passenger.SetDestination(RandomDestination());
        passengers.Add(passenger);
    }
}