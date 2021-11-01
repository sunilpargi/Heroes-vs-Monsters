﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SphericalVector {

	public float Lenght;
	public float Zenith;
	public float Azimuth;

	public SphericalVector(float azimuth, float zenith, float lenght) {
		Lenght = lenght;
		Zenith = zenith;
		Azimuth = azimuth;
	}

	public Vector3 Direction {
		get {
			Vector3 dir;

			float vertical_Angle = Zenith * Mathf.PI / 2f;
			dir.y = Mathf.Sin (vertical_Angle);
			float h = Mathf.Cos (vertical_Angle);

			float horizontal_Angle = Azimuth * Mathf.PI;
			dir.x = h * Mathf.Sin (horizontal_Angle);
			dir.z = h * Mathf.Cos (horizontal_Angle);

			return dir;
		}
	}

	public Vector3 Position {
		get {
			return Lenght * Direction;
		}
	}

} // struct











































