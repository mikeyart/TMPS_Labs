# Laboratory Work nr.1
## Task 
Create a program/app that implements all 5 creational design patterns
## Creational patterns
1. _Abstract Factory_
2. _Factory Method_
3. _Singleton_
4. _Prototype_
5. _Builder_

## Solution 
In my project I have several classes:
1. _Franchise_  - it uses singleton design pattern and provide us with a pizzaNetwork instance
2. _PizzaNetwork_ - create Andy's pizza store and Corso pizza store
3. _PizzaStore_ and _Pizza_ - use Factory Method Pattern
4. _Pizza_ are made using the Builder Design Pattern
5. _IngredientsFactory_ uses Abstract Factory Design Pattern 

In order to explain how it works, I am going to show it using several diagrams:
Factory Design Pattern: 
![alt text](Diagrams/1.PNG "Logo Title Text 1")

The Menu is prepared using the Builder Pattern:  
![alt text](Diagrams/2.PNG "Logo Title Text 1")

Also we can clone menus using Prototype Pattern:

![alt text](Diagrams/3.PNG "Logo Title Text 1")

Also earlier I mentioned that Franchise use a Singleton (only one Instance can exist) and provide us with an instance of a MenuNetwork class that we use to create MenuStores.
![alt text](Diagrams/4.PNG "Logo Title Text 1")
