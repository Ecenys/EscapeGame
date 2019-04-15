using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem.Sample
{
    public class LockToPoint : MonoBehaviour
    {
		public float distance;
		public bool enabled;
		private Transform snapTo;
        public Transform snapTo1;
        public Transform snapTo2;
        public Transform snapTo3;
		
        private Rigidbody body;
        public float snapTime = 2;

        private float dropTimer;
        private Interactable interactable;
        
        private void Start()
        {
			enabled=true;
            interactable = GetComponent<Interactable>();
            body = GetComponent<Rigidbody>();
        }
        
        private void FixedUpdate()
        {
			float dist = 2000;
			float dist1 = Vector3.Distance(snapTo1.transform.position, transform.position);
			float dist2 = Vector3.Distance(snapTo2.transform.position, transform.position);
			float dist3 = Vector3.Distance(snapTo3.transform.position, transform.position);
			
			if (dist1 < dist2 && dist1 < dist3){
					snapTo = snapTo1;
					dist = dist1;
			}
			if (dist2 < dist1 && dist2 < dist3){
				snapTo = snapTo2;
				dist = dist2;
			}
			if(dist3 < dist1 && dist3 < dist2){
				snapTo = snapTo3;
				dist = dist3;
			}
					
			if (dist < distance) {enabled = true; body.isKinematic = true;}
			else {enabled = false; body.isKinematic = false;}
			
			bool used = false;
            if (interactable != null)
                used = interactable.attachedToHand;
			
			Debug.Log(used);
            if (used)
            {
                body.isKinematic = true;
                dropTimer = -1;
            }
            else
            {
				if(enabled){
					dropTimer += Time.deltaTime / (snapTime / 2);

					body.isKinematic = dropTimer > 1;

					if (dropTimer > 1)
					{
						//transform.parent = snapTo;
						transform.position = snapTo.position;
						transform.rotation = snapTo.rotation;
					}
					else
					{
						float t = Mathf.Pow(35, dropTimer);

						body.velocity = Vector3.Lerp(body.velocity, Vector3.zero, Time.fixedDeltaTime * 4);
						if (body.useGravity)
							body.AddForce(-Physics.gravity);

						transform.position = Vector3.Lerp(transform.position, snapTo.position, Time.fixedDeltaTime * t * 3);
						transform.rotation = Quaternion.Slerp(transform.rotation, snapTo.rotation, Time.fixedDeltaTime * t * 2);
					}
				}
            }
			
        }
    }
}