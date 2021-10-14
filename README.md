# DesignPatterns
Design patterns represent the best practices used by experienced object-oriented software developers. Design patterns are solutions to general problems that software developers faced during software development
# Facade pattern
Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system. 
This type of design pattern comes under structural pattern as this pattern adds an interface to existing system to hide its complexities.

This pattern involves a single class which provides simplified methods required by client and delegates calls to methods of existing system classes.

When to use Facade pattern?
When consumer has to interact with multiple entities where the entites are complex or hard to use and can not be refactored.

Advantages:
1-Single point of contact for operations under same category
2-Complexity gets removed

![facade](https://user-images.githubusercontent.com/53540870/137239128-5b564636-719a-4fee-a01d-ea25595d6bd3.PNG)
# Factory pattern
Factory design pattern is a creational design pattern that allows to create object without exposing the creation logic to the 
client and refer to newly created object using a common interface.

Advantages:
1- Avoid duplicate code for aobject creation.
2- Consumer has to only consume the object without worrying how it was created.

![factory](https://user-images.githubusercontent.com/53540870/137239113-30016bc4-c6c9-425c-9dd9-97545418bbee.PNG)
