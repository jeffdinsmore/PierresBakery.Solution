# _Pierre's Bakery_

#### _Visit Pierre's Bakery to mock buy your choice of bread and/or pastries, 09/25/2020_

#### By _Jeff Dinsmore_

## Description

_This application provides a user to visit Pierre's (virtual) Bakery. As they enter they are welcomed into the bakery and asked if they want to buy any bread. If a user chooses yes, they program will ask how many loaves of bread they want. After the user inputs a number, the program will ask the user if they want to purchase any pastries and how many they want with the same format as the bread questions. After both selections are made, the program will return a price for the total of the items._

Describe: PierresBakery()

Spec 1: The program accepts an inputted 21 grain bread quantity and outputs the calculated price of $5.
* Input: 1
* Output: "$5"

Spec 2: The program accepts an inputted 21 grain bread quantity of 3 and outputs the calculated price of buy 2, get 1 free with a base price of $5 per loaf.
* Input: 3
* Output: "$10"

Spec 3: The program accepts an input of any multiple 21 grain bread quantity and outputs the calculated price of buy 2, get 1 free with a base price of $5 per loaf.
* Input: 5
* Output: "$20"

Spec 4: The program accepts an inputted pastry quantity and outputs the calculated price of $2.
* Input: 1
* Output: "$2"

Spec 5: The program accepts an inputted pastry quantity of 3 and outputs the calculated price of 3 for $5 with a base price of $2 per pastry.
* Input: 3
* Output: "$5"

Spec 6: The program accepts an input of any multiple pastry quantity and outputs the calculated price of 3 for $5 with a base price of $2 per pastry.
* Input: 5
* Output: "$9"

Spec 7: The program accepts an inputted 21 grain and powerseed bread quantity and outputs the calculated price of $11.
* Input: 1, 1
* Output: "$11"

Spec 8: The program accepts an inputted 21 grain and powerseed bread quantity of 3 and 4 respectively and outputs the calculated price of buy 2, get 1 free for 21 grain and buy 3, get 1 free for powerseed with a base price of $5 and $6 per loaf respectively.
* Input: 3, 4
* Output: "$28"

Spec 9: The program accepts an input of any multiple 21 grain and powerseed bread quantity and outputs the calculated price of buy 2, get 1 free with a base price of $5 per loaf and buy 3, get 1 free with a base price of $6 per loaf respectively.
* Input: 7, 9
* Output: "$67"

## Setup/Installation Requirements

* _Clone this repository._
* _Open repository in your preferred code builder program. (This was built in VS Code)_
* _Check both of the .csproj files to ensure the proper framework under the "PropertyGroup" and "TargetFramework". I am using netcoreapp2.2. Your version may be newer_
* _If the framework does not match above, update the version of your netcoreapp by changing the numbers. For example if you are using netcoreapp 3.1, change netcoreapp2.2 to netcoreapp3.1_
* _In the terminal, cd into the PierresBakery.Test directory_
* _Type in the terminal "dotnet restore"_
* _To run the program, cd into the "PierresBakery" directory and type dotnet run in the terminal_
* _The program should now be running_

## Known Bugs

_No known bugs at the this time._

## Support and contact details

_Please check the .csproj files to ensure the proper framework you are running and change if necessary as described in the Setup section_

_Any known issues, please reach out to Jeff Dinsmore by email at hello@jeffdinsmore.com._

## Technologies Used

* _C#_
* _VS Code_

## License

Copyright (c) 2020, **_Jeff Dinsmore_**

This software is licensed under the MIT license.