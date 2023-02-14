# Jump

This component adds jump functionality to any object with a rigidbody component.

## Setup

Attach the jump script to any object and drag the rigidbody component of the object you want to jump into the physics slot.

## How to trigger

Call the function `DoJump` on the `Jump` script to make it jump. Set the force of the jump you require in the `force` parameter. The units are in Newtons (assuming that your world is modelled in metres and you weights are in kilograms.)
