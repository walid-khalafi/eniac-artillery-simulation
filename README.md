# From ENIAC to C#: Rebuilding WWII Artillery Firing Tables

**How a 30‑ton computer’s wartime mission can now run in milliseconds on a modern laptop**

---

## 📜 About the Project
In 1946, ENIAC — the world’s first general‑purpose electronic digital computer — was built to calculate artillery firing tables for the U.S. Army’s Ballistic Research Laboratory.  
These tables helped gunners determine the correct elevation and propellant charge to hit targets under varying conditions.

Back then, producing a single table could take weeks of manual calculation. ENIAC could do it in hours.  
Today, with C#, we can replicate the same ballistic computations in milliseconds — using real‑world data for a 155 mm howitzer.

---

## 🎯 Features
- Realistic muzzle velocities for different propellant charges (Charge 3, 5, 7)
- Simulation of gravity, drag, and atmospheric conditions
- Outputs range and flight time for multiple angles
- Demonstrates how historical computing problems can be solved with modern tools

---

## ⚙️ Physics Model
The program calculates projectile motion using:
- Newtonian physics
- Drag force:  
  

\[
  F_d = \frac{1}{2} \rho v^2 C_d A
  \]

## 🚀 How to Run
Clone this repository:

```csharp
git clone https://github.com/walid-khalafi/eniac-artillery-simulation.git
```
Open the project in Visual Studio or VS Code.

Compile and run:

```bash
dotnet run
```

## 📌 License
This project is released under the MIT License — feel free to use, modify, and share.


