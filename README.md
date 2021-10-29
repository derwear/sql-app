# Simple SQL Windows Application
This is the first experience in creating an application with SQL. The entire app is a copy based on [Gosha Dudar's course](https://www.youtube.com/playlist?list=PL0lO_mIqDDFWOMqSKFaLypANf1W7-o87q). The purpose of this repository is to show a little training, and also, if you are interested in how Windows applications are created, you can clone this repository and try this program on your computer.

## Required

 - Microsoft Visual Studio 2019
 -- with Winforms component packages (found in Visual Studio Installer)
 - MySQLConnector (from NuGet manager)
 - Any Creator of Local Servers (I'm used MAMP)
## Required data
You must have [MySQL Connector](https://dev.mysql.com/downloads/windows/installer/8.0.html) *(you install it by changing only the username (from MYSQL to your own) and password (this is all optional, you can leave the standard settings))* installed for everything to work.

After installation, you open [MAMP](https://www.mamp.info/ru/downloads/), click **Start Servers**, if MAMP swears at a busy port, **be sure to release it**, check that Apache Server and MySQL server are enabled, then click **Open WebStart Page** *(then may open phpMyAdmin for graphical representation of basic data types)*

**From the data you should get**

    Host: localhost
    Port: 3306
    User: root
    Password: root

If you have other data, change it in the DB file.cs in the connection and data transfer line. You also have to create a database, create a table there, create rows, it's all specified in the code (required rows).
## Functional

The program has 3 forms: **registration**, **authorization** and the **main window.**

If you have configured MySQL correctly, then all the functionality is as follows

1) You can register by entering your first name, last name, username and password, restrictions are made on empty fields, on the occupied login, the transition to the authorization form is made.
2) On authorization, it will let you in (if the data is correct) to the form of the main window (MainForm), if not, it will transfer you to the registration form, the transition to the registration form has been made.
3) There is nothing in the main window.

P.S: don't forget to create a unique ID column
## Others
Free distribution, copying, whatever is allowed.
Yes, I know that design is shit, next?
The complete creation took 5.5 hours, including the "design".
