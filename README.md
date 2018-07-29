# LibraryManagement

This is a simple Library Management system. This allows a manager to rent books to different users.
The library system is built on top of a generic rental system. 
This rental system can be used to build any kind of rental system (eg, Video rental system, Car rental system)

The generic rental system has the following componants:

1. User
2. UserAccount
3. Role
4. Rental artifacts

The user of this rental system (the library system) should build their specific needs on top of this items by implementing
this classes and providing method overrides.

One specific example is, the library system creates a custom role for childrens. 
This role also checks the age of the user along with other criteria to make sure only age appropriate items are rented to them.
