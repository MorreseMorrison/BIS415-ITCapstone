ALTER TABLE BookTable
ADD FOREIGN KEY (ISBN) REFERENCES CourseBookTable(ISBN);

ALTER TABLE CourseBookTable
ADD FOREIGN KEY (Course_Number) REFERENCES PeirceCollegeCourseCatalogTable(Course_Number);