# Prototype Design Pattern

This project is a example of the Prototype Design Pattern.

The prototype design pattern is a creational design pattern that allows an object to copy itself. It is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects. This pattern is used to:

- avoid subclasses of an object creator in the client application, like the factory method pattern does.
- avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) when it is prohibitively expensive for a given application.

To implement the pattern, declare an abstract base class that specifies a pure virtual clone() method. Any class that needs a "polymorphic constructor" capability derives itself from the abstract base class, and implements the clone() operation.


## When to use the Prototype Design Pattern

- when the classes to instantiate are specified at run-time, for example, by dynamic loading; or 
- to avoid building a class hierarchy of factories that parallels the class hierarchy of products; or
- when instances of a class can have one of only a few different combinations of state. It may be more convenient to install a corresponding number of prototypes and clone them rather than instantiating the class manually, each time with the appropriate state.

## Advantages of the Prototype Design Pattern

- Adding and removing products at run-time.
- Specifying new objects by varying values.
- Specifying new objects by varying structure.
- Reduced subclassing.
- Configuring an application with classes dynamically.

## Disadvantages of the Prototype Design Pattern    

- Overkill for a project that uses very few objects and/or does not require the dynamic creation of new objects.
- Cloning complex objects that have circular references might be very tricky.
