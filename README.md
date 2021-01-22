<div align="center">

# Parks Lookup

</div>

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>
<h3 align="center">Building an API, 01-22-2021</h3>
<h4 align="center"> By Agata Kolodziej</h4>

## Description

API for state and national parks. The API will list state and national parks.
Include:

- Full CRUD functionality
- Further exploration: authentication, versioning, pagination, Swagger documentation, or CORS
- Complete documentation of API endpoints and further exploration done

Objectives:

- CRUD functionality and successfully returns responses to API calls
- Includes at least one further exploration objective
- Well documented

## User Stories

<details>
  <summary>Expand</summary>

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/Parks-Lookup.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone ` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing MySQL

MySQL is a type of database software used to create, edit, query, and manage SQL data.

- For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
- For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)

- Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`
- If you gain access you will see see the MYSQL command line!

##### Installing MySQL Workbench

- Please [Click Here](https://dev.mysql.com/downloads/workbench/) to install the correct version for your machine
- Open MySQL Workbench and select `Local instance 3306 server`. You will need to enter the password you selected

##### Compiling

- Navigate to the APIParks folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the APIParks folder in the command line
- Use the command `dotnet restore`

<details>

  <summary>Expand for Database Installation Essentials!</summary>

### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
    "Logging": {
        "LogLevel": {
            "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=agata_kolodziej-parks;uid=root;pwd=YourPassword;"
    }
}
```

- Put in your MySQL password in `pwd=YourPassword`. Change the server, port, and uid if necessary.

### Import Database Using Entity Framework Core

1. Navigate to APIParks directory in terminal
2. Use the command `dotnet ef database update` to generate the database through Entity Framework Core

### Update Database Using Entity Framework Core

1. Write any new code you wish to add to the database. Use the command `dotnet build` to check for any compiling errors. If no errors, proceed to step 2.
2. To update the database with any changes made to the code, use the command `dotnet ef migrations add [MigrationsName]`
3. Use the command `dotnet ef database update` to update the database

### Update Database Using MySQL Workbench

1. Open MySQL Workbench
2. Click on Server > Data Import in the top navigation bar
3. Select `Import from Self-Contained File`
4. Select the `Default Target Schema` or create new schema
5. Select all Schema Objects you would like to import
6. Select `Dump Structure and Data`
7. Click `Start Import`

</details>

##### Launch API

- Navigate to Parks-Lookup.Solution/APIParks directory in terminal
- Use the command `dotnet run` to have access to the API in [Postman](https://www.postman.com/downloads/) or browser

##### View In Browser

- To view in browser, navigate to APIParks folder in the command line
- Use the command `dotnet run` to execute the compiled code and start a localhost
- In browser navigate to http://localhost:5000
  TODO

## API Documentation

Explore the API endpoints in Postman or a browser.

##### Using Swagger Documentation

To explore the API with Swashbuckle, launch using the command `dotnet run` in the terminal and go to `http://localhost:5000/swagger`

## Endpoints

Base Url: `https://localhost:5000`

#### HTTP Request Structure

```
GET /api/{value}
POST /api/{value}
GET /api/{value}/{id}
PUT /api/{value}/{id}
DELETE /api/{value}/{id}
```

#### Example Query

`https://localhost:5000/api/states/3`

#### Sample JSON Response

```
 {
        "stateId": 3,
        "stateParkName": "Niagara Falls State Park",
        "stateParkLocation": "New York",
        "stateParkDescription": "Niagara Falls State Park is recognized at the oldest state park in the United States. It contains the American Falls, the Bridal Veil Falls, and a portion of the Horseshoe Falls (also known as the Canadian Falls)."
    }
```

#### State Parks

Find information about a state park!

#### HTTP Request

```
GET /api/states
POST /api/states
GET /api/states/{id}
PUT /api/states/{id}
DELETE /api/states/{id}
```

#### Path Parameters

| Parameter         | Type   | Default | Required | Description                        | Example                                |
| ----------------- | ------ | ------- | -------- | ---------------------------------- | -------------------------------------- |
| stateparkname     | string | none    | false    | Return matches by state park name. | stateparkname=niagara falls state park |
| stateparklocation | string | none    | false    | Return matches by state name       | stateparklocation=new york             |

- For state park names please include 'state park' at the end of the name. Example: na pali coast state park
- For state park locations please enter a state name. Example: hawaii

#### Example Query

`http://localhost:5000/api/states?stateparkname=niagara falls state park&stateparklocation=new york`

#### Sample JSON Response

```
{
      {
        "stateId": 3,
        "stateParkName": "Niagara Falls State Park",
        "stateParkLocation": "New York",
        "stateParkDescription": "Niagara Falls State Park is recognized at the oldest state park in the United States. It contains the American Falls, the Bridal Veil Falls, and a portion of the Horseshoe Falls (also known as the Canadian Falls)."
    }
}
```

#### National Parks

Find information about a national park!

#### HTTP Request

```
GET /api/nationals
POST /api/nationals
GET /api/nationals/{id}
PUT /api/nationals/{id}
DELETE /api/nationals/{id}
```

#### Path Parameters

| Parameter            | Type   | Default | Required | Description                           | Example                                    |
| -------------------- | ------ | ------- | -------- | ------------------------------------- | ------------------------------------------ |
| nationalparkname     | string | none    | false    | Return matches by national park name. | nationalparkname=yellowstone national park |
| nationalparklocation | string | none    | false    | Return matches by state name          | nationalparklocation=wyoming               |

- For national park names please include 'national park' at the end of the name. Example: grand teton national park
- For state park locations please enter a state name. Example: wyoming

#### Example Query

`http://localhost:5000/api/nationals?nationalparkname=yellowstone national park&nationalparklocation=wyoming`

#### Sample JSON Response

```
{
      {
        "nationalId": 1,
        "nationalParkName": "Yellowstone National Park",
        "nationalParkLocation": "Wyoming",
        "nationalParkDescription": "Yellowstone National Park features dramatic canyons, alpine rivers, lush forests, hot springs, and gushing geysers, including its most famous, Old Faithful. Yellowstone Lake is one of the largest high-elevation lakes in North America and is centered over the Yellowstone Caldera, the largest super-volcano on the continent."
    }
}
```

## Known Bugs

This is not a real API.

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

- .NET Core 2.2.0
- ASP.NET Core MVC
  <!-- - ASP.NET Core Razor Pages -->
  <!-- - Bootstrap -->
- C# 7.3
<!-- - CSS -->
- Entity Framework Core 2.2.6
- GitHub
<!-- - HTML -->
- MySQL
- MySQL Workbench
- Postman
- Swagger/Open API
- Swashbuckle 5.5.0
<!-- - [Unsplash](https://unsplash.com/) TODO remove if no UI -->
- API Versioning 4.0.0
- VS Code

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2021 Agata Kolodziej <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8Q_3EVY7j95tTyemJwWxMR7jwvUK7gPe0_w&usqp=CAU" width="2%" height="auto">
