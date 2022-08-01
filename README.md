# Design Patterns
Some examples of design patterns are developed 

Some examples of design patterns are shown: 
- Adapter
- Factory Method
- Prototype

The following project is developed with Dotnet core v6 and Swagger ui

 To run the application you must run the following command:  `dotnet run `
 
 ## Adapter
 
 The Adapter design pattern converts the interface of a class into another interface clients expect. This design pattern lets classes work together that couldn‘t otherwise because of incompatible interfaces.
 
 The classes and objects participating in this pattern include:

### Target (Chemical Compound)
Defines the domain-specific interface that Client uses

### Adapter (Compound)
Adapts the interface Adaptee to the Target interface.

### Adaptee (Chemical Databank)
Defines an existing interface that needs adapting.

### Client (CompoundController)
Collaborates with objects conforming to the Target interface.

 
 ## Factory Method
 
 The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses.
 
 ### Product (Factory)
 This is an interface for creating the objects.
 
 ### Concrete Creator (ConcreteVehicleFactory)
 This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
 
 ### Creator (VehicleFactory)
 This is an abstract class and declares the factory method, which returns an object of type Product.
 
 ### Concrete Product (Bike, Scooter)
 This is a class which implements the Product interface.
 
 ## Prototype 

 The Prototype design pattern specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
 
 ### Prototype (Dolly Prototype)  
 Declares an interface for cloning itself
 
 ### ConcretePrototype (DollyFirstPrototype, DollySecondPrototype)
 Implements an operation for cloning itself
 
 ### Client (DollyController)
 Creates a new object by asking a prototype to clone itself
 
 
 
 
