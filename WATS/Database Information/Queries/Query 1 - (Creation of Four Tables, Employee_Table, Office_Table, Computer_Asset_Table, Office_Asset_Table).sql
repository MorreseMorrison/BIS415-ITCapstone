CREATE TABLE dbo.Employee_Table (
    Employee_ID INT IDENTITY(100,1) NOT NULL,
	Employee_First_Name VARCHAR (75) NOT NULL,
	Employee_Last_Name VARCHAR (75) NOT NULL,
	Employee_Job_Title VARCHAR (75) NOT NULL,
	Employee_Status VARCHAR (75) NOT NULL,
	Office_ID INT  NOT NULL,
	Employee_Email VARCHAR (75) NOT NULL,
    Computer_Asset_ID INT NOT NULL,
	

	/* Primary Key*/
	PRIMARY KEY (Employee_ID),
	/* Primary Key*/


    )
	
CREATE TABLE dbo.Office_Table (
    
	Office_ID INT IDENTITY(1000,1000) NOT NULL,
	Office_Street_Address VARCHAR (75) NOT NULL,
	Office_City VARCHAR (75) NOT NULL,
	Office_State_Name VARCHAR (75) NOT NULL,
	Office_Zip_Code VARCHAR (75) NOT NULL,
	Office_Name VARCHAR (75) NOT NULL,
	Office_Status VARCHAR (75) NOT NULL,
    Office_Asset_ID INT NOT NULL,

	/* Primary Key*/
	PRIMARY KEY (Office_ID),
	/* Primary Key*/

    )

CREATE TABLE dbo.Computer_Asset_Table (
    
	Computer_Asset_ID INT IDENTITY(1,1) NOT NULL,
	Computer_Asset_Manufacturer VARCHAR (75) NOT NULL,
	Computer_Asset_Model_Type VARCHAR (75) NOT NULL,
	Computer_Asset_Model_Name VARCHAR (75) NOT NULL,
	Computer_Asset_Status VARCHAR (75) NOT NULL,
	Computer_Asset_Purchase_Date DATE NOT NULL,
	Computer_Asset_Disposal_Date DATE,
	Computer_Asset_NBV INT NOT NULL,
	
	

	/* Primary Key*/
	PRIMARY KEY (Computer_Asset_ID),
	/* Primary Key*/


    )


    CREATE TABLE dbo.Office_Asset_Table (
    
	Office_Asset_ID INT IDENTITY(300,10) NOT NULL,
	Office_Asset_Manufacturer VARCHAR (75) NOT NULL,
	Office_Asset_Model_Type VARCHAR (75) NOT NULL,
	Office_Asset_Model_Name VARCHAR (75) NOT NULL,
	Office_Asset_Status VARCHAR (75) NOT NULL,
	Office_Asset_Purchase_Date DATE NOT NULL,
	Office_Asset_Disposal_Date DATE,
	Office_Asset_NBV INT NOT NULL,
	Office_ID INT NOT NULL,
	
	

	/* Primary Key*/
	PRIMARY KEY (Office_Asset_ID),
	/* Primary Key*/


    )





	
	 