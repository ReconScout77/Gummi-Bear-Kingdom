# GummiBearKingdom

## By Robert Murray

#### _A site for an online retailer, October 13, 2017_


## Description

_A site for an online retailer. Website can be easily navigated using the navbar at the top of each page and the links within each webpage. Users can create create, read, update, and delete categories and products using site functionality._

## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Set MySQL Port to 8889_
* _Clone repository_

#### Migrate the database using these commands in the console:
* `dotnet restore`
* `dotnet ef migrations add Initial` (Initial can be any name of your migration, like a commit message)
* `dotnet database update`

## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

#### Inspiration Site
[Amazon](https://www.amazon.com/)

### License

Copyright (c) 2017 **_Robert Murray_**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*