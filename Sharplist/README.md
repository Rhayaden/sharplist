# Sharplist

Hi! This is my first C# project and my goal here is to show my beginner skills.

<details>
  <summary>Table of Contents</summary>
  <ul>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#get-started">Get Started</a>
      <ul>
        <li><a href="#preparation">Preparation</a></li>
      </ul>
    </li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ul>
</details>

## About the Project

In this project,
Firstly, you create an account. Then, you need to subscribe / choose a plan to continue to real app. In the Sharplist app, there are many shows with different categories. Basically, you select which you want and make your own 'watchlist'. Also, your data will be saved in SQL server.

## Built with

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

## Get Started

### Preparation

SQL Server query for the database preparation:

```sql
CREATE DATABASE sharplist;
CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	user_email NVARCHAR(255) UNIQUE NOT NULL,
	user_password CHAR(60) NOT NULL,
	user_balance DECIMAL(18,2),
	hasPlan BIT DEFAULT 0,
	isFreeTrialUsed BIT DEFAULT 0,
	current_plan VARCHAR(10) CHECK (current_plan IN('Free', 'Monthly', 'Annual')),
	plan_start_date DATE,
	plan_end_date DATE,
	watchlist VARCHAR(500)
	);
```

Enter your connection string in `SqlServerConnection.cs` on the DatabaseAccess folder.

```cs
const string connectionString = "your_connection_string";
```

You need an email which disabled MFA to able to send a mail to the user. You need to reconfigure these in `EmailNotifier.cs` on Notification folder.

```cs
string mail = "email_address";
string pw = "email_address_password";
```

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

MIT License

Copyright (c) 2023 Rhayaden

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contact

Mert Evirgen - rhayaden@gmail.com<br><br>
[![LinkedIn](https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/evirgenmert/)

Project Link: [https://github.com/rhayaden/sharplist](https://github.com/rhayaden/sharplist)
