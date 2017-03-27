# ODE-CS
This repository to contains a set of simple, automatically generated bindings for the [Open Dynamics Engine](https://bitbucket.org/odedevs/ode). These bindings currently target version 0.14 of the library. These bindings have been written to be as close to the C APIs as possible, so that calls require no marshalling and the original documentation can be followed. As such, you'll often have to make use of unsafe code to access the data returned by these methods.
To use these bindings, simply copy ODE.cs and nulong.cs into your project.
