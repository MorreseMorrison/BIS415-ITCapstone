ALTER TABLE Employee_Table
ADD FOREIGN KEY (Office_ID) REFERENCES Office_Table (Office_ID);


ALTER Table Employee_Table
ADD FOREIGN KEY (Computer_Asset_ID) REFERENCES Computer_Asset_Table (Computer_Asset_ID);

ALTER TABLE Office_Table
ADD FOREIGN KEY (Office_Asset_ID) REFERENCES Office_Asset_Table (Office_Asset_ID);


