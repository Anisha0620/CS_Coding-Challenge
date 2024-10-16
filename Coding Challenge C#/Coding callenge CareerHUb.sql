create database CareerHub
use CareerHub

-- Create Applicants Table
CREATE TABLE Applicants (
    ApplicantID INT PRIMARY KEY,  
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,  
    Phone NVARCHAR(15)
);

-- Create Companies Table
CREATE TABLE Companies (
    CompanyID INT PRIMARY KEY,  
    CompanyName NVARCHAR(100) NOT NULL,
    Location NVARCHAR(100)
);

-- Create Jobs Table
CREATE TABLE Jobs (
    JobID INT PRIMARY KEY,  
    CompanyID INT NOT NULL,
    JobTitle NVARCHAR(100) NOT NULL,
    JobDescription NVARCHAR(MAX),
    JobLocation NVARCHAR(100),
    Salary DECIMAL(18, 2),
    JobType NVARCHAR(50),  
    PostedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CompanyID) REFERENCES Companies(CompanyID)  
);

-- Create Applications Table
CREATE TABLE Applications (
    ApplicationID INT PRIMARY KEY,  
    JobID INT NOT NULL,
    ApplicantID INT NOT NULL,
    ApplicationDate DATETIME DEFAULT GETDATE(),
    CoverLetter NVARCHAR(MAX),
    FOREIGN KEY (JobID) REFERENCES Jobs(JobID),  
    FOREIGN KEY (ApplicantID) REFERENCES Applicants(ApplicantID)  
);

INSERT INTO Applicants (ApplicantID, FirstName, LastName, Email, Phone) VALUES 
(1, 'Anisha', 'Kabeer', 'anishak@example.com', '123-456-7890'),
(2, 'Varsha', 'Kone', 'Varsha@example.com', '234-567-8901'),
(3, 'Arjith', 'Singh', 'Arjith@example.com', '345-678-9012'),
(4, 'Jonita', 'Gandhi', 'JG@example.com', '456-789-0123'),
(5, 'Godlina', 'Sharon', 'GodlinaSharon@example.com', '567-890-1234');

INSERT INTO Companies (CompanyID, CompanyName, Location) VALUES 
(1, 'Chennai Tech Solutions', 'Chennai'),
(2, 'Mumbai Innovations', 'Mumbai'),
(3, 'Chennai Green Energy', 'Chennai'),
(4, 'Mumbai Digital Media', 'Mumbai'),
(5, 'Chennai Logistics Services', 'Chennai');

INSERT INTO Jobs (JobID, CompanyID, JobTitle, JobDescription, JobLocation, Salary, JobType) VALUES 
(1, 1, 'Software Developer', 'Develop and maintain software applications.', 'Chennai', 80000.00, 'Full-time'),
(2, 2, 'Data Analyst', 'Analyze and interpret complex data.', 'Mumbai', 75000.00, 'Full-time'),
(3, 3, 'Project Manager', 'Manage projects and lead teams.', 'Chennai', 95000.00, 'Full-time'),
(4, 4, 'Graphic Designer', 'Create visual content for marketing.', 'Chennai', 60000.00, 'Part-time'),
(5, 5, 'Sales Executive', 'Drive sales and develop client relationships.', 'Mumbai', 70000.00, 'Full-time');



INSERT INTO Applications (ApplicationID, JobID, ApplicantID, CoverLetter) VALUES 
(1, 1, 1, 'I am very interested in this software developer position.'),
(2, 2, 2, 'I believe my skills in data analysis will be a great fit for this role.'),
(3, 3, 3, 'I have extensive experience in project management and leading teams.'),
(4, 4, 4, 'I am passionate about graphic design and creative marketing.'),
(5, 5, 5, 'I have a strong track record in sales and customer relationship management.');

SELECT * FROM Applicants;
SELECT * FROM Companies;
SELECT * FROM Jobs;
SELECT * FROM Applications;
