# Jump

This component adds jump functionality to any object with a rigidbody component.

## Setup

Attach the jump script to any object and drag the rigidbody component of the object you want to jump into the physics slot.

## Configuration

Set the force of the jump you require in the `force` slot. The units are in Newtons (assuming that your world is modelled in metres and you weights are in kilograms.)

## How to trigger

Send the message `DoJump` to the object with the `Jump` script on it to make it jump.
