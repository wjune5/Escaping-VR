using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableToAttach : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
   public Transform leftAttachTransform;
   public Transform rightAttachTransform;

   protected override void OnSelectEntered(SelectEnterEventArgs args) {
        if (args.interactorObject.transform.CompareTag("Left Hand")) {
            attachTransform = leftAttachTransform;
        } else if (args.interactorObject.transform.CompareTag("Right Hand")) {
            attachTransform = rightAttachTransform;
        }
        base.OnSelectEntered(args);
   }
}
