# Architect-Arithmetic

Made With tutorial from CodeAcademy

In this project, we will use methods to build a program that calculates the material cost for any architect’s floor plan. For example, the floor plan of the Pantheon in Rome, Italy:

Pantheon blueprint

![image](https://github.com/YehudaShani/Architect-Arithmetic/assets/99804251/a329c585-9305-447a-9b5d-56b33d33a5ba)


…can be (approximately) broken into circles and rectangles:

![image](https://github.com/YehudaShani/Architect-Arithmetic/assets/99804251/b11342be-5c87-4dda-a132-b0fa60527a37)


Pantheon can be broken into circle radius 21.5m and rectangle 15m by 18m

Using basic formulas, we can calculate the area of each shape and find the total:

double totalArea = Circle(21.5) + Rect(15, 18);

Finally, we multiply the total area by the cost of each unit of flooring material. Let’s assume that tiles cost ₤100 each:

double tileCost = 100;
double totalCost = totalArea * tileCost;

Although the floor plan isn’t exactly one circle and rectangle, this approximation is good enough for estimating costs.
