# _Library Database_

 * _Date Created: June 8th 2021_
 * _Date Updated: June 8th 2021_

#### By _**Garrett Brown, Jesse Callahan, Faisal Rana, Sofia Acosta**_

## Title

### User Stories

<details>
    <summary>Expand</summary>

#### User Stories

</details>

## Setup/Installation Requirements
Table of Contents
* Required Programs
* Installation of Program
* Recreate Database
* Startup

<details>
    <summary>Expand for Instructions</summary>

### Required Programs
1. An internet browser.
2. Visual Code Studio (or another code editor).
3. .NET
4. MySQL
5. MySQLWorkbench


### Installation of Program
* _Open the terminal on your local machine and navigate to "Desktop."_
* _Clone "Library.Solution"" with the following git command `https://github.com/GBProductions/Library.Solution`_
* _Navigate to the top level of the repository with the command `cd Library.Solution`_
* _Navigate into "Library" with git command `cd Factory`_


### Recreate Database

#### Instructions: `appsettings.json` Creation

1. Create a file in the root directory called `appsettings.json`. 
2. Add `appsettings.json` to `.gitignore`.
3. Insert the following code into `appsettings.json`:
    
``` 
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=YOUR-DATABASE;uid=root;pwd=YOUR-PASSWORD;"
    }
}
```

4. Replace `YOUR-PASSWORD` with password you selected when installing MySQLWorkbench.
5. Replace `YOUR-DATABASE` with name of database.

### Startup
* Navigate to Factory.Solution folder in project.
* Restore project with git command `dotnet restore`
* Build project with git command `dotnet build`
* To run program, run git command `dotnet run`
* In browser, navigate to http://localhost:5000 

</details>

## Known Bugs

_There are currently no known bugs._

## Support and contact details

_For assistance, please contact Garrett Brown <garrettpaulbrown@gmail.com>_
* Co-authored-by: Sofia Acosta <sofiaacostarascon@gmail.com>
* Co-authored-by: Jesse Callahan <jessetylercallahan@gmail.com>
* Co-authored-by: Faisal Rana <inquisitive@gmail.com>"

## Technologies Used

* _Github, VS Code_
* _Bootstrap, MarkDown_
* _Entity Framework_
* _C#_
* _.NET Core 5.0.1_
* _ASP.NE Core MVC_
* _ASP.NET Core Razor Pages_
* _HTML, CSS_
* _MySQL_
* _MySQLWorkbench_


### License

*Available under MIT Licensing*

Copyright (c) 2021 **_Garrett Brown, Jesse Callahan, Faisal Rana, Sofia Acosta_**



Co-authored-by: Sofia Acosta <sofiaacostarascon@gmail.com>
Co-authored-by: Jesse Callahan <jessetylercallahan@gmail.com>
Co-authored-by: Faisal Rana <inquisitive@gmail.com>"