using System;
using UnityEngine;
namespace Holojam
{
	public class ObjectController : MonoBehaviour
	{
		public string label;

		[HideInInspector]
        public MasterStream mStream;

		public void Start ()
		{
            mStream = MasterStream.Instance;
		}
		public void Update() {
			Vector3 position = mStream.getLiveObjectPosition(label);
			Quaternion rotation = mStream.getLiveObjectRotation(label);
			
			SetBodyData(position, rotation);
		}
		public virtual void SetBodyData(Vector3 pos, Quaternion rot) {
			if (!pos.Equals(Vector3.zero)) this.transform.localPosition = pos;
			if (!rot.Equals(Quaternion.identity)) this.transform.localRotation = rot;
		}
	}
}